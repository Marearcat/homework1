using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            int x = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i<=x; i++)
            {
                if (i % 2 == 1)
                        {
                        Console.Write("1 ");
                        }
                    else
                        {
                        Console.Write("-1 ");
                        }
            }
            Console.ReadKey();
        }
    }
}
