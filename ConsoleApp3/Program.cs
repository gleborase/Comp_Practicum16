using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
 /// Задание 1. Напечатать числа в виде следующей таблицы: в)
 /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
