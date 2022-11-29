using System;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int add = AddNumbers(firstNum, secondNum);
            int result = SubtractNumbers(add, thirdNum);
            Console.WriteLine(result);

        }

        static int AddNumbers(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        static int SubtractNumbers(int add, int thirdNum)
        {
            int result = add - thirdNum;
            return result;
        }
    }
}
