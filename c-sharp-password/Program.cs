using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 5;
            string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowercase = "qwertyuiopasdfghjklzxcvbnm";
            string digits = "1234567890";
            string specialChars = "!@#$%^&*()";
            Console.WriteLine("Enter a password:");
            string userInput = Console.ReadLine();
            int score = 0;
            if (userInput.Length >= minLength)
            {
                score += 1;
            }
            if (Tools.Contains(userInput, uppercase))
            {
                score += 1;
            }
            if (Tools.Contains(userInput, lowercase))
            {
                score += 1;
            }
            if (Tools.Contains(userInput, digits))
            {
                score += 1;
            }
            if (Tools.Contains(userInput, specialChars))
            {
                score += 1;
            }
            Console.WriteLine("Score: " + score);
            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("Extremely strong");
                    break;
                case 3:
                    Console.WriteLine("Strong");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 1:
                    Console.WriteLine("Weak");
                    break;
                default:
                    Console.WriteLine("Below standards!");
                    break;
            }
        }
    }
}
