#Name: Evan Barclay
#Class:INFO 2200
#Section: 001
#Professor: Sharp
#Date: 10/11/2025
#Midterm Exam
#By submitting this assignment, I declare that the source code contained in this assignment was written solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment instructions, nor obtained from a subscription service. I understand that copying any source code, in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that I will receive a zero on this project if I am found in violation of this policy.
#in addition to the submitted zip all source code is available on github @ https://github.com/BagpipesRbetter/INFO2200
prompt = "Currency Name (x to exit): "
currencies = {}
def loadcontent():
    with open ('currencies.txt', 'r') as file:
        next(file)
        for line in file:
            line = line.strip()
            parts = []
            for part in line.split(";"):
                part = part.strip()
                parts.append(part)
            name, code, symbol = parts
            currencies[name] = symbol
    return currencies
            
def main():
    print("Welcome To Evan's Currency Symbol Lookup")
    user = input(prompt).strip().lower()
    while user != "x":
        if not user:
            user = input(prompt).strip().lower()
            continue
        if user.title() in currencies:
            print(f"The symbol for {user.title()} is {currencies[user.title()]}")
        else:
            print(f"{user.title()} is not in our database. Try again or exit with x.")
        user = input(prompt).strip().lower()
    print("Good Bye")

if __name__ == "__main__":
    loadcontent()
    main()