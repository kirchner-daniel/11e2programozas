using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat1();
            //  feladat2();
            //  feladat3();
            // feladat4();
            // feladat5();
            //feladat6();
            //feladat7();
            //feladat8();
            //feladat9();
            //feladat10();
        }
        static void feladat1()
        {
            for (int i = 1; i < 21; i++)
            {
                Console.Write("{0} ",i); 
            }
            Console.WriteLine();
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void feladat2()
        {
            for (int i = 15; i < 93; i++)
            {
                Console.Write("{0} ", i);
            }
        }
        static void feladat3()
        {
            for (int i = 1; i < 31; i++)
            {
                if (i%2==0)
                {
                    Console.Write("{0} ",i);
                }

            }
            Console.WriteLine();
            for (int i = 1; i < 31; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} ", i);
                }

            }
        }
        static void feladat4()
        {
            Console.Write("Kérek egy poz. egész számot: ");
            string input = Console.ReadLine();
            for (int i = 1; i < int.Parse(input)+1; i++)
            {
                Console.Write("{0} ",i);
            }
        }
        static void feladat5()
        {
            Console.Write("Kérek egy poz. egész számot: ");
            string input = Console.ReadLine();
            for (int i = 1; i < int.Parse(input) + 1; i++)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void feladat6()
        {
            for (int i = 1; i < 16; i++)
            {
                Console.Write("{0} ",Math.Pow(i,2));
            }
        }
        static void feladat7()
        {
            for (int i = 100; i < 401; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("{0} ", i);
                }

            }
        }
        static void feladat8()
        {
            for (int i = 30; i < 101; i=i+9)
            {
                Console.Write("{0} ",i);
            }
        }
        static void feladat9()
        {
            for (int i = 151 - 1; i >= 39; i=i-12)
            {
                Console.Write("{0} ",i);
            }
        }
        static void feladat10()
        {
            for (int i = 101 - 1; i >= -101; i--)
            {
                if (i % 9 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
