#!/usr/bin/env python3
# INFO 1200 M01 Participation
# revised 1/2/2025

def load_statecaps(path="statecaps.txt"):
    """Load state->capital pairs from a CSV file (State,Capital)."""
    caps = {}
    try:
        with open(path, "r", encoding="utf-8") as f:
            for line in f:
                line = line.strip()
                if not line:
                    continue
                # skip possible header line
                if line.lower().startswith("state") and "capital" in line.lower():
                    continue
                parts = line.split(",", 1)
                if len(parts) != 2:
                    continue
                state = parts[0].strip()
                capital = parts[1].strip()
                caps[state.lower()] = capital
    except FileNotFoundError:
        print(f"Data file not found: {path}")
    return caps

def main():
    """
    Main function to search the user input for the state and display the capital.
    """
    print("Welcome to Jason's State Capital Lookup App")
    print()

    state_cap = load_statecaps()
    if not state_cap:
        print("No data loaded. Exiting.")
        return

    prompt = "Please enter a state and I will return the capital (x to exit): "
    userinput = input(prompt).strip()

    while userinput.lower() != "x":
        if not userinput:
            userinput = input(prompt).strip()
            continue

        key = userinput.strip().lower()
        if key in state_cap:
            state_title = key.title()
            print()
            print(f"State: {state_title}")
            print(f"Capital: {state_cap[key]}")
            print()
        else:
            print(f"Could not find '{userinput}' in the database.")
            print()

        userinput = input(prompt).strip()

    print("Good Bye!")

if __name__ == "__main__":
    main()
