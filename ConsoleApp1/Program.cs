using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{/// <summary>
 /// Задание 1. Напечатать числа в виде следующей таблицы: a)
 /// </summary>

    internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine();
                Line1();
                Console.WriteLine();
                Line2();
                Console.WriteLine();
                Line3();
                Console.WriteLine();
                Line4();
                Console.Read();
            }
            static void Line1()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
            static void Line2()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
            static void Line3()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
            static void Line4()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(i + "\t");
                }
                Console.WriteLine();
            }
        }
    
}
