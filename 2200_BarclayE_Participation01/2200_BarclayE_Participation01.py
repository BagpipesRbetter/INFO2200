#!/usr/bin/env python3

def load_capitals(path="Capitals.txt"):
    capitals = {}
    with open(path, "r") as file:
        next(file)
        for line in file:
            parts = [p.strip() for p in line.split(",", 1)]
            if len(parts) == 2:
                capitals[parts[0].lower()] = parts[1]
    return capitals

def main():
    capitals = load_capitals()
    if not capitals:
        return
    print("Welcome to Evan's State Capitals Lookup App\n")
    while True:
        state = input("Enter a state (or 'x' to exit): ").strip()
        if not state:
            continue
        if state.lower() == "x":
            break
        capital = capitals.get(state.lower())
        if capital:
            print(f"The capital of {state.title()} is {capital}.\n")
        else:
            print(f"Could not find '{state}' in the database\n")
    print("Goodbye!")

if __name__ == "__main__":
    main()


