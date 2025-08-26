#!/usr/bin/env python3
import time
import random

#welcome messages
welcome_messages = [
    "🎉 Welcome to Evan's State Capitol Lookup App! 🎉",
    "🏛️ Ready to test your state capitol knowledge? Let's go! 🏛️",
    "🌟 Let's explore the US state capitols together! 🌟"
]

#main
msg = random.choice(welcome_messages)
for char in msg:
    print(char, end='', flush=True)
    time.sleep(0.03)
print("\n")
