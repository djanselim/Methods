using System;
using System.Linq;
using System.Runtime;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Console.WriteLine(VowelsCount(text));

        }

        static int VowelsCount(string text)
        {
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u'};
            int vowelsCount = 0;

            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;   
                }
            }
            return vowelsCount;
        }
        
    }
}
