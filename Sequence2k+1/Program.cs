using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 1;

            while (sum <= n) 
            {
                Console.WriteLine(sum);
                sum = 2 * sum + 1;
            }
        }
    }
}
