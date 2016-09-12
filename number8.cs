using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            int c;
            while (a != 0)
            {
                c = a % 2;
                j = c + j;
                a = a / 2;
            }
            Console.WriteLine(j);
            Console.ReadKey();
        }
    }
}
