using System;
using System.Collections.Generic;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            //var count = int.Parse(Console.ReadLine());
            var count = 100;
            Console.WriteLine("Введите массив чисел в одну строку, разделяя элементы пробелом");
            //var digitsStrings = Console.ReadLine().Split();
            var digitsStrings = (
                                 "66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 " +
                                 "66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 " +
                                 "66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 " +
                                 "66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 66 "
                                 ).Split();
            var digitsInts = new List<int>(count);
            for (int i = 0; i < count; i++)
                digitsInts.Add(int.Parse(digitsStrings[i]));

            Console.WriteLine(ExamTask.CountMaxSequence(digitsInts));
            Console.ReadKey();
        }
    }
}