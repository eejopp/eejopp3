using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace практич2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Console.WriteLine("Выберете работу программы:");
            Console.WriteLine("1." + "Угадай число");
            Console.WriteLine("2." + "Таблица умножения");
            Console.WriteLine("3." + "Вывод делителей числа");
            Console.WriteLine("4." + "Выход из программы");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 1)
            {
                Random chislo = new Random();
                int cifra = chislo.Next(1, 100);
                Console.WriteLine("Я загадал число, попробуй угадать.");
                for (int i = 1; i < 20; i++)
                {
                    Console.WriteLine("Введи число ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x == cifra)
                    {
                        Console.WriteLine("Ты угадал");
                        Main();
                    }
                    else
                    {
                        if (x < cifra) Console.WriteLine("Больше");
                        else Console.WriteLine("Меньше");
                    }

                }
            }
            else if (number == 2)
            {
                List<int> tabl = new List<int>();
                Console.WriteLine("Таблица умножения:");
                for (int a = 1; a != 10; a++)
                {
                    for (int b = 1; b != 10; b++)
                    {
                        tabl.Add(b * a);
                        if (tabl[b - 1] > 9) Console.Write(tabl[b - 1] + "  ");
                        else Console.Write(tabl[b - 1] + "   ");
                    }
                    tabl.Clear();
                    Console.WriteLine();

                }
                Main();
            }
            else if (number == 3)
            {
                Console.WriteLine("Введи целое число ");
                int celoe = Convert.ToInt32(Console.ReadLine());
                for (int y = 1; y != celoe; y++) if (celoe % y == 0) Console.WriteLine(celoe / y);
                Console.WriteLine("1");
                Main();
            }
            else if (number == 4) 
            { 
                Console.WriteLine("ЙОУ ПОКА");
                return;
            }
            else
            {
                Console.WriteLine("напиши нормальное число");
                Main();
            }
        }
    }
}
