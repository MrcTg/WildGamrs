using Hołod_the_Game;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hołod_the_Game
{
    class Mechaniki
    {
        public static string komendy;
        public static void Komendy() // komendy 
            
        {
            komendy = Console.ReadLine().ToUpper();
            if (komendy == "/STATY")
            {
                Postać.Statystyki();
            }
            if (komendy == "/CLEAR")
            {
                Console.Clear(); // uwzględnić ponowne odtworzenie ostatniej metody
            }
            if (komendy == "/KOMENDY")
            {
                Console.Write("/ komendy; staty; clear; "); //uzupełniać nowe komendy
            }
            if (komendy == "/STATYP")
            {
                Potwory.Statystyki_Potworów();
            }
            if (komendy == "")
            {

            }

        }
    }
    class Informacje
    {
        public static void Hołod()
        {
            AnimacjaTekstu.WriteMagneta("Hołod:");
            AnimacjaTekstu.Write("Po prostu Hołod, wybierając tę klasę otrzymujesz:");
            AnimacjaTekstu.Write(">-4pkt Siły");
            AnimacjaTekstu.Write(">-5pkt Zręczności");
            AnimacjaTekstu.Write(">-4pkt Inteligencji"); // co do tej statystyki to ja bym się zastanowił #Matma_1.70
            AnimacjaTekstu.Write("> 9pkt Witalności");
            AnimacjaTekstu.Write("Dodatkowe bonusy:");
            AnimacjaTekstu.Write("Umiejętność lizania dupska na mistrzowskim poziomie");
            Console.WriteLine();
        }
        public static void Programista()
        {
            AnimacjaTekstu.WriteMagneta("Programista:");
            AnimacjaTekstu.Write("Braki w siłach i witalności rekompensuje w zręczności i inteligencji");
            AnimacjaTekstu.Write(">-4pkt Siły");
            AnimacjaTekstu.Write("> 3pkt Zręczności");
            AnimacjaTekstu.Write("> 6pkt Inteligencji");
            AnimacjaTekstu.Write(">-3pkt Witalności");
            AnimacjaTekstu.Write("Dodatkowe bonusy:");
            Console.WriteLine();
        }
        public static void PCtowiec()
        {
            AnimacjaTekstu.WriteMagneta("PCtowiec:");
            AnimacjaTekstu.Write("Inteligentny, silny i witalny, obciążony sprzętami, ma bardzo niską zręczność");
            AnimacjaTekstu.Write("> 2pkt Siły");
            AnimacjaTekstu.Write(">-10pkt Zręczności");
            AnimacjaTekstu.Write("> 3pkt Inteligencji");
            AnimacjaTekstu.Write("> 3pkt Witalności");
            AnimacjaTekstu.Write("Dodatkowe bonusy:");
            Console.WriteLine();
        }
        public static void WojownikCienia()
        {
            AnimacjaTekstu.WriteMagneta("WojownikCienia:");
            AnimacjaTekstu.Write("Typowy barbarzyńca, jedyne co uznaje to siła własnych mięśni");
            AnimacjaTekstu.Write("> 6pkt Siły");
            AnimacjaTekstu.Write("> 5pkt Zręczności");
            AnimacjaTekstu.Write(">-10pkt Inteligencji");
            AnimacjaTekstu.Write("> 4pkt Witalności");
            AnimacjaTekstu.Write("Dodatkowe bonusy:");
            Console.WriteLine();
            Postać.Klasy();
        }
    }
    class AnimacjaTekstu
    {
        public static void Write(string line)
        {
            Random rnd = new Random();
            bool skip = false;

            foreach (var character in line)
            {
                Console.Write(character);


                if (!skip)
                    Thread.Sleep(rnd.Next(20, 35));

                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    skip = true;
                }
            }
            Console.WriteLine();
        }

        public static void WriteRed(string line) //czerwony - Cele
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Random rnd = new Random();
            bool skip = false;

            foreach (var character in line)
            {
                Console.Write(character);


                if (!skip)
                    Thread.Sleep(rnd.Next(20, 35));

                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    skip = true;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteGreen(string line) //zielony - wskazówki
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Random rnd = new Random();
            bool skip = false;

            foreach (var character in line)
            {
                Console.Write(character);


                if (!skip)
                    Thread.Sleep(rnd.Next(20, 35));

                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    skip = true;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void WriteMagneta(string line) //Magneta - dostępne lokalizacje dla gracza
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Random rnd = new Random();
            bool skip = false;

            foreach (var character in line)
            {
                Console.Write(character);


                if (!skip)
                    Thread.Sleep(rnd.Next(20, 35));

                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    skip = true;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteDYellow(string line) //Ciemny żółty - statystytki 
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Random rnd = new Random();
            bool skip = false;

            foreach (var character in line)
            {
                Console.Write(character);


                if (!skip)
                    Thread.Sleep(rnd.Next(20, 35));

                if (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                    skip = true;
                }
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
public class Potwory
{
    //Statystyki startowe
    public static int życie_p = 300;
    public static int siła_p = 100;
    public static int zręczność_p = 125;
    public static int inteligencja_p = 90;
    //Statystyki końcowe
    public static int witalność_P = życie_p * 2;
    public static int Wartość_Atk_P = siła_p * 2;
    public static int Szansa_na_Unik_P = zręczność_p / 2;
    public static int Obr_Mag_P = inteligencja_p * 3;
    public static void Statystyki_Potworów()
    {

        if (Kampania.Difflvls == "Łatwy")
        {
            życie_p = (życie_p * 1) * (Postać.Lvl / 2);
            siła_p = (siła_p * 1) * (Postać.Lvl / 2);
            zręczność_p = (zręczność_p * 1) * (Postać.Lvl / 2);
            inteligencja_p = (inteligencja_p * 1) * (Postać.Lvl / 2);
        }
        if (Kampania.Difflvls == "Średni")
        {
            życie_p = (życie_p * 2) * (Postać.Lvl * 2);
            siła_p = (siła_p * 2) * (Postać.Lvl * 2);
            zręczność_p = (zręczność_p * 2) * (Postać.Lvl * 2);
            inteligencja_p = (inteligencja_p * 2) * (Postać.Lvl * 2);
        }
        if (Kampania.Difflvls == "Trudny")
        {
            życie_p = (życie_p * 3) * (Postać.Lvl * 3);
            siła_p = (siła_p * 3) * (Postać.Lvl * 3);
            zręczność_p = (zręczność_p * 3) * (Postać.Lvl * 3);
            inteligencja_p = (inteligencja_p * 3) * (Postać.Lvl * 3);
        }
        AnimacjaTekstu.Write("Jeżeli to działa to są statyki potworów:");
        AnimacjaTekstu.WriteDYellow("Życie: " + witalność_P);
        AnimacjaTekstu.WriteDYellow("Atak: " + Wartość_Atk_P);
        AnimacjaTekstu.WriteDYellow("Unik: " + Szansa_na_Unik_P);
        AnimacjaTekstu.WriteDYellow("Obr. Magiczne: " + Obr_Mag_P);
        Console.ReadKey();

    }

    public class Przeciwnik
    {
        public static int W;
        public static int A;
        public static int M;
        public static int U; 
        public Przeciwnik()
        {
            W = witalność_P;
            A = Wartość_Atk_P;
            M = Obr_Mag_P;
            U = Szansa_na_Unik_P;
        }
        Przeciwnik mob = new Przeciwnik();
        public void teścik()
        {
            AnimacjaTekstu.Write("Działa?");
            Console.ReadKey();
        }
    }
}
        
    

    


