using System;
using System.Collections.Generic;
using System.Linq;

namespace LabOne
{
    /// <summary>
    ///  Часть 2.
    /// Дан массив A, нечетной длины N. Каждый элемент в массиве имеет пару с таким же значением, за исключением одного элемента, который остается без пары.
    /// Например:
    /// A[0] = 3
    /// A[1] = 3
    /// A[2] = 1
    /// A[3] = 2
    /// A[4] = 1
    /// A[5] = 1
    /// A[6] = 2
    /// Элементы A[0] и A[1] парные.
    /// Элементы A[2] и A[4] парные.
    /// Элементы A[3] и A[6] парные.
    /// Элемент A[5] со значением 1 не имеет пары.
    /// Написать функцию, которая возвращает значение элемента, который не имеет пары.
    /// N находится в интервале [1..1 000 000], каждый элемент массива A в интервале [1..1 000 000 000].
    /// В идеальном варианте:
    /// Вычислительная сложность — O(N), используемая память — O(1).
    /// Допустимо:
    /// Вычислительная сложность — O(N ln N), используемая память — O(N).
    /// </summary>
    public class PartTwo
    {
        private const string Welcome =
            "Выбрана первая часть. Выберите режим проверки: ручной(m) или автоматический(a). Для выхода введите 'q'.";

        private const string Manualtest = "m";
        private const string Autotest = "a";
        private const string Quit = "q";
        private const string Error = "Ошибочный ввод";

        private const string ManualtestWelCome =
            "Выбран ручной тест. Проверка введенный данных не проводится! Введение данных, неудовлетворяющим условиям могут вызвать ошибки. Вводите числа разделяя пробелом, символ '\\' будет означать конец ввода массива.";

        private const string AutotestWelCome = "Выбран автоматический тест.";
        private const string AutotestArray = "Сгенерированный массив: ";
        private const string AutotestArrayCount = "Размер сгенерированного массива: ";

        private const string UnpairedElement = "Непарный элемент: ";

        private const int LowerBoundN = 1;
        private const int UpperBoundN = 1000000;

        private const int LowerBoundArrayElement = 1;
        private const int UpperBoundArrayElement = 1000000000;
        
        public void Run()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine(Welcome);

                var partNumber = Console.ReadLine();
                if (partNumber == Manualtest)
                    ManualTest();
                else if (partNumber == Autotest)
                    AutoTest();
                else if (partNumber == Quit)
                    break;
                else
                    Console.WriteLine(Error);
            }
        }

        private void ManualTest()
        {
            Console.WriteLine(ManualtestWelCome);
            var arr = new List<int>();
            while (true)
            {
                int i;
                var s = Console.ReadLine();
                if (s == "\\")
                    break;
                if (int.TryParse(s, out i))
                    arr.Add(i);
            }
            var result = UnPair(arr);

            Console.WriteLine(UnpairedElement);
            Console.Write(result);
            Console.WriteLine();
        }

        private void AutoTest()
        {
            while (true)
            {
                var random = new Random();
                var n = random.Next(LowerBoundN, UpperBoundN);
                if (n % 2 == 0)
                    n--;
                var arr = new List<int>(n);
                for (var i = 1; i < n; i++)
                {
                    var r = random.Next(LowerBoundArrayElement, UpperBoundArrayElement);
                    arr.Add(r);
                    arr.Add(r);
                }
                arr.Add(random.Next(LowerBoundArrayElement, UpperBoundArrayElement));

                arr = Mix(arr);

                Console.WriteLine(AutotestWelCome);
                if (arr.Count < 100)
                {
                    Console.WriteLine(AutotestArray);
                    arr.ForEach(i => Console.Write(i + " "));
                }
                else
                    Console.WriteLine(AutotestArrayCount + arr.Count);

                Console.WriteLine();

                var result = UnPair(arr);

                Console.WriteLine(UnpairedElement);
                Console.Write(result);
                Console.WriteLine();

                if (n >= 100)
                    continue;
                break;
            }
        }

        public object UnPair(List<int> arr)
        {
            var result = arr[0];
            return arr.Aggregate(result, (current, em) => current ^ em);
        }

        public List<T> Mix<T>(List<T> arr)
        {
            var result = new List<T>(arr);
            var random = new Random();
            for (var i = 0; i < result.Count; i++)
            {
                var rnd = random.Next(result.Count);
                var tmp = result[i];
                result[i] = result[rnd];
                result[rnd] = tmp;
            }
            return result;
        }
    }
}