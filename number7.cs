using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int i; int j = 0;
            for (i = 1; i <= a; i++)
            {
                if ((a % i) == 0)
                {
                    j = j + 1;
                }
            }
            if (j <= 2)
            {
                Console.Write("Простое число.");
            }
            else
            {
                Console.WriteLine("Не является простым числом.");
            }
            Console.ReadKey();
        }
    }
}
