using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{/// <summary>
 /// Задание 1. Напечатать числа в виде следующей таблицы: в)
 /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write("1 ");
                }
                Console.WriteLine();             
            }
            Console.Read();
        }
        
    }
}
