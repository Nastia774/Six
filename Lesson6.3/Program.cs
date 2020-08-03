using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            int x = 8;
            int y = 8;
            int z = 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                y -= 1;
                z += 2;
                Console.Write("\n");
            }

            x = 8;
            y = 8;
            z = 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                y -= 1;
                z += 2;
                Console.Write("\n");
            }

            x = 8;
            y = 1;
            z = x * 2 - 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < z; k++)
                {
                    Console.Write("*");
                }
                y += 1;
                z -= 2;
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
