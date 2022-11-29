using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command
                    .Split(' ');

                string cmdType = cmdArgs[0];

                if (cmdType == "exchange")
                {
                    int index = int.Parse(cmdArgs[1]);
                    if (index < 0 || index >= arr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    arr = ExchangeArray(arr, index);
                }
                else if (cmdType == "max" || cmdType == "min")
                {
                    string evenOrOddArg = cmdArgs[1];
                    int indexOfEl;
                    if (cmdType == "max")
                    {
                        indexOfEl = IndexOfMaxEvenOrOddElement(arr, evenOrOddArg);
                    }
                    else
                    {
                        indexOfEl = IndexOfMinEvenOrOddElement(arr, evenOrOddArg);
                    }

                    if (indexOfEl == -1)
                    {
                        //No matching element
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(indexOfEl);
                }
                else if (cmdType == "first" || cmdType == "last")
                {
                    int count = int.Parse(cmdArgs[1]);
                    string evenOrOddArg = cmdArgs[2];

                    if (count > arr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }
                    int[] elements;
                    if(cmdType ==  "first")
                    {
                        elements = FirstEvenOrOddElements(arr, count, evenOrOddArg);
                    }
                    else
                    {
                        elements = LastEvenOrOddElements(arr, count, evenOrOddArg);
                    }
                    PrintArray(elements);
                }
            }
            PrintArray(arr);
        }
        // Returns the modify version of array
        static int[] ExchangeArray(int[] originalArr, int index)
        {
            int[] modifiedArray = new int[originalArr.Length];
            int modifiedArrayIndex = 0;

            for (int i = index + 1; i < originalArr.Length; i++)
            {
                modifiedArray[modifiedArrayIndex++] = originalArr[i];
            }

            for (int i = 0; i <= index; i++)
            {
                modifiedArray[modifiedArrayIndex++] = originalArr[i];
            }

            return modifiedArray;
        }

        // Returns the index of the max even/odd element
        static int IndexOfMaxEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            // Default value for maxIndex which means there is no match
            int maxIndex = -1;
            int currMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currMax % 2 == 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum >= currMax)
                    {
                        currMax = currNum;
                        maxIndex = i;
                    }
                }

            }
            return maxIndex;
        }

        static int IndexOfMinEvenOrOddElement(int[] arr, string evenOrOddArg)
        {
            // Default value for maxIndex which means there is no match
            int minIndex = -1;
            int currMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {
                    if (currNum <= currMin)
                    {
                        currMin = currNum;
                        minIndex = i;
                    }
                }

            }
            return minIndex;
        }

        static int[] FirstEvenOrOddElements(int[] arr, int count, string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {

                }
            }
            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            firstElArr = ReverseArray(firstElArr);
            return firstElArr;
        }

        static int[] LastEvenOrOddElements(int[] arr, int count,string evenOrOddArg)
        {
            int[] firstElArr = new int[count];
            int firstElArrIndex = 0;
            for (int i = arr.Length - 1; i >= 0; i++)
            {
                if (firstElArrIndex >= count)
                {
                    break;
                }
                int currNum = arr[i];
                if (evenOrOddArg == "even" && currNum % 2 == 0)
                {
                    firstElArr[firstElArrIndex++] = currNum;
                }
                else if (evenOrOddArg == "odd" && currNum % 2 != 0)
                {

                }
            }
            firstElArr = ResizeArray(firstElArr, firstElArrIndex);
            firstElArr = ReverseArray(firstElArr);
            return firstElArr;
        }

        static int[] ResizeArray(int[] originalArr, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = originalArr[i];
            }
            return modifiedArray;
        }

        static int[] ReverseArray(int[] originalArray)
        {
            int[] reversed = new int[originalArray.Length];
            for (int i = originalArray.Length; i >= 0; i--)
            {
                reversed[reversed.Length - i - 1] = originalArray[i];
            }
            return reversed;
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }
    }
}
