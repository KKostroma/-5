using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7]; 
            int S = 0;
            int m = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                S += array[i];
                m = S / 7;

            }
            Console.WriteLine();
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
