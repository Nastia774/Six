using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите высоту прямоугольника : ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника : ");
            int B = int.Parse(Console.ReadLine());

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
