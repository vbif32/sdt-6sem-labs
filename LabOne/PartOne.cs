using System;
using System.Collections.Generic;

namespace LabOne
{
    /// <summary>
    ///     Часть 1.
    ///     Дан массив A, длины N, дано целое число K.Надо циклически сдвинуть массив A на K элементов вправо. Если K
    ///     отрицательно — сдвиг идет влево.
    ///     Например: A = [3, 2. 5, 9, 7], K = 3.Результат будет: [5, 9, 7, 3, 2].
    ///     Решение оформить в виде функции, которая принимает в качестве параметров массив и число K и возвращает сдвинутый
    ///     массив.
    ///     N в интервале[0..100]. K в интервале[-100..100]. Каждый элемент массива A в интервале [1000..1000].
    /// </summary>
    public class PartOne
    {
        private const string Welcome =
            "Выбрана первая часть. Выберите режим проверки: ручной(m) или автоматический(a). Для выхода введите 'q'.";

        private const string Manualtest = "m";
        private const string Autotest = "a";
        private const string Quit = "q";
        private const string ErrorInput = "Ошибочный ввод";

        private const string ManualtestWelCome =
            "Выбран ручной тест. Вводите элементы массива по одному в строке, символ '\\' будет означать конец ввода массива.";

        private const string ManualTestInputK = "Введите количество ячеек, на которые нужно сдвинуть массив вправо.";
        private const string ManualTestArray = "Введенный массив:";

        private const string AutoTestWelCome = "Выбран автоматический тест.";
        private const string AutoTestN = "Сгенерированный размер массива: ";
        private const string AutoTestK = "Сгенерированный сдвиг массива: ";
        private const string AutoTestArray = "Сгенерированный массив: ";

        private const string ShuffledArray = "Сдвинутый массив: ";

        private const int UpperBoundN = 99;

        private const int UpperBoundK = 100;
        private const int LowerBoundK = -100;

        private const int UpperBoundArrayElement = 1000;
        private const int LowerBoundArrayElement = -1000;

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
                    Console.WriteLine(ErrorInput);
            }
        }

        private void ManualTest()
        {
            Console.WriteLine(ManualtestWelCome);

            string s;

            var arr = new List<object>();
            while (true)
            {
                s = Console.ReadLine();
                if (s == "\\")
                    break;
                arr.Add(s);
            }

            Console.WriteLine(ManualTestInputK);
            s = Console.ReadLine();
            int k;
            while (!int.TryParse(s, out k))
            {
                Console.WriteLine(ErrorInput);
                Console.WriteLine(ManualTestInputK);
                s = Console.ReadLine();
            }
            
            Console.WriteLine(ManualTestArray);
            arr.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            arr = Shift(arr, k);
            Console.WriteLine(ShuffledArray);
            arr.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }

        private void AutoTest()
        {
            var random = new Random();
            var n = random.Next(UpperBoundN) + 1;
            var k = random.Next(UpperBoundK - LowerBoundK) + LowerBoundK;
            var arr = new List<object>();
            for (var i = 0; i < n; i++)
                arr.Add(random.Next(LowerBoundArrayElement, UpperBoundArrayElement));

            Console.WriteLine(AutoTestWelCome);
            Console.WriteLine(AutoTestN + n);
            Console.WriteLine(AutoTestK + k);

            Console.WriteLine(AutoTestArray);
            arr.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();

            arr = Shift(arr, k);

            Console.WriteLine(ShuffledArray);
            arr.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }

        public List<T> Shift<T>(List<T> arr, int k)
        {
            var n = arr.Count;

            if (k == 0)
                return new List<T>(arr);

            if (Math.Abs(k) > n)
                k = k % n;
            if (Math.Abs(k) > n / 2)
                k = -(n - Math.Abs(k));

            var result = new List<T>(n);
            if (k > 0)
            {
                for (int i = 0, j = n - k; i < n; i++, j++)
                    result.Add(j < n ? arr[j] : arr[j - n]);
            }
            else
            {
                k = -k;
                for (int i = 0, j = k; i < n; i++, j++)
                    result.Add(j < n ? arr[j] : arr[j - n]);
            }
            return result;
        }
    }
}