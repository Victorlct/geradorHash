using System;
using Microsoft.AspNetCore.Identity;

class Program
{
    static void Main()
    {
        var passwordHasher = new PasswordHasher<object>();
        string senha = "teste";
        string hashedPassword = passwordHasher.HashPassword(null, senha);
        Console.WriteLine($"Hash da senha '{senha}': {hashedPassword}");
    }
}
