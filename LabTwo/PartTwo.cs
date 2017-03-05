using System;
using System.Collections.Generic;
using System.Linq;

namespace LabTwo
{
    /// <summary>
    ///     Часть 2
    ///     Из полученного результата выбрать K самых часто встречающихся слов.
    ///     Решение оформить в виде функции, которая принимает данные по словам и возвращает массив самых частых слов.
    ///     Вычислительная сложность — O(N* ln(K)) или O(N), где N — число слов.
    /// </summary>
    internal class PartTwo
    {

        public static Dictionary<T, int> MostOfterWords<T>(Dictionary<T, int> array, int digits)
        {
            //TODO: допилить вторую часть
            var arr = Sort(array.Values.ToArray());
            return null;
        }


        private static int[] Sort(int[] array) => RadixSortAux(array, 1);

        private static int[] RadixSortAux(int[] array, int digit)
        {
            while (true)
            {
                var empty = true;
                var digits = new KvEntry[array.Length]; //array that holds the digits;
                var sortedArray = new int[array.Length]; //Hold the sorted array
                for (var i = 0; i < array.Length; i++)
                {
                    digits[i] = new KvEntry();
                    digits[i].Key = i;
                    digits[i].Value = array[i] / digit % 10;
                    if (array[i] / digit != 0)
                        empty = false;
                }

                if (empty)
                    return array;

                var sortedDigits = CountingSort(digits);
                for (var i = 0; i < sortedArray.Length; i++)
                    sortedArray[i] = array[sortedDigits[i].Key];
                array = sortedArray;
                digit = digit * 10;
            }
        }

        private static KvEntry[] CountingSort(KvEntry[] arrayA)
        {
            var arrayB = new int[MaxValue(arrayA) + 1];
            var arrayC = new KvEntry[arrayA.Length];

            for (var i = 0; i < arrayB.Length; i++)
                arrayB[i] = 0;

            foreach (var t in arrayA)
                arrayB[t.Value]++;

            for (var i = 1; i < arrayB.Length; i++)
                arrayB[i] += arrayB[i - 1];

            for (var i = arrayA.Length - 1; i >= 0; i--)
            {
                var value = arrayA[i].Value;
                var index = arrayB[value];
                arrayB[value]--;
                arrayC[index - 1] = new KvEntry
                {
                    Key = i,
                    Value = value
                };
            }
            return arrayC;
        }

        private static int MaxValue(KvEntry[] arr)
        {
            var max = arr[0].Value;
            for (var i = 1; i < arr.Length; i++)
                if (arr[i].Value > max)
                    max = arr[i].Value;
            return max;
        }

        private struct KvEntry
        {
            private int _key;

            public int Key
            {
                get { return _key; }
                set
                {
                    if (_key >= 0)
                        _key = value;
                    else
                        throw new Exception("Invalid key value");
                }
            }

            public int Value { get; set; }
        }
    }
}