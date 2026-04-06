using System;
using System.Diagnostics.CodeAnalysis;

namespace _2._osa
{
    internal class StartPage
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n--- MENÜÜ ---");
                Console.WriteLine("1 - Juku kinopilet");
                Console.WriteLine("2 - Pinginaabrid");
                Console.WriteLine("3 - Remont (pindala)");
                Console.WriteLine("4 - Remondi hind");
                Console.WriteLine("5 - Temperatuur");
                Console.WriteLine("6 - Pikkuse analüüs");
                Console.WriteLine("7 - Pikkus ja sugu");
                Console.WriteLine("8 - Ostukorv");
                Console.WriteLine("0 - Välju");

                Console.Write("Vali: ");
                string valik = Console.ReadLine();

                switch (valik)
                {
                    case "1":
                        Console.Clear();
                        Funktsioonid.Juku("Juku");
                        break;

                    case "2":
                        Console.Clear();
                        Funktsioonid.pinginab();
                        break;

                    case "3":
                        Console.Clear();
                        Funktsioonid.remond();
                        break;

                    case "4":
                        Console.Clear();
                        Funktsioonid.remondihind();
                        break;

                    case "5":
                        Console.Clear();
                        Funktsioonid.temp();
                        break;

                    case "6":
                        Funktsioonid.pikkus();
                        break;

                    case "7":
                        Console.Clear();
                        Funktsioonid.piksu();
                        break;

                    case "8":
                        Console.Clear();
                        Funktsioonid.ostukorv();
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine("Head aega!");
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Vale valik!");
                        break;
                }
            }
        }
    }
}