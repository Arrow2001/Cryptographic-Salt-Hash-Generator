/* This was made solely for my discord / raspberry pi bot
 * I figured it was better to make a standalone program for salt/hashing than having it bloat the code for the bot.*/

using System.Security.Cryptography;

Console.WriteLine($"Cryptographic Salt & Hash Generator\n");
Console.WriteLine($"Press any key to generate a new Salt (to exit: press ctrl+c).");

while (true)
{
    Console.ReadKey(intercept: true);
    byte[] token = RandomNumberGenerator.GetBytes(32);
    string salt = Convert.ToHexString(token).ToLower();
    Console.WriteLine(salt);
}