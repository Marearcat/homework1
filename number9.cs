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
            Console.WriteLine("������� ������������ �����.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("������� �������.");
            int b = Convert.ToInt32(Console.ReadLine());
            a = Math.Pow(a, b);
            Console.Write("�����:"); Console.WriteLine(a);
            Console.ReadKey();

        }
    }
}
