using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharRange(a, b);
        }

       private static void CharRange(char a, char b)
        {
            int startIndex = Math.Min(a, b);
            int endIndex = Math.Max(a, b);


            for (int i = startIndex + 1; i < endIndex; i++)
            {
                Console.Write((char)i + " ");   
            }
        }

       
    }
}
