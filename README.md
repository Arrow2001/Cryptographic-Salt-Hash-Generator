# Cryptographic Salt and Hash Generator
This program generates a 256 bit secure salt, outputted as a 64 character string that can be used for hashing to anonymise data.

This is a program I made for my [Pi-Bot](https://github.com/Arrow2001/Pi-Bot) as I was trying to get it to comply with the [GDPR (General Data Protection Regulation)](https://gdpr-info.eu/).
I realised it was better and simpler to make an entirely seperate program for this, rather than bloating my code for the bot.

Most modern day hashing algorithms are 256 bits, which is why it randomly generates a 32 byte number. (1 byte = 8 bits, ergo, 256 / 8 = 32 bytes).
The 32 byte number is originally stored as a byte variable, which is essentially just stored in 1s and 0s (also known as binary).
Because it is stored as binary before, it gets converted into a hexadecimal string to give a long, 64 character, secure salt for people to use.
