using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211008
{
    class Program
    {
       static void Main(string[] args)
       {
            feladat12();
           // mintafeladat();
            Console.WriteLine("enter");
            Console.ReadLine();

       }
        static void mintafeladat()
        {
            Console.WriteLine("Kávéautómata");
            Console.WriteLine("A: espresso");
            Console.WriteLine("B: latte machiato");
            Console.WriteLine("C: espresso machiato");
            Console.WriteLine("D: cappuccino");
            Console.WriteLine("E: bécsi kávé");
            Console.WriteLine("F: ristretto");
            Console.WriteLine("G: forró csoki");
            Console.WriteLine("Válassz egy terméket (A-G) ");
            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Az espresso ára 130 Ft.");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen lehetőség!");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("A latte machiato ára 150 Ft.");
                    break;

                case 'C':
                case 'c':
                    Console.WriteLine("Az espresso machiato ára 140 Ft.");
                    break;

                case 'D':
                case 'd':
                    Console.WriteLine("A cappuccino ára 130 Ft.");
                    break;

                case 'E':
                case 'e':
                    Console.WriteLine("A bécsi kávé ára 180 Ft.");
                    break;

                case 'F':
                case 'f':
                    Console.WriteLine("A ristretto ára 160 Ft.");
                    break;

                case 'G':
                case 'g':
                    Console.WriteLine("A forró csoki ára 180 Ft.");
                    break;
            }

            switch (valasztas.ToString().ToLower()) //szöveg típus lett
            {
                case "a":
                Console.WriteLine("Az espresso ára 130 Ft.");
                    break;

                    Console.WriteLine("Nincs ilyen lehetőség!");
                    break;

                case "b":
                    Console.WriteLine("A latte machiato ára 150 Ft.");
                    break;

                case "c":
                    Console.WriteLine("Az espresso machiato ára 140 Ft.");
                    break;

                case "d":
                    Console.WriteLine("A cappuccino ára 130 Ft.");
                    break;

                case "e":
                    Console.WriteLine("A bécsi kávé ára 180 Ft.");
                    break;

                case "f":
                    Console.WriteLine("A ristretto ára 160 Ft.");
                    break;

                case "g":
                    Console.WriteLine("A forró csoki ára 180 Ft.");
                    break;
            }
        }
        static void feladat12()
        {
            Console.WriteLine("Január");
            Console.WriteLine("Február");
            Console.WriteLine("Március");
            Console.WriteLine("Április");
            Console.WriteLine("Május");
            Console.WriteLine("Június");
            Console.WriteLine("Július");
            Console.WriteLine("Augusztus");
            Console.WriteLine("Szeptember");
            Console.WriteLine("Október");
            Console.WriteLine("November");
            Console.WriteLine("December");

            char valasztas = char.Parse(Console.ReadLine());
            switch (valasztas)
            {
                case '1':
                    Console.WriteLine("Január");
                    break;
                
                case '2':
                    Console.WriteLine("Február");
                    break;

                case '3':
                    Console.WriteLine("Március");
                    break;

                case '4':
                    Console.WriteLine("Április");
                    break;

                case '5':
                    Console.WriteLine("Május");
                    break;

                case '6':
                    Console.WriteLine("Június");
                    break;

                case '7':
                    Console.WriteLine("Július");
                    break;

                case '8':
                    Console.WriteLine("Augusztus");
                    break;

                case '9':
                    Console.WriteLine("Szeptember");
                    break;

                //case '10':
                    Console.WriteLine("Október");
                    break;

              //  case '11':
                    Console.WriteLine("November");
                    break;

              //  case '12':
                    Console.WriteLine("December");
                    break;
            }
        }
    }
}
