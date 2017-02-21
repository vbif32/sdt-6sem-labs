using System;

namespace LabOne
{
    public class LabOne
    {
        private const string Separator = "--------------------------------------------------";
        private const string Welcome = "Выберите часть лабы (1/2). Для выхода введите 'q'.";
        private const string PartOne = "1";
        private const string PartTwo = "2";
        private const string Quit = "q";
        private const string Error = "Ошибочный ввод";

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(Separator);
                Console.WriteLine(Welcome);
                var partNumber = Console.ReadLine();
                if (partNumber == PartOne)
                    new PartOne().Run();
                else if (partNumber == PartTwo)
                    new PartTwo().Run();
                else if (partNumber == Quit)
                    break;
                else
                    Console.WriteLine(Error);
            }
        }
    }
}