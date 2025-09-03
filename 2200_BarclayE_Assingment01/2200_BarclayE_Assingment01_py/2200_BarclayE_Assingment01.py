#!/usr/bin/env python3
# INFO 1200 M01 Participation
# revised 09/02/2025

import os
import csv
import random
import sys

def load_collegetowns(path=None):
    """Load college -> town mapping from collegetowns.csv (expects Town,College,...)."""
    if path is None:
        path = os.path.join(os.path.dirname(__file__), "collegetowns.csv")
    mapping = {}
    try:
        with open(path, "r", encoding="utf-8", newline="") as f:
            reader = csv.reader(f)
            for row in reader:
                if not row:
                    continue
                joined = ",".join(row).strip()
                if joined.lower().startswith("town") and "college" in joined.lower():
                    continue
                if joined.lower().startswith("college") and "city" in joined.lower():
                    continue
                if len(row) < 2:
                    continue
                town = row[0].strip()
                college_field = row[1].strip()
                if not college_field:
                    continue
                colleges = college_field.split(";") if ";" in college_field else [college_field]
                for col in colleges:
                    col = col.strip()
                    if not col:
                        continue
                    mapping[col.lower()] = (col, town)
    except FileNotFoundError:
        print(f"Data file not found: {path}", file=sys.stderr)
    return mapping

def main():
    print("Welcome to the College -> Town Lookup App")
    print()
    data = load_collegetowns()
    if not data:
        print("No data loaded. Exiting.")
        return

    keys = list(data.keys())
    prompt = "Please enter a college and I will return the town (type 'random' for a random college, x to exit): "

    while True:
        user = input(prompt).strip()
        if user.lower() == "x":
            break
        if user.lower() == "random":
            if not keys:
                print("No colleges available for random selection.")
                continue
            key = random.choice(keys)
            college_name, town = data[key]
            print()
            print(f"Random College: {college_name}")
            print(f"Town: {town}")
            print()
            continue

        key = user.lower()
        if key in data:
            college_name, town = data[key]
            print()
            print(f"College: {college_name}")
            print(f"Town: {town}")
            print()
        else:
            print(f"Could not find '{user}' in the database.")
            print()

    print("Good Bye!")

if __name__ == "__main__":
    main()