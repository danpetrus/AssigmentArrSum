using System;

namespace SumArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] numbersAsString;
            int i = 0;
            int old = 0;

            Console.WriteLine("Please enter numbers with comma ',' between them: ");
            input = Console.ReadLine();

            numbersAsString = input.Split(",");

            //init int array with length of split string
            int[] numbers = new int[numbersAsString.Length];
            int[] numbersSum = new int[numbersAsString.Length];

            // print and add each element to int array
            foreach (string nb in numbersAsString)
            {
                numbers[i] = int.Parse(nb);
                Console.Write(numbers[i]);
                Console.Write(" ");
                i++;
            }

            Console.WriteLine(" ");
            i = 0;

            foreach (int nb in numbers)
            {
                numbersSum[i] = nb + old;
                Console.Write(numbersSum[i]);
                Console.Write(" ");
                old = nb + old;
                i++;
            }


        }
    }
}
