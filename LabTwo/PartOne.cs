using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LabTwo
{
    /// <summary>
    ///     Часть 1
    ///     Написать программу разбивающую текст на слова и подсчитывающую сколько раз встречается каждое слово.
    ///     Например, дан текст: «aaa bbb: ccc, aaa eee - bbb aaa».
    ///     Программа должна вывести:
    ///     aaa 3
    ///     bbb 2
    ///     ccc 1
    ///     eee 1
    ///     Решение оформить в виде функции, которая принимает строку или поток и возвращает данные по словам.
    ///     Предусмотреть возможность чтения данных из файла
    /// </summary>
    public class PartOne
    {
        public static Dictionary<string, int> Split(Stream s) => Split(s.ToString());

        /// <summary>
        /// Отдельно стоящие числа считаются словами
        /// </summary>
        public static Dictionary<string, int> Split(string s)
        {
            const string pattern = @"\W+";
            var wordList = Regex.Split(s, pattern);
            var grouped = wordList
                .GroupBy(i => i)
                .Select(i => new {Word = i.Key, Count = i.Count()})
                .ToDictionary(i => i.Word, v => v.Count);

            return grouped;
        }
    }
}