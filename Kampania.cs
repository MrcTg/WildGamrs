using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hołod_the_Game
{
    class Kampania
    {
        public static string Nickname;
        public static string Difflvls;
        public static void _Nickname()
           
        {
            Nickname = Console.ReadLine();
        }

        public static void TworzeniePostaci()
        {
            AnimacjaTekstu.Write("Wybierz swój pseudonim:");
            _Nickname();
            Console.Clear();
            AnimacjaTekstu.Write("Witaj " + Nickname + ". Wybierz poziom trudności!");
            AnimacjaTekstu.Write("1> Łatwy");
            AnimacjaTekstu.Write("2> Średni");
            AnimacjaTekstu.Write("3> Trudny");
            AnimacjaTekstu.Write("------------------");
            AnimacjaTekstu.Write("4> Powrót do menu");

            ConsoleKeyInfo key = Console.ReadKey(); // * CONFIG * * CONFIG * * CONFIG * * CONFIG * * CONFIG *
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); Difflvls = "Łatwy"; Potwierdzenie(); break;
                case ConsoleKey.D2:
                    Console.Clear(); Difflvls = "Średni"; Potwierdzenie(); break;
                case ConsoleKey.D3:
                    Console.Clear(); Difflvls = "Trudny"; Potwierdzenie(); break;
                case ConsoleKey.D4:
                    Console.Clear(); MenuGłówne.StartMenuGłówne(); break;
                default: break;
            }
        }

        private static void Potwierdzenie()
        {
            AnimacjaTekstu.Write("[" + Difflvls + "]" + " Jesteś pewien? Nie będziesz mógł cofnąć wyboru");
            AnimacjaTekstu.Write("<ENTER> Jestem pewien! Rozpierdolmy tę grę!");
            AnimacjaTekstu.Write("<ESC> Wolę się zastanowić..");

            ConsoleKeyInfo key = Console.ReadKey(); // * CONFIG * * CONFIG * * CONFIG * * CONFIG * * CONFIG *
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear(); Rozdział1.Początek_Wszystkiego(); break;
                case ConsoleKey.Escape:
                    Console.Clear(); Kampania.Obraź1(); break;
                default: break;
            }
        }

        private static void Potwierdzenie1()
        {
            AnimacjaTekstu.Write("[" + Difflvls + "]" + " Jesteś pewien? Nie będziesz mógł cofnąć wyboru");
            AnimacjaTekstu.Write("<ENTER> Jestem pewien! Rozpierdolmy tę grę!");
            AnimacjaTekstu.Write("<ESC> Wolę się zastanowić..");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear(); Rozdział1.Początek_Wszystkiego(); break;
                case ConsoleKey.Escape:
                    Console.Clear(); Difflvl(); break;
                default: AnimacjaTekstu.WriteRed("We patrz co klikasz"); Difflvl(); break;
            }
        }

        public static void Obraź1()
        {
            Console.Title = "Hołod the Game";
            AnimacjaTekstu.Write("Hołod: " + Nickname +"! Ty cieńka pizdo!");
            Console.WriteLine("<Naciśnij dowolny klawisz>");
            Console.ReadKey();
            Console.Clear();
            AnimacjaTekstu.Write("<Nie daj sobą pomiatać!>");
            AnimacjaTekstu.Write("Pokaż kto tu rządzi! Wyślij wiązankę!");
            AnimacjaTekstu.WriteDYellow("<Nowa misja rozpoczęta!>");
            AnimacjaTekstu.Write("<Pierwsze wyzwania!> Zwyzywaj Hołoda!");
            AnimacjaTekstu.Write("<Zadanie opcjonalne> Zajeb mu bułę w realu! [100xp, respect+]");
            AnimacjaTekstu.WriteGreen("Teraz zwyzywaj naszego przyjaciela");
            string reObraź;
            reObraź = Console.ReadLine();
            Console.Clear();
            AnimacjaTekstu.Write(reObraź + "!");
            Console.WriteLine("<Naciśnij dowolny klawisz>");
            Console.ReadKey();
            Console.Clear();
            AnimacjaTekstu.Write("Pierdol się!");
            AnimacjaTekstu.Write("<Misja ukończona!>");
            AnimacjaTekstu.Write("Na co czekasz? Spierdalaj!");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear(); Difflvl(); break;
                case ConsoleKey.Enter:
                    Console.Clear(); Difflvl(); break;
                default: Difflvl(); break;
            }
        } 

        private static void Difflvl()
        {
            Console.Clear();
            Console.Title = "Poziom trudności";
            AnimacjaTekstu.Write("Wybierz poziom trudności");
            AnimacjaTekstu.Write("1> Łatwy");
            AnimacjaTekstu.Write("2> Średni");
            AnimacjaTekstu.Write("3> Trudny");
            AnimacjaTekstu.Write("------------------------------");
            AnimacjaTekstu.Write("<ESC> Powrót do menu głównego");


            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); Difflvls = "Łatwy"; Potwierdzenie1(); break;
                case ConsoleKey.D2:
                    Console.Clear(); Difflvls = "Średni"; Potwierdzenie1(); break;
                case ConsoleKey.D3:
                    Console.Clear(); Difflvls = "Trudny"; Potwierdzenie1(); break;
                default: break;
            }
        }
            

        
    }
}

 
    



