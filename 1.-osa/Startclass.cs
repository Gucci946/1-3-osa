using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace _1._osa
{
    internal class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere, kirjuta oma nimi palun.");
            string nimi = Console.ReadLine();
            Console.WriteLine($"Tere, {nimi}, kirjuta kaks arvu ja ma korrutan need.");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} ja {1} korrutis on {2}", a, b, a * b);
        }
    }
}

