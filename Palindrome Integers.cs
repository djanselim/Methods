using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while(command != "END")
            {
                int currNum = int.Parse(command);

                if (PalindromeChecker(currNum))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                command = Console.ReadLine();
            }
        }

        static bool PalindromeChecker(int currNum)
        {
            int currNumCoppy = 0;
            int numCoppy = currNum;

            while(numCoppy > 0)
            {
                int lastDigit = numCoppy % 10;
                currNumCoppy = currNumCoppy * 10 + lastDigit;
                numCoppy /= 10;
            }

            if(currNumCoppy == currNum)
            {
                return true;
            }
            else
            {
                return false;
            }
            
            
        }
        
    }
}
