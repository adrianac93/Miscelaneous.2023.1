using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelaneous
{
    public static class Utilities
    {
        public static List<int> Moda(List<int> numbers) 
        {
            var moda = new List<int>();
            //TODO: Pendig
            return moda; 
        }
        public static List<int> Fill(int n, int min, int max)
        {
            var random = new Random();
            var numbers = new List<int>();
            max++;
            for (int i = 0; i < n; i++)
            {
                numbers.Add(random.Next(min, max ));
            }
            return numbers;
        }

        public static string ToString(List<int> numbers)
        {
            var output = string.Empty; 
            foreach (var number in numbers)
            {
                output += $"{number}\t";
            }
            return output + "\n";
        }
    }
}
