using System;

namespace StairwayToHeaven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I will render a staircase for you.");
            Console.WriteLine();
            Console.WriteLine("What size?");

            int n;
            string space = "_";
            string line = "*";
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
         
            while (n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(space, n);
                }
                for (int p = 0; p < n; p++)
                {
                    Console.Write(line += "*");
                }
                n--;
                Console.WriteLine();
            }
            
        }
    }
}

