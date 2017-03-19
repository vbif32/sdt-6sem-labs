using System;
using System.Collections.Generic;

namespace LabOne
{
    internal class ShuffleTest
    {
        private readonly Random _random = new Random();
        private readonly int[,] _stat = new int[11, 11];

        public ShuffleTest()
        {
            for (var i = 1; i < 11; i++)
            {
                _stat[0, i] = i;
                _stat[i, 0] = i;
            }
        }

        public void Run()
        {
            while (true)
            {
                for (var i = 0; i < 10000; i++)
                {
                    var arr = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                    //Print(arr);
                    arr = Shuffle(arr);
                    //Print(arr);
                    for (var j = 0; j < arr.Count; j++)
                        _stat[arr[j], j + 1]++;
                    //Console.WriteLine();
                }
                PrintStat();
                ClearStat();
                Console.ReadKey();
            }
        }

        public List<T> Shuffle<T>(List<T> arr)
        {
            var result = new List<T>(arr);
            for (var i = 0; i < result.Count; i++)
            {
                var rnd = _random.Next(result.Count);
                var tmp = result[i];
                result[i] = result[rnd];
                result[rnd] = tmp;
            }
            return result;
        }

        private static void Print<T>(IEnumerable<T> arr)
        {
            foreach (var i in arr)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        private void PrintStat()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (var i = 0; i < 11; i++)
            {
                for (var j = 0; j < 11; j++)
                    Console.Write("{0,6}", _stat[i, j]);
                Console.WriteLine();
            }
        }

        private void ClearStat()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (var i = 1; i < 11; i++)
            for (var j = 1; j < 11; j++)
                _stat[i, j] = 0;
        }
    }
}