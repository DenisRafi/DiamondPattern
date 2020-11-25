using System;

namespace CA
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Diamond Pattern | ByDenisRafi";
            {
                for (int i = 1; i <= 9; i++)
                {
                    int n = 9;

                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = i; k >= 1; k--)
                    {
                        Console.Write(k);
                    }
                    for (int l = 2; l <= i; l++)
                    {
                        Console.Write(l);
                    }

                    Console.WriteLine();
                }

                for (int i = 8; i >= 1; i--)
                {
                    int n = 8;

                    for (int j = 0; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = i; k >= 1; k--)
                    {
                        Console.Write(k);
                    }
                    for (int l = 2; l <= i; l++)
                    {
                        Console.Write(l);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}
