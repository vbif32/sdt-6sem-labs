using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    static class ExamTask
    {
        public static int CountMaxSequence(IEnumerable<int> arr)
        {
            var min = arr.Min();
            var max = arr.Max();
            var size = max - min + 1;
            if (size < 2)
                return arr.Count();
            var counts = new int[size];

            foreach (var item in arr)
                counts[item - min]++;

            var result = counts[0];
            for (int i = 0; i < counts.Length - 1; i++)
            {
                var tmp = counts[i] + counts[i + 1];
                if (tmp > result)
                    result = tmp;
            }

            return result;
        }
    }
}