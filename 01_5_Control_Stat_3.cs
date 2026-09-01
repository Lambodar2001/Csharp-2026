using System;

internal class Program
{
    private static void Main(string[] args)
    {
        const string correctEmail = "landbrotherv@gmail.com";
        const string correctPassword = "123gg";

        while (true)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (email == correctEmail)
            {
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                if (password == correctPassword)
                {
                    Console.WriteLine("\n✅ Login Successful!");
                    break; // Exit after successful login
                }
                else
                {
                    Console.WriteLine("❌ Wrong Password.\n");
                }
            }
            else
            {
                Console.WriteLine("❌ Invalid Email.\n");
            }
        }
    }
}