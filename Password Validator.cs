using System;
using System.Linq;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool isLengthValid = isPasswordLengthValid(password);
            bool isPasswordAlphanumeric = IsPasswordAlphanumeric(password);
            bool hasTwoDigits = isPasswordContainsAtLeastTwoDigits(password);

            if (!isLengthValid)
            {
                Console.WriteLine($"Password must be between 6 and 10 characters");
            }
            if (!isPasswordAlphanumeric)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
            }
            if (!hasTwoDigits)
            {
                Console.WriteLine($"Password must have at least 2 digits");
            }

            if(isLengthValid && isPasswordAlphanumeric && hasTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }


        static bool isPasswordLengthValid(string password)
        {
            bool isValid = password.Length >= 6 && password.Length <= 10;
            return isValid;
        }

        static bool IsPasswordAlphanumeric(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
            return true;
        }

        static bool isPasswordContainsAtLeastTwoDigits(string password)
        {
            int digitCount = 0;

            foreach (char charachter in password)
            {
                if (Char.IsDigit(charachter))
                {
                    digitCount++;
                }
            }

            return digitCount >= 2;
        }
    }
}
