using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число А : ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите число В : ");
            int B = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = A + 1; i < B; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Сумма чисел между {A} и {B} = {sum}");

            Console.Write($"Все непарные числа между {A} и {B} : ");
            for (int i = A + 1; i < B; i++)
            {
                if (i % 2 == 1)
                {

                    Console.Write($"{i} ");

                }
            }

            Console.ReadKey();
        }
    }
}
