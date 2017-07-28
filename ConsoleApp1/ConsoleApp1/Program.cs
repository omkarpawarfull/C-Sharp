using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] array = new int[n];
            int total = 0;
            for (int i = 0; i < n; i++) {
                array[i] = Int32.Parse(Console.ReadLine());
                if (array[i] % 2 == 0) {
                    total = total + array[i];
                }
            }
            Console.WriteLine("total is {0}",total);
            Console.ReadLine();
        }
    }
}
