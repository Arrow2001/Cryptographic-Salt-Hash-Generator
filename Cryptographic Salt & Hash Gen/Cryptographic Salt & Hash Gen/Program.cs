/* This was made solely for my discord / raspberry pi bot
 * I figured it was better to make a standalone program for salt/hashing than having it bloat the code for the bot.*/

using System.Security.Cryptography;

byte[] token = RandomNumberGenerator.GetBytes(32);
string salt = Convert.ToHexString(token).ToLower();
Console.WriteLine(salt); 