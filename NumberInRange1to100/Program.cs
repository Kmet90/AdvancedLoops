using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number in range [1...100]:");
            int n = int.Parse(Console.ReadLine());

            while (n < 1 || n > 100)
            {
                Console.WriteLine("Invalid nimber!");
                Console.Write("Enter number in range [1...100]:");
                n = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Nimber is :{0}",n);
        }
    }
}
