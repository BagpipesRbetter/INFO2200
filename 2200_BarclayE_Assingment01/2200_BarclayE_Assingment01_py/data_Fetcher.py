# Used ai to help write the code to scrape college towns from wikipedia
# Combined scraping: "List_of_college_towns" + "Lists_of_American_universities_and_colleges"
# GPT-5 mini (preview) via github copilot on 2025-09-02

from bs4 import BeautifulSoup
import requests
import os
import re
import csv
import time
from urllib.parse import urljoin

BASE = "https://en.wikipedia.org"
HEADERS = {"User-Agent": "Mozilla/5.0 (compatible; INFO2200-bot/1.0)"}

def fetch_soup(url):
    resp = requests.get(url, headers=HEADERS, timeout=15)
    resp.raise_for_status()
    return BeautifulSoup(resp.text, "html.parser")

# added helper to remove citation markers and stray "see also"/"references" text
def _clean(text):
    if not text:
        return ""
    # remove bracketed citations like [1], [ 12 ], [Note 4], [A], etc.
    text = re.sub(r"\[\s*[^]\[]+?\s*\]", "", text)
    # remove leftover superscript/citation markers like "cite_ref-..." in parentheses
    text = re.sub(r"\( ?#?cite_ref[-0-9A-Za-z_ ,]*\)", "", text, flags=re.I)
    # collapse whitespace and strip
    return re.sub(r"\s+", " ", text).strip()

def _is_reference_like(text):
    if not text:
        return True
    t = text.strip().lower()
    # common section headings / non-data labels
    if t in ("references", "see also", "notes", "bibliography", "external links", "outline", "topics"):
        return True
    # lines that look like navigation/footnote artifacts
    if "cite_ref" in t or t.startswith("http") or t.startswith("#"):
        return True
    return False

def parse_collegetowns_page(soup):
    """Return list of tuples (town_names, college_names, town_urls, college_urls)"""
    rows = []
    for li in soup.find_all("li"):
        # remove citation superscripts like <sup>…</sup>
        for sup in li.find_all("sup"):
            sup.extract()
        text = li.get_text(" ", strip=True)
        text = _clean(text)
        if " (" not in text:
            continue
        town_text, uni_text = text.split(" (", 1)
        uni_text = uni_text.rstrip(")")
        links = li.find_all("a")
        town_links, college_links = [], []
        for a in links:
            t = _clean(a.get_text(strip=True))
            if not t or _is_reference_like(t):
                continue
            # decide whether anchor is town or college by presence in town_text
            if t and t in town_text:
                town_links.append(a)
            else:
                college_links.append(a)
        if not town_links or not college_links:
            # fallback: if there are >=2 links assume first is town, rest colleges
            useful = [a for a in links if _clean(a.get_text(strip=True))]
            if len(useful) >= 2:
                town_links = [useful[0]]
                college_links = useful[1:]
            else:
                continue
        town_names = "; ".join(_clean(a.get_text(strip=True)) for a in town_links if _clean(a.get_text(strip=True)))
        college_names = "; ".join(_clean(a.get_text(strip=True)) for a in college_links if _clean(a.get_text(strip=True)))
        town_urls = "; ".join(urljoin(BASE, a.get("href", "")) for a in town_links)
        college_urls = "; ".join(urljoin(BASE, a.get("href", "")) for a in college_links)
        if _is_reference_like(town_names) or _is_reference_like(college_names):
            continue
        rows.append((town_names, college_names, town_urls, college_urls))
    return rows

def table_rows_to_pairs(table):
    """Try to extract (college, town) pairs from an HTML table element."""
    pairs = []
    headers = [th.get_text(" ", strip=True).lower() for th in table.find_all("th")]
    # detect candidate columns
    name_idx = None
    loc_idx = None
    for i, h in enumerate(headers):
        if re.search(r"(name|institution|college|university|school)", h) and name_idx is None:
            name_idx = i
        if re.search(r"(city|town|location|county|place|location\(s\))", h) and loc_idx is None:
            loc_idx = i
    rows = table.find_all("tr")
    for tr in rows[1:] if headers else rows:
        cols = tr.find_all(["td", "th"])
        if not cols:
            continue
        if name_idx is None:
            name_text = cols[0].get_text(" ", strip=True)
        elif name_idx < len(cols):
            name_text = cols[name_idx].get_text(" ", strip=True)
        else:
            continue
        if loc_idx is None:
            loc_text = None
            for c in cols[1:]:
                t = c.get_text(" ", strip=True)
                if re.search(r"\b[A-Z][a-z]+(?:,|\s+\()", t) or len(t) < 50:
                    loc_text = t
                    break
            if loc_text is None and len(cols) > 1:
                loc_text = cols[-1].get_text(" ", strip=True)
        else:
            loc_text = cols[loc_idx].get_text(" ", strip=True) if loc_idx < len(cols) else ""
        # clean both fields
        name_text = _clean(name_text)
        loc_text = _clean(loc_text or "")
        # drop rows that are clearly reference/heading material
        if not name_text or _is_reference_like(name_text) or _is_reference_like(loc_text):
            continue
        m = re.match(r"^(.*?)\s*\(([^)]+)\)\s*$", name_text)
        if m:
            name_text = m.group(1).strip()
            if not loc_text:
                loc_text = m.group(2).strip()
            name_text = _clean(name_text)
            loc_text = _clean(loc_text)
        if name_text:
            pairs.append((name_text, loc_text or ""))
    return pairs

