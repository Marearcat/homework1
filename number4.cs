using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int f = s.Length;
            int i;
            int k = f / 2;
            int j = 0;
            int a;
            for (i = 0; i<=(k-1); i++)
            {
                if (s[i] == s[f-i])
                {
                    j = j + 1;
                }
            }

        if (j == k)
            {
                Console.WriteLine("yes");
            }
        else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
