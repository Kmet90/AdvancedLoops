using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            if (n == 1) Console.WriteLine(n);
            else
            {
                Console.WriteLine(num);
                for (int i = 0; i < n; i += 2)
                {
                    num = num * 4;
                    Console.WriteLine(num);
                }
            }
            
            
        }
    }
}
