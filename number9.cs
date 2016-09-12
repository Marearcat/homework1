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
            Console.WriteLine("Введите вещественное число.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень.");
            int b = Convert.ToInt32(Console.ReadLine());
            a = Math.Pow(a, b);
            Console.Write("Ответ:"); Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
