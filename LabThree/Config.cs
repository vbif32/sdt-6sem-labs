// ReSharper disable InconsistentNaming

namespace LabThree
{
    /// Здесь описываются сходные с CompareTo() функции
    /// Они принимают на вход 2 элемента последовательности 
    /// и возвращают количество шагов между ними
    /// или null если элементы не удовлетворяют правилу последовательности
    public static class Config
    {
        /// <summary>
        ///     Возрастающая арифметическая последовательность с шагом 1
        /// </summary>
        public static int? ArProgIncDiff_1(int a, int b)
        {
            return a - b;
        }

        /// <summary>
        ///     Возрастающая арифметическая последовательность с произвольным шагом
        /// </summary>
        public static int? ArProgIncDiff(int a, int b, int step)
        {
            int? c = a - b;
            return c % step == 0 ? c : null;
        }

        /// <summary>
        ///     Убывающая арифметическая последовательность с шагом 1
        /// </summary>
        public static int? ArProgDecDiff_1(int a, int b)
        {
            return ArProgIncDiff_1(b, a);
        }

        /// <summary>
        ///     Убывающая арифметическая последовательность с произвольным шагом
        /// </summary>
        public static int? ArProgDecDiff(int a, int b, int step)
        {
            return ArProgIncDiff(b, a, step) * -1;
        }
    }
}