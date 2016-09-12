using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            int i;
            int l;
            int k;
            int x = Convert.ToInt32(Console.ReadLine());
            for (i = 1; x > 0; i++)
            {
                k = x % 10;
                l = x / 10; x = l;
                Console.Write(k);
            }
            Console.ReadKey();
        }
    }
}
