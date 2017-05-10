using System;
using System.Collections.Generic;
using System.Linq;

namespace LabFive
{
    class LabFive
    {
        private const string Separator = "--------------------------------------------------";
        private const string Welcome = "Выберите нужно распознать строку или поменять 2 слова местами(1/2). Для выхода введите 'q'.";
        private const string PartOne = "1";
        private const string PartTwo = "2";
        private const string Quit = "q";
        private const string Error = "Ошибочный ввод";
        private const string Input = "Введите строку для проверки";
        
        //static void Main(string[] args)
        //{
        //    while (true)
        //    {
        //        Console.WriteLine(Separator);
        //        Console.WriteLine(Welcome);
        //        var partNumber = Console.ReadLine();
        //        if (partNumber == PartOne)
        //        {
        //            Console.WriteLine(Input);
        //            Console.WriteLine(Patterns.WhatIsIt(Console.ReadLine().Trim()));
        //        }
        //        else if (partNumber == PartTwo)
        //        {
        //            Console.WriteLine(Input);
        //            var s = Console.ReadLine().Trim();
        //            Console.WriteLine(s.Contains(' ') ? Patterns.Swap(s) : Error);
        //        }
        //        else if (partNumber == Quit)
        //            break;
        //        else
        //            Console.WriteLine(Error);
        //    }
        //}

        static void Main(string[] args)
        {
            var RecognizeTestStrings = new List<string>
            {
                "31/12/2017",
                "12:00:00",
                "31/12/2017 12:00:00",
                "test@test.com",
                "test.com",
                "just string"
            };
            
            foreach(var s in RecognizeTestStrings)
                Console.WriteLine(s + " " + Patterns.WhatIsIt(s));

            var SwapTestStrings = new List<string>
            {
                "раз два"
            };


            foreach (var s in SwapTestStrings)
                Console.WriteLine(Patterns.Swap(s));
            Console.ReadKey();
        }
    }
}
