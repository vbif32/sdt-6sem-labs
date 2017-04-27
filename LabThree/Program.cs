using System;
using System.Collections.Generic;

namespace LabThree
{
    public class Program
    {
        private const string Separator = "--------------------------------------------------";

        private const string Welcome = "Выберите желаемое действие.\n" +
                                       "1. Проверка является ли последовательность перестановкой.\n" +
                                       "2. Получить следующую перестановку.\n" +
                                       "3. Сгенерировать случайную перестановку, оценить распределение вероятностей.\n" +
                                       "4. Выход.\n";

        private const string InputSequence = "Введите последовательность";
        private const string InputPermutation = "Введите перестановку";
        private const string InputPermutationLength = "Введите длину последовательности";
        private const string IsPermutationTrue = "Последовательность является перестановкой";
        private const string IsPermutationFalse = "Последовательность НЕ является перестановкой";
        private const string IsPermutation = "1";
        private const string NextPermutation = "2";
        private const string RandPermutation = "3";
        private const string Quit = "4";
        private const string Error = "Ошибочный ввод";

        /*
        static void Main(string[] args)
        {
            var permutation = new Permutation();
            while (true)
            {
                Console.WriteLine(Separator);
                Console.WriteLine(Welcome);
                var partNumber = Console.ReadLine();
                switch (partNumber)
                {
                    case IsPermutation:
                        Console.WriteLine(InputSequence);
                        var seq = ReadInts();
                        Console.ReadLine();
                        Console.WriteLine(permutation.IsPermutation(seq, Config.ArProgIncDiff_1)
                            ? IsPermutationTrue
                            : IsPermutationFalse);
                        break;
                    case NextPermutation:
                        Console.WriteLine(InputPermutation);
                        var perm = ReadInts();
                        var nextPerm = permutation.NextPermutation(perm, Config.ArProgIncDiff_1);
                        PrintList(nextPerm);
                        break;
                    case RandPermutation:
                        Console.WriteLine(InputPermutationLength);
                        var length = Int32.Parse(Console.ReadLine());
                        var randPerm = permutation.RandPermutation<int>(length);
                        PrintList(randPerm);
                        break;
                    case Quit:
                        return;
                    default:
                        Console.WriteLine(Error);
                        break;
                }
            }
        }
        */

        private static void Main(string[] args)
        {
            // part 1
            var permutation1 = new List<int> {1, 2, 3, 4, 5, 6};
            PrintList(permutation1);
            Console.WriteLine(permutation1.IsPermutation(Config.ArProgIncDiff_1)
                ? IsPermutationTrue
                : IsPermutationFalse);

            var permutation2 = new List<int> {8, 12, 6, 9, 11, 7, 10};
            PrintList(permutation2);
            Console.WriteLine(permutation2.IsPermutation(Config.ArProgIncDiff_1)
                ? IsPermutationTrue
                : IsPermutationFalse);

            var notPermutation1 = new List<int> {1, 2, 3, 4, 5, 5};
            PrintList(notPermutation1);
            Console.WriteLine(notPermutation1.IsPermutation(Config.ArProgIncDiff_1)
                ? IsPermutationTrue
                : IsPermutationFalse);

            var notPermutation2 = new List<int> {1, 2, 3, 4, 5, 12};
            PrintList(notPermutation2);
            Console.WriteLine(notPermutation2.IsPermutation(Config.ArProgIncDiff_1)
                ? IsPermutationTrue
                : IsPermutationFalse);

            Console.WriteLine();
            Console.ReadKey();

            // part 2
            var t = permutation1.NextPermutation(Config.ArProgIncDiff_1);
            while (t != null)
            {
                PrintList(t);
                t = t.NextPermutation(Config.ArProgIncDiff_1);
            }

            Console.WriteLine();
            Console.ReadKey();

            // part 3
            var rand = new Random();
            var list = new List<int> {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            var header = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            for (var i = 0; i < int.MaxValue / 10; i++)
            {
                var k = rand.Next(10);
                list[k]++;
            }
            PrintList(header);
            PrintList(list);

            Console.WriteLine();
            Console.ReadKey();

            // part 4
            Permutation.ShuffleTest();
            Console.WriteLine();
            Console.ReadKey();
        }

        private static IList<int> ReadInts()
        {
            var list = new List<int>();
            while (true)
            {
                var s = Console.ReadLine();
                if (s == "\\")
                    break;
                list.Add(int.Parse(s));
            }
            return list;
        }

        private static void PrintList<T>(ICollection<T> list)
        {
            var Range = int.MaxValue / 10;
            var Capacity = 10;
            var format = $"{{0,{(Range / Capacity).ToString().Length + 2}}}";
            foreach (var elem in list)
                Console.Write(format, elem + " ");
            Console.WriteLine();
        }
    }
}