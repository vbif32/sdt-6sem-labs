using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LabThree
{
    /// класс сделан с использованием возможностей C# по расширению классов,
    /// поэтому первые некоторые функции могут использоваться как метод любого объекта расширяемого класса
    static class Permutation
    {
        /// <summary>
        /// Проверка является ли последовательность перестановкой
        /// Дана последовательность длины N,
        /// необходимо проверить, что она содержит все элементы множества {1,2,3,…,N }
        /// и содержит только их.
        /// Временная сложность O(N), сложность по памяти O(1).
        /// 
        /// Моя проверка опирается на то, что сумма разниц элементов должна равняться разнице между максимальным и минимальным элементами
        /// </summary>
        public static bool IsPermutation<T>(this IList<T> list, Func<T,T, int?> func)
        {
            if (list.Count == 1)
                return true;

            var prev = list[0];
            var min = list[0];
            var max = list[0];

            for (var i = 1; i < list.Count; i++)
            {
                var elem = list[i];
                var diff = func(elem, prev);
                if (diff == null || diff.Value == 0)
                    return false;

                if (func(min, elem) > 0)
                    min = elem;
                if (func(max, elem) < 0)
                    max = elem;
                prev = elem;
            }

            return list.Count-1 == func(max, min);
        }

        /// <summary>
        /// Дана последовательность длины N являющаяся перестановкой.
        /// Найти следующую за ней перестановку в лексикографическом порядке.
        /// Временная сложность O(N), сложность по памяти O(1).
        /// </summary>
        public static IList<T> NextPermutation<T>(this IList<T> perm, Func<T, T, int?> func)
        {
            var pos1 = perm.FindPos1(func);
            if (pos1 == -1)
                return null;

            var nextPerm = new List<T>();
            nextPerm.AddRange(perm);

            var pos2 = nextPerm.FindPos2(func, pos1);
            nextPerm.Swap(pos1, pos2);
            
            var l = pos1 + 1;
            var r = perm.Count - l;
            nextPerm.Reverse(l, r);

            return nextPerm;
        }
        private static int FindPos1<T>(this IList<T> perm, Func<T, T, int?> func)
        {
            var pos1 = perm.Count - 2;
            while (pos1 != -1 && func(perm[pos1],perm[pos1+1]) > 0) pos1--;
            return pos1;
        }
        private static int FindPos2<T>(this IList<T> perm, Func<T, T, int?> func, int pos1)
        {
            var pos2 = perm.Count - 1;
            while (func(perm[pos1], perm[pos2]) > 0)
                pos2--;
            return pos2;
        }
        private static void Swap<T>(this IList<T> a, int i, int j)
        {
            var tmp = a[i]; a[i] = a[j]; a[j] = tmp;
        }

        /// <summary>
        /// Из множества всех перестановок заданной длины N
        /// выбрать случайную с равномерным распределением вероятностей.
        /// Оценить получаемое распределение вероятностей, прогнав алгоритм большое количество раз и построить таблицу,
        /// где по строкам и столбцам будут индексы и получаемые значения в перестановках,
        /// а значения в ячейках — сколько раз данный вариант выпадал.
        /// </summary>
        public static IList<int> RandPermutation(int length)
        {
            var result = new List<int>(length);
            for (int i = 0; i < length; i++)
                result[i] = i;
            return Shuffle(result);
        }
        public static List<T> RandPermutation<T>(this IList<T> list)
        {
            var result = new List<T>(list);
            return Shuffle(result); ;
        }
        private static readonly Random _random = new Random();


        public static void ShuffleTest()
        {
            InitializeStat();
            for (var i = 0; i < Range; i++)
            {
                var arr = Enumerable.Range(1, Capacity).ToList();
                arr = Shuffle(arr);
                CountStat(arr);
            }
            PrintStat();
            ClearStat();
            Console.ReadKey();
        }
        public static List<T> Shuffle<T>(List<T> arr)
        {
            var result = new List<T>(arr);
            var n = result.Count;
            while (n > 1)
            {
                n--;
                var k = _random.Next(n + 1);
                var value = result[k];
                result[k] = result[n];
                result[n] = value;
            }
            return result;
        }

        private const int Range = 10000;
        private const int Capacity = 20;
        private static string format = $"{{0,{(Range / Capacity).ToString().Length + 2}}}";
        private static readonly int[,] _stat = new int[Capacity + 1, Capacity + 1];
        private static void PrintStat()
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
        private static void CountStat(List<int> arr)
        {
            for (var j = 0; j < arr.Count; j++)
                _stat[arr[j], j + 1]++;
        }
        private static void InitializeStat()
        {
            for (var i = 1; i < Capacity + 1; i++)
            {
                _stat[0, i] = i;
                _stat[i, 0] = i;
            }
            ClearStat();
        }
        private static void ClearStat()
        {
            for (var i = 1; i < Capacity + 1; i++)
                for (var j = 1; j < Capacity + 1; j++)
                    _stat[i, j] = 0;
        }

    }
}
