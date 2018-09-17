using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hołod_the_Game
{
    static class MenuGłówne
    {
        public static void StartMenuGłówne()
        {
            Console.Title = "Menu główne";
            while (true)
            {
                Console.Clear();
                AnimacjaTekstu.Write(">>> Hołod the Game <<<");
                Console.WriteLine("");
                AnimacjaTekstu.Write("1> Rozpocznij grę");
                AnimacjaTekstu.Write("2> Wczytaj grę");
                AnimacjaTekstu.Write("3> Ustawienia");
                AnimacjaTekstu.Write("--------------");
                AnimacjaTekstu.Write("ESC> Zakończ");
                ConsoleKeyInfo key = Console.ReadKey(); // * CONFIG * * CONFIG * * CONFIG * * CONFIG * * CONFIG *
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.Clear(); Rozpocznij_grę(); break;
                    case ConsoleKey.D2:
                        Console.Clear(); Wczytaj_grę(); break;
                    case ConsoleKey.D3:
                        Console.Clear(); Ustawienia(); break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0); break;
                    default: break;
                }

            }
        }

        public static void Rozpocznij_grę()
        {
            Console.Title = "Rozpocznij grę";
            AnimacjaTekstu.Write("Wybierz tryb:");
            AnimacjaTekstu.Write("1> Kampania");
            AnimacjaTekstu.Write("2> Zagłada [ PROJEKT DOPRACOWYWANY ]");
            AnimacjaTekstu.Write("-----------");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey(); // * CONFIG * * CONFIG * * CONFIG * * CONFIG * * CONFIG *
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); Kampania.TworzeniePostaci(); break;
                case ConsoleKey.D2:
                    Console.Clear(); Zagłada.Zagłada1(); break; //Dodać tryb
                case ConsoleKey.Escape:
                    Console.Clear(); StartMenuGłówne(); break;
                default:
                    AnimacjaTekstu.WriteRed("We mordo patrz co klikasz");
                    Thread.Sleep(100);
                    Console.Clear();
                    Rozpocznij_grę();
                    break;
            }
        }

        static void Wczytaj_grę()
        {
            Console.Title = "Wczytaj grę";
            AnimacjaTekstu.Write("Wczytaj grę"); //cholera wie jak, ale dodać zapis gry
            AnimacjaTekstu.Write("Ostatni zapis");
            AnimacjaTekstu.Write("--------------");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear(); StartMenuGłówne(); break;
                default:
                    AnimacjaTekstu.WriteRed("We mordo patrz co klikasz");
                    Thread.Sleep(100);
                    Console.Clear();
                    Wczytaj_grę();
                    break;
            }
        }

        static void Ustawienia()
        {
            Console.Title = "Ustawienia";
            AnimacjaTekstu.Write("Ustawienia:");
            AnimacjaTekstu.Write("1> Grafika");
            AnimacjaTekstu.Write("2> Dźwięk");
            AnimacjaTekstu.Write("3> Dodatki");
            AnimacjaTekstu.Write("-----------");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); Grafika(); break;
                case ConsoleKey.D2:
                    Console.Clear(); Dźwięk(); break;
                case ConsoleKey.D3:
                    Console.Clear(); Dodatki(); break;
                case ConsoleKey.Escape:
                    Console.Clear(); StartMenuGłówne(); break;
                default:
                    AnimacjaTekstu.WriteRed("We mordo patrz co klikasz");
                    Thread.Sleep(100);
                    Console.Clear();
                    Ustawienia();
                    break;
            }
        }
        public static string kolortła = "Czarny";
        public static string kolorczcionki = "Biały";
        private static void Grafika()
        {
            AnimacjaTekstu.Write("1> Zmień kolor tła");
            AnimacjaTekstu.Write("Kolor tła: " + kolortła);
            Console.WriteLine("");
            AnimacjaTekstu.Write("2> Zmień kolor czcionki");
            AnimacjaTekstu.Write("Kolor czcionki: " + kolorczcionki);
            Console.WriteLine("");
            AnimacjaTekstu.Write("3> Przywróć domyślne");
            AnimacjaTekstu.Write("------------------------");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); TłoKolory(); break;
                case ConsoleKey.D2:
                    Console.Clear(); CzcionkaKolory(); break;
                case ConsoleKey.D3:
                    Console.Clear(); GrafikaPrzywróć(); break;
                case ConsoleKey.Escape:
                    Console.Clear(); Ustawienia(); break;
                default:
                    AnimacjaTekstu.WriteRed("We mordo patrz co klikasz");
                    Thread.Sleep(100);
                    Console.Clear();
                    Grafika();
                    break;
            }
        }
        private static void GrafikaPrzywróć()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            kolortła = ("Czarny");
            Console.ForegroundColor = ConsoleColor.White;
            kolorczcionki = ("Biały");
            Grafika();

        }
        private static void TłoKolory()
        {
            AnimacjaTekstu.Write("Wybierz kolor tła!");
            Console.WriteLine("1> Czarny");
            Console.WriteLine("2> Niebieski");
            Console.WriteLine("3> Cyjan");
            Console.WriteLine("4> CiemnyNiebieski");
            Console.WriteLine("5> CiemnoCyjanowy");
            Console.WriteLine("6> CiemnoZielony");
            Console.WriteLine("7> CiemnoFuksjowy");
            Console.WriteLine("8> CiemnoCzerwony");
            Console.WriteLine("9> CiemnoŻółty");
            Console.WriteLine("0> Szary");
            Console.WriteLine("Q> Fuksja");
            Console.WriteLine("W> Czerwony");
            Console.WriteLine("E> Biały");
            Console.WriteLine("R> Żółty");
            AnimacjaTekstu.Write("-------------");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); Czarny(); break;
                case ConsoleKey.D2:
                    Console.Clear(); Niebieski(); break;
                case ConsoleKey.D3:
                    Console.Clear(); Cyjan(); break;
                case ConsoleKey.D4:
                    Console.Clear(); CiemnoNiebieski(); break;
                case ConsoleKey.D5:
                    Console.Clear(); CiemnoCynjanowy(); break;
                case ConsoleKey.D6:
                    Console.Clear(); CiemnoZielony(); break;
                case ConsoleKey.D7:
                    Console.Clear(); CiemnoFuksjowy(); break;
                case ConsoleKey.D8:
                    Console.Clear(); CiemnoCzerwony(); break;
                case ConsoleKey.D9:
                    Console.Clear(); CiemnoŻółty(); break;
                case ConsoleKey.D0:
                    Console.Clear(); Szary(); break;
                case ConsoleKey.Q:
                    Console.Clear(); Fuksja(); break;
                case ConsoleKey.W:
                    Console.Clear(); Czerwony(); break;
                case ConsoleKey.E:
                    Console.Clear(); Biały(); break;
                case ConsoleKey.R:
                    Console.Clear(); Żółty(); break;
                case ConsoleKey.Escape:
                    Console.Clear(); Grafika(); break;
                default:
                    AnimacjaTekstu.WriteRed("We mordo patrz co klikasz");
                    Thread.Sleep(100);
                    Console.Clear();
                    TłoKolory();
                    break;
            }
            
        }

            static void Czarny()
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                kolortła = ("Czarny");
                TłoKolory();
                
            }
            static void Niebieski()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                kolortła = ("Niebieski");
                TłoKolory();
                
            }
            private static void Cyjan()
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                kolortła = ("Cyjanowy");
                TłoKolory();
            }
            private static void CiemnoNiebieski()
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                kolortła = ("CiemnoNiebieski");
                TłoKolory();
            }
            private static void CiemnoCynjanowy()
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                kolortła = ("CiemnoCyjanowy");
                TłoKolory();
            }
            private static void CiemnoZielony()
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                kolortła = ("CiemnoZielony");
                TłoKolory();
            }
            private static void CiemnoFuksjowy()
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                kolortła = ("CiemnoFuksjowy");
                TłoKolory();
            }
            private static void CiemnoCzerwony()
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                kolortła = ("CiemnoCzerwony");
                TłoKolory();
            }
            private static void CiemnoŻółty()
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                kolortła = ("CiemnoŻółty");
                TłoKolory();
            }
            private static void Szary()
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Clear();
                kolortła = ("Szary");
                TłoKolory();
            }
            private static void Fuksja()
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.Clear();
                kolortła = ("Fuksjowy");
                TłoKolory();
            }
            private static void Czerwony()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                kolortła = ("Czerowny");
                TłoKolory();
            }
            private static void Biały()
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                kolortła = ("Biały");
                TłoKolory();
                }
            private static void Żółty()
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                kolortła = ("Żółty");
                TłoKolory();
            }

        private static void CzcionkaKolory()
        {
            AnimacjaTekstu.Write("Wybierz kolor czcionki!");
            Console.WriteLine("1> Czarny");
            Console.WriteLine("2> Niebieski");
            Console.WriteLine("3> Cyjan");
            Console.WriteLine("4> CiemnyNiebieski");
            Console.WriteLine("5> CiemnoCyjanowy");
            Console.WriteLine("6> CiemnoZielony");
            Console.WriteLine("7> CiemnoFuksjowy");
            Console.WriteLine("8> CiemnoCzerwony");
            Console.WriteLine("9> CiemnoŻółty");
            Console.WriteLine("0> Szary");
            Console.WriteLine("Q> Fuksja");
            Console.WriteLine("W> Czerwony");
            Console.WriteLine("E> Biały");
            Console.WriteLine("R> Żółty");
            AnimacjaTekstu.Write("-------------");
            AnimacjaTekstu.Write("<ESC> Powrót");

            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear(); Czarny1(); break;
                case ConsoleKey.D2:
                    Console.Clear(); Niebieski1(); break;
                case ConsoleKey.D3:
                    Console.Clear(); Cyjan1(); break;
                case ConsoleKey.D4:
                    Console.Clear(); CiemnyNiebieski1(); break;
                case ConsoleKey.D5:
                    Console.Clear(); CiemnoCynjanowy1(); break;
                case ConsoleKey.D6:
                    Console.Clear(); CiemnoZielony1(); break;
                case ConsoleKey.D7:
                    Console.Clear(); CiemnoFuksjowy1(); break;
                case ConsoleKey.D8:
                    Console.Clear(); CiemnoCzerwony1(); break;
                case ConsoleKey.D9:
                    Console.Clear(); CiemnoŻółty1(); break;
                case ConsoleKey.D0:
                    Console.Clear(); Szary1(); break;
                case ConsoleKey.Q:
                    Console.Clear(); Fuksja1(); break;
                case ConsoleKey.W:
                    Console.Clear(); Czerwony1(); break;
                case ConsoleKey.E:
                    Console.Clear(); Biały1(); break;
                case ConsoleKey.R:
                    Console.Clear(); Żółty1(); break;
                case ConsoleKey.Escape:
                    Console.Clear(); Grafika(); break;
                default:
                    AnimacjaTekstu.WriteRed("We mordo patrz co klikasz");
                    Thread.Sleep(100);
                    Console.Clear();
                    CzcionkaKolory();
                    break;
            }
        }

        private static void Czarny1()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            kolorczcionki = ("Czarny");           
            CzcionkaKolory();
        }
        private static void Niebieski1()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            kolorczcionki = ("Niebieski");
            CzcionkaKolory();
        }
        private static void Cyjan1()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            kolorczcionki = ("Cyjanowy");
            CzcionkaKolory();
        }
        private static void CiemnyNiebieski1()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            kolorczcionki = ("CiemnoNiebieski");
            CzcionkaKolory();
        }
        private static void CiemnoCynjanowy1()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            kolorczcionki = ("CiemnoCyjanowy");
            CzcionkaKolory();
        }
        private static void CiemnoZielony1()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            kolorczcionki = ("CiemnoZielony");
            CzcionkaKolory();
        }
        private static void CiemnoFuksjowy1()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            kolorczcionki = ("CiemnoFuksjowy");
            CzcionkaKolory();
        }
        private static void CiemnoCzerwony1()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            kolorczcionki = ("CiemnoCzerwony");
            CzcionkaKolory();
        }
        private static void CiemnoŻółty1()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            kolorczcionki = ("CiemnoŻółty");
            CzcionkaKolory();
        }
        private static void Szary1()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();
            kolorczcionki = ("Szary");
            CzcionkaKolory();
        }
        private static void Fuksja1()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            kolorczcionki = ("Fuksjowy");
            CzcionkaKolory();
        }
        private static void Czerwony1()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            kolorczcionki = ("Czerwony");
            CzcionkaKolory();
        }
        private static void Biały1()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            kolorczcionki = ("Biały");
            CzcionkaKolory();
        }
        private static void Żółty1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            kolorczcionki = ("Żółty");
            CzcionkaKolory();
        }

        private static void Dźwięk()
        {
            AnimacjaTekstu.Write("Efekty dźwiękowe:" ); //on/off %%
            AnimacjaTekstu.Write("Muzyka: ");
            AnimacjaTekstu.WriteGreen("Wciąż pracuję nad AUDIO");
            Console.ReadKey();
            Console.Clear();
            Ustawienia();
        }

        private static void Dodatki()
        {
            AnimacjaTekstu.Write("Dorzucę tu jakieś obelgi dotyczące Hołoda");
            AnimacjaTekstu.Write("1> Hołod korzysta z Windowsa: OFF"); //on/off
            AnimacjaTekstu.Write("2> Jebanie Hołoda: Always ON"); //on/off
            AnimacjaTekstu.WriteGreen("Wciąż nad tym pracuję");
            Console.ReadKey();
            Console.Clear();
            Ustawienia();
        }
    }
}     


// miejsce na pomysły!
//Dźwięk oznajmiający rozpoczęcie i ukończenie misji
//Dźwięk wypisywania liter
//Dźwięk piorunów 
//klasy postaci
//system walk, lvl, umiejętności, statystyk
