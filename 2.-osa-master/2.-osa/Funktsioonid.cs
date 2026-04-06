using System;

namespace _2._osa
{
    internal class Funktsioonid
    {
        // Kinopilet Jukule
        public static void Juku(string nimi)
        {
            string otsus = "";
            string pilet = "";
            int vanus = 0;

            if (nimi.ToLower() == "juku")
            {
                Console.Write("Kui vana Juku on?: ");

                if (int.TryParse(Console.ReadLine(), out vanus))
                {
                    if (vanus > 0 && vanus < 100)
                    {
                        if (vanus < 6)
                            pilet = "Pilet on tasuta!";
                        else if (vanus < 14)
                            pilet = "Teil on vaja lapsepiletit.";
                        else if (vanus < 65)
                            pilet = "Teil on vaja täiskasvanu piletit.";
                        else
                            pilet = "Teil on vaja soodushinnaga piletit.";

                        otsus = "Lähme kinos Jukuga!";
                        Console.WriteLine($"{otsus}, Juku on {vanus} aastat vana, {pilet}");
                    }
                    else
                    {
                        Console.WriteLine("Vanus peab olema 1–99!");
                    }
                }
                else
                {
                    Console.WriteLine("Vigane sisend!");
                }
            }
            else
            {
                Console.WriteLine("Ei lähe kinno");
            }
        }

        // Pinginaabrid
        public static void pinginab()
        {
            Console.Write("Sisesta esimese inimese nimi: ");
            string nimi1 = Console.ReadLine();

            Console.Write("Sisesta teise inimese nimi: ");
            string nimi2 = Console.ReadLine();

            Console.WriteLine($"Täna on pinginaabrid {nimi1} ja {nimi2}.");
        }

        // Remont (pindala)
        public static void remond()
        {
            Console.Write("Sisesta pikkus1: ");
            int p1 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta pikkus2: ");
            int p2 = int.Parse(Console.ReadLine());

            int porand = p1 * p2;
            Console.WriteLine($"Pindala: {porand}");
        }

        // Remondi hind
        public static void remondihind()
        {
            Console.Write("Sisesta pindala: ");
            int pind = int.Parse(Console.ReadLine());

            int hind = pind * 15;
            Console.WriteLine($"Hind: {hind} eurot");
        }

        // Temperatuur
        public static void temp()
        {
            Console.Write("Sisesta temperatuur: ");
            int t = int.Parse(Console.ReadLine());

            if (t >= 18)
                Console.WriteLine("Temperatuur on vähemalt 18 kraadi");
            else
                Console.WriteLine("Temperatuur on alla 18 kraadi");
        }

        // Pikkuse analüüs
        public static void pikkus()
        {
            Console.Write("Sisesta pikkus: ");
            int pikk = int.Parse(Console.ReadLine());

            if (pikk <= 140)
                Console.WriteLine("Sa oled lühike");
            else if (pikk <= 185)
                Console.WriteLine("Sa oled keskmine");
            else
                Console.WriteLine("Sa oled pikk");
        }

        // Pikkus ja sugu
        public static void piksu()
        {
            Console.Write("Sisesta sugu (mees/naine): ");
            string sugu = Console.ReadLine().ToLower();

            Console.Write("Sisesta pikkus: ");
            if (!int.TryParse(Console.ReadLine(), out int pikkus))
            {
                Console.WriteLine("Vigane sisend!");
                return;
            }

            if (sugu == "mees")
            {
                if (pikkus < 140)
                    Console.WriteLine("Sa oled lühike mees");
                else if (pikkus <= 185)
                    Console.WriteLine("Sa oled keskmine mees");
                else
                    Console.WriteLine("Sa oled pikk mees");
            }
            else if (sugu == "naine")
            {
                if (pikkus <= 130)
                    Console.WriteLine("Sa oled lühike naine");
                else if (pikkus <= 170)
                    Console.WriteLine("Sa oled keskmine naine");
                else
                    Console.WriteLine("Sa oled pikk naine");
            }
            else
            {
                Console.WriteLine("Tundmatu sugu");
            }
        }

        // Ostukorv
        public static void ostukorv()
        {
            double summa = 0;

            double piimHind = 1.20;
            double saiHind = 0.80;
            double leibHind = 1.50;

            Console.Write("Kas soovid piima? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += piimHind;

            Console.Write("Kas soovid saia? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += saiHind;

            Console.Write("Kas soovid leiba? (jah/ei): ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += leibHind;

            Console.WriteLine($"Ostukorvi kogumaksumus on: {summa:F2} eurot");
        }
    }
}