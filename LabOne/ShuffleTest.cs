using System;
using System.Collections.Generic;

namespace LabOne
{
    internal class ShuffleTest
    {
        private readonly Random _random = new Random();
        private readonly int[,] _stat = new int[Capacity+1, Capacity+1];

        private const int Range = 10000;
        private const int Capacity = 40;
        private string format = $"{{0,{(Range/Capacity).ToString().Length+2}}}";

        public ShuffleTest()
        {
            for (var i = 1; i < Capacity+1; i++)
            {
                _stat[0, i] = i;
                _stat[i, 0] = i;
            }
        }

        public void Run()
        {
            while (true)
            {
                for (var i = 0; i < Range; i++)
                {
                    var arr = new List<int>();
                    for (var k = 1; k <= Capacity; k++)
                        arr.Add(k);
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
            for (var i = 0; i < Capacity + 1; i++)
            {
                for (var j = 0; j < Capacity + 1; j++)
                    Console.Write(format, _stat[i, j]);
                Console.WriteLine();
            }
        }

        private void ClearStat()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (var i = 1; i < Capacity + 1; i++)
            for (var j = 1; j < Capacity + 1; j++)
                _stat[i, j] = 0;
        }
    }
}