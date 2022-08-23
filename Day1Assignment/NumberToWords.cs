using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Day1Assignment
{
    class NumberToWords
    {
        static List<String> words = new List<String> { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        public void Main()
        {
            int number;
            Console.WriteLine("Enter the number:");
            number = Convert.ToInt32(Console.ReadLine());
            string numberToWord = NumerToWord(number);
            Console.WriteLine($"Number To Word is:{numberToWord}");

        }

        private string NumerToWord(int number)
        {
            String word = string.Empty;
            int temp = number;
            while(number!=0)
            {
                temp = number % 10;
                word = words[temp] + " " + word;
                number = number / 10;
            }
            return word;
        }
    }
}