def parse_state_page(soup, page_title=""):
    """Try several heuristics to extract (college, town) pairs from a state list page."""
    pairs = []
    # 1) Look for useful tables
    for table in soup.find_all("table", class_=re.compile(r"wikitable|sortable|plainrowheaders", re.I)):
        pairs.extend(table_rows_to_pairs(table))
    # 2) Look for plain tables without classes
    if not pairs:
        for table in soup.find_all("table"):
            pairs.extend(table_rows_to_pairs(table))
    # 3) Look for <li> entries like "College — City" or "College (City)"
    if not pairs:
        for li in soup.find_all("li"):
            txt = li.get_text(" ", strip=True)
            # remove citations and clean
            txt = _clean(txt)
            if _is_reference_like(txt):
                continue
            m = re.split(r"\s+[—–-]\s+", txt, maxsplit=1)
            if len(m) == 2:
                left, right = _clean(m[0]), _clean(m[1])
                if not _is_reference_like(left) and not _is_reference_like(right):
                    pairs.append((left, right))
                    continue
            m2 = re.match(r"^(.*?)\s*\(([^)]+)\)\s*$", txt)
            if m2:
                left, right = _clean(m2.group(1)), _clean(m2.group(2))
                if not _is_reference_like(left):
                    pairs.append((left, right))
                    continue
            m3 = re.match(r"^(.*?)[,]?\s+located\s+in\s+(.+)$", txt, re.I)
            if m3:
                left, right = _clean(m3.group(1)), _clean(m3.group(2))
                if not _is_reference_like(left):
                    pairs.append((left, right))
    # 4) last resort: find anchors (assume anchor text is college name, page title or section may give location)
    if not pairs:
        for a in soup.find_all("a"):
            name = a.get_text(" ", strip=True)
            if not name or len(name.split()) < 2:
                continue
            # try to infer location from surrounding text
            parent = a.find_parent()
            context = parent.get_text(" ", strip=True) if parent else ""
            m = re.search(r"\(([^)]+)\)", context)
            loc = m.group(1).strip() if m else ""
            if name and loc:
                pairs.append((name, loc))
    # normalize: remove duplicates and clean whitespace
    norm = []
    seen = set()
    for name, loc in pairs:
        n = re.sub(r"\s+", " ", _clean(name)).strip()
        l = re.sub(r"\s+", " ", _clean(loc)).strip()
        key = (n.lower(), l.lower())
        if key in seen:
            continue
        seen.add(key)
        norm.append((n, l))
    return norm

def find_state_list_links(index_soup):
    """From the Lists_of_American_universities_and_colleges page, find candidate per-state list links."""
    links = set()
    for a in index_soup.find_all("a", href=True):
        txt = a.get_text(" ", strip=True)
        href = a["href"]
        # candidate by text or href containing "List of" + colleges/universities
        if re.search(r"List of .* (colleges|universities|universities and colleges|colleges and universities)", txt, re.I):
            links.add(urljoin(BASE, href))
            continue
        if re.search(r"/wiki/List_of_.*(colleges|universities)", href, re.I):
            links.add(urljoin(BASE, href))
    return sorted(links)

def main():
    out_path = os.path.join(os.path.dirname(__file__), "colleges_us.txt")
    seen = set()
    results = []

    try:
        print("Fetching lists index page...")
        index_soup = fetch_soup(BASE + "/wiki/Lists_of_American_universities_and_colleges")
        state_links = find_state_list_links(index_soup)
        print(f"Found {len(state_links)} candidate state/region list links.")
        # iterate through state/region pages (these are US lists)
        for i, link in enumerate(state_links, 1):
            try:
                print(f"[{i}/{len(state_links)}] Fetching {link}")
                s = fetch_soup(link)
                pairs = parse_state_page(s, page_title=link)
                for col, town in pairs:
                    key = (col or "").strip().lower()
                    if not key or key in seen:
                        continue
                    seen.add(key)
                    # format in title case as requested
                    college_title = (col or "").title().strip()
                    town_title = (town or "").title().strip()
                    if town_title:
                        results.append(f"{college_title}, {town_title}")
                    else:
                        results.append(f"{college_title}")
                time.sleep(0.5)
            except Exception as e:
                print("  error parsing", link, e)
    except Exception as e:
        print("Failed to fetch/parse lists index page:", e)

    # write plain text file with one entry per line in the requested format
    with open(out_path, "w", encoding="utf-8") as f:
        for line in sorted(results):
            f.write(line + "\n")

    print(f"Wrote {len(results)} lines to {out_path}")

if __name__ == "__main__":
    main()