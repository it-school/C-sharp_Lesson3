using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 12; // 00001100
            Console.WriteLine(a >> 2);

            int b = 20;
            b *= 5;  // b = b * 5;
            Console.WriteLine(b);
            //if ((a > b) || (c > d))

            byte b1 = 1, b2 = 2, b3;
            short sh1;
            int in1;
            //b3 = b1 + b2; //ошибка: результат типа int
            b3 = (byte)(b1 + b2);
            //sh1 = b1 + b2; //ошибка: результат типа int
            sh1 = (short)(b1 + b2);
            in1 = b1 + b2 + sh1;
            Console.WriteLine("b3= " + b3 + " sh1= " + sh1 + " in1= " + in1);

            */

            /* 
            // Проверка, является ли год високосным
            int year = 0;
            bool error = true;

            do
            {
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (error == false)
                {
                    if ((year % 4 != 0) || ((year % 100 == 0) && (year % 400 != 0)))
                        Console.WriteLine("Невисокосный");
                    else
                        Console.WriteLine("Високосный");

                    Console.WriteLine((((year % 4 != 0) || ((year % 100 == 0) && (year % 400 != 0))) ? "Нев" : "В") + "исокосный");
                }
            } while (error);

            */
            
            /*
            // Проврка, является ли билет счастливым
            int ticket = 924456;

            int e=0, d=0, s=0, t=0, dt=0, st=0;
            st = (ticket / 100000) % 10;
            dt = (ticket / 10000 ) % 10;
            t  = (ticket / 1000  ) % 10;
            s  = (ticket / 100   ) % 10;
            d  = (ticket / 10    ) % 10;
            e  = (ticket / 1     ) % 10;             

            Console.WriteLine($"{st} {dt} {t} {s} {d} {e}");

            if ((st + dt + t) == (s + d + e))
                Console.WriteLine("Happy ticket. Eat it!");
            else
                Console.WriteLine("UnHappy ticket");

            */


        }
    }
}
