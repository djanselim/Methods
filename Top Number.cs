using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            TopNumbers(endNumber);
        }


        static void TopNumbers(int endNumber)
        {
            for (int i = 10; i <= endNumber; i++)
            {
                int currNum = i;
                int currNum2 = i;
                int printNum = i;
                bool isCurrDigitOdd = false;
                while (currNum > 0)
                {
                    int lastDigit = currNum % 10;
                    currNum /= 10;

                    if (lastDigit % 2 != 0)
                    {
                        isCurrDigitOdd = true;
                        break;
                    }
                }

                if (isCurrDigitOdd)
                {
                    int numberSum = 0;
                    while (currNum2 > 0)
                    {
                        int lastDigit = currNum2 % 10;
                        currNum2 /= 10;
                        numberSum += lastDigit;
                    }

                    if (numberSum % 8 == 0)
                    {
                        Console.WriteLine(printNum);
                    }
                    else
                    {
                        continue;
                    }

                }

            }
        }
    }
}
