﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int tahmin = 0, tutulan, sayac = 0;
            Random rasgele = new Random();

            tutulan = rasgele.Next(1, 100);
            while (tahmin != tutulan)
            {
                sayac++;
                Console.WriteLine("Sayı girin : ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > tutulan)
                {
                    Console.WriteLine("Sayıyı küçült");

                }
                else if (tahmin < tutulan)
                {
                    Console.WriteLine("Sayıyı büyült ");

                }
            }
            Console.WriteLine("Tebrikler.");
            Console.WriteLine("{0}.hakkınızda bildiniz", sayac);


            Console.ReadKey();



        }
    }
}
