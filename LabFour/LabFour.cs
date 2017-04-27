using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LabFour
{
    /// <summary>
    /// Дан текстовый файл с миллионом строк. Необходимо найти набор символов, который встречается в каждой строке.
    /// При этом, пустые строки не учитывать.
    /// 
    /// При реализации использовать структуры данных предоставляемые стандартной библиотекой,
    /// функциональные возможности: лямбда-выражения, функции filter, map, reduce.
    /// 
    /// Вычислительная сложность — O(N), дополнительная память — O(M).
    /// N — число строк, M — максимальное число символов в строке.
    /// </summary>
    public static class LabFour
    {
        public static string FindSimilarities(string[] strings)
        {
            var symbols = strings
                .Select(s => s.ToCharArray() as IEnumerable<char>)
                .Aggregate((a,i) => i.Where(a.Contains).Distinct())
                .Aggregate(new StringBuilder(), (a, i) => a.Append(i));
            return symbols.Length == 0 ? "нет соответствий" : symbols.ToString();
        }
    }
}
