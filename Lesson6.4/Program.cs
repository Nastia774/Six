using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество клиентов: ");
            int N = int.Parse(Console.ReadLine());
            int var = 1;
            do
            {
                var *= N--;
            } while (N>0);

            Console.WriteLine($"Количество возможных маршрутов : {var}");
            Console.ReadKey();
        }
    }
}
