﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{/// <summary>
 /// Задание 4. Вывести на экран наклонную линию (\) из 8 символов.
 /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#");              
            }
            Console.ReadKey();
        }
    }
}
