using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabFive
{
    public static class Patterns
    {
        public const string Date_YYYYMMDD = @"[0-9]{4}/(0[1-9]|1[012])/(0[1-9]|1[0-9]|2[0-9]|3[01])";
        public const string Date_DDMMYYYY = @"(0[1-9]|1[0-9]|2[0-9]|3[01])/(0[1-9]|1[012])/[0-9]{4}";
        public const string Time_HHMMSS = @"(0[0-9]|1[0-9]|2[0-3])(:[0-5][0-9]){2}";
        public const string Email = @"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$";
        public const string Domen = @"([a-zA-Z0-9]([a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?\.)+[a-zA-Z]{2,6}";

        private static readonly Regex DateRegex1 = new Regex(Date_DDMMYYYY);
        private static readonly Regex DateRegex2 = new Regex(Date_YYYYMMDD);
        private static readonly Regex TimeRegex = new Regex(Time_HHMMSS);
        private static readonly Regex EmailRegex = new Regex(Email);
        private static readonly Regex DomenRegex = new Regex(Domen);

        private const string ItIs = "Эта строка содержит";
        private const string ItIsDate = " дату";
        private const string ItIsTime = " время";
        private const string ItIsEmail = " email";
        private const string ItIsDomen = " доменное имя";
        private const string ItIsUnknown = "Я не знаю, что это";

        public static string WhatIsIt(string s)
        {
            var rv = ItIs;
            if (DateRegex1.IsMatch(s) || DateRegex2.IsMatch(s))
               rv += ItIsDate;
            if (TimeRegex.IsMatch(s))
               rv += ItIsTime;
            if (EmailRegex.IsMatch(s))
                rv += ItIsEmail;
            if (DomenRegex.IsMatch(s))
                rv += ItIsDomen;
            return rv == ItIs ? ItIsUnknown : rv;
        }

        public static string Swap(string s) => s.Split(' ').Reverse().Aggregate((accumulate, i) => accumulate + " " + i);
    }
}