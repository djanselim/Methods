using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int[] allNumbers = new int[] { firstNum, secondNum, thirdNum };
            Console.WriteLine(SmallestNum(allNumbers));
            
        }

        static int SmallestNum(int[] allNumbers)
        {
            int smallestNum = int.MaxValue;

            for (int i = 0; i < allNumbers.Length; i++)
            {
                if (allNumbers[i] < smallestNum)
                {
                    smallestNum = allNumbers[i];
                }
            }
            return smallestNum;
        }

        
        

       
    }
}
