using System;
using System.Collections.Generic;

namespace SubarrayRepetitions
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = 30;
            int[] numbers = new int[elements];
            int minNumber = 0;
            int maxNumber = 10;
            int maxCount = 0;
            int count = 1;
            string copyNumber = "";

            Random random = new Random();

            for (int i = 0; i < elements; i++)
            {
                numbers[i] = random.Next(minNumber, maxNumber);
            }

            for (int i = 0; i < elements; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < elements - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;

                    if (maxCount < count)
                    {
                        maxCount = count;
                        copyNumber = numbers[i].ToString();
                    }
                    else if (maxCount == count)
                    {
                        copyNumber += numbers[i].ToString();
                    }
                }
                else
                {
                    count = 1;
                }
            }
            
            for (int i=0; i<copyNumber.Length;i++)
            {
                Console.WriteLine(copyNumber[i]+" Повторяется " + maxCount + " раз");
            } 
        }
    }
}
