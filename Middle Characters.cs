﻿using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleChar(input);
            
        }

        static void MiddleChar(string input)
        {
            if(input.Length % 2 == 0)
            {
                Console.Write(input[(input.Length / 2) - 1]);
                Console.WriteLine(input[input.Length / 2]);
            }   
            else 
            {
                Console.WriteLine(input[input.Length / 2]);
            }
         
        }
    }
}
