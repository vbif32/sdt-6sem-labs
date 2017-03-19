using System.Collections.Generic;
using System.Linq;

namespace LabTwo
{
    /// <summary>
    ///     Часть 2
    ///     Из полученного результата выбрать K самых часто встречающихся слов.
    ///     Решение оформить в виде функции, которая принимает данные по словам и возвращает массив самых частых слов.
    ///     Вычислительная сложность — O(N* ln(K)) или O(N), где N — число слов.
    ///     Модуль не используется, но работает. Причины указаны непосредственно над функциями
    /// </summary>
    internal class PartTwo
    {
        /// <summary>
        ///     Чтобы вернуть часто встречающихся слов нужно, эти слова как-то найти.
        ///     А чтобы найти их меньше чем за O(n*k) (просто выбирая максимальный и перемещая его в возвращаемый массив)
        ///     нужно данные как-то отсортировать.
        ///     В моей реализации эта функция малополезна, т.к. отсортировать массив, а потом выделять его начало проще и
        ///     эффективней
        ///     чем при каждом изменении заново сортировать массив (даже если его часть, что допустимо при некоторых сортировках).
        ///     А потом еще и искать нужное место в исходном массиве для выделения.
        /// </summary>
        public IEnumerable<KeyValuePair<string, int>> MostOftenWords(IEnumerable<KeyValuePair<string, int>> words,
            int count)
        {
            var keyValuePairs = words.ToList();
            BucketSort(ref keyValuePairs);
            return keyValuePairs.Take(count);
        }


        /// <summary>
        ///     Собственно сама тоже сортировка не используется, т.к. зачем писать свою сортировку, если можно использовать
        ///     стандартную?
        ///     Но если уж писать, то как-то используя особенности входных данных.
        ///     Для начала, мы сортируем числа, которые соответствуют частоте встречаемости слов в тексте.
        ///     Это значит, что N в большинстве случаев относительно небольшое ( в Войне и мире использовано всего 8998 уникальных
        ///     слов)
        ///     и что большая часть чисел повторяется и находятся в небольшом промежутке (в соответствии с законом Ципфа).
        ///     Поэтому в целом было бы вполне допустимо использовать сортировку Вставками, однако О(n2) не подходит под задание.
        ///     Значит присмотримся к сортировкам за линейное время и выберем самую простую для реализации,
        ///     мне таковой показалась Карманная сортировка.
        ///     P.S. можно было использовать сортировки, которые сортируют начиная с наибольших элементов, например Пирамидальную
        ///     но она не выгодна на малом количестве данных
        /// </summary>
        public static void BucketSort(ref List<KeyValuePair<string, int>> items)
        {
            if (items == null || items.Count() < 2)
                return;

            var maxValue = items[0].Value;
            var minValue = items[0].Value;

            for (var i = 1; i < items.Count(); i++)
            {
                if (items[i].Value > maxValue)
                    maxValue = items[i].Value;

                if (items[i].Value < minValue)
                    minValue = items[i].Value;
            }

            var bucket = new List<KeyValuePair<string, int>>[maxValue - minValue + 1];

            for (var i = 0; i < bucket.Length; i++)
                bucket[i] = new List<KeyValuePair<string, int>>();

            foreach (var t in items)
                bucket[t.Value - minValue].Add(t);

            var position = 0;
            foreach (var t in bucket)
                if (t.Count > 0)
                    foreach (var t1 in t)
                    {
                        items[position] = t1;
                        position++;
                    }
        }
    }
}