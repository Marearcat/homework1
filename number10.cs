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
            Console.WriteLine("������� ����������� �����:");
            int a = Convert.ToInt32(Console.ReadLine());
            int i;
            Console.WriteLine("��� ��������:");
            for (i = 1; i<=a; i++)
            {
                if ((a % i) == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
