using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorielOne = int.Parse(Console.ReadLine());
            int factorielTwo = int.Parse(Console.ReadLine());
            double firstNumFactoriel = FactorielSum(factorielOne);
            double secondNumFactoriel = FactorielSum(factorielTwo);
            PrintSum(firstNumFactoriel, secondNumFactoriel);
        }


        static void PrintSum(double firstNum, double secondNum) => Console.WriteLine($"{firstNum / secondNum:F2}");

        static double FactorielSum(int number)
        {
            double total = 1;

            for (int i = 2; i <= number; i++)
            {
                total *= i;
            }

            return total;
        }
    }
}
