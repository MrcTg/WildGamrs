using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Hołod_the_Game
{
    class Pioruny
    {
        public static void Nakurwianie()    
        {
            Console.Title = "Początek wszystkiego";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Black;
            AnimacjaTekstu.Write("*ŁUBUDUBU JEB JEB*");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("JEB");
            Thread.Sleep(200);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("PIZG PIZG");
            Thread.Sleep(200);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("JEB");
            Thread.Sleep(200);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("PIZG");
            Thread.Sleep(200);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("JEB");
            Thread.Sleep(200);
            Console.Clear();
        }
    }

    class Rozdział1
    {
        //strings
        public static string move;
        //ints
        public static int prawda = 0;
        public static void Początek_Wszystkiego()
        {
            AnimacjaTekstu.Write("*60 lat temu, komuna, piwnica w bloku Hołoda*");
            AnimacjaTekstu.Write("Hołod: Spędziłem cały dzień w piwnicy przy nowym magnetofonie.. Która to.. ");
            Thread.Sleep(2500);
            Pioruny.Nakurwianie();
            AnimacjaTekstu.Write("-Ale nakurwia piorunami!");
            AnimacjaTekstu.Write("Muszę szybko odłączyć Mac`a, jeszcze się spali! Powinien być w moim pokoju.");
            AnimacjaTekstu.Write("<Nowa misja rozpoczęta!>");
            AnimacjaTekstu.Write("<Ten pierdolony kabel!> Odłącz Mac`a od prądu!");
            AnimacjaTekstu.WriteGreen("<Aby się poruszać wystarczy wpisać nazwę pomieszczenia do którego chcesz się udać!>");
            AnimacjaTekstu.Write("Dostępne pomieszczenia:");
            AnimacjaTekstu.WriteMagneta("Parter; Piętro1; Piętro2; Piętro3; Piętro4");
            Poruszanie1();
        }
        private static void Poruszanie1()
        {
            do
            {
                move = Console.ReadLine().ToUpper();
                if (move == "PIWNICA")
                {
                    LokPiwnica();
                    prawda = 1;
                }
                if (move == "PARTER")
                {
                    LokParter();
                }
                if (move == "PIĘTRO1")
                {
                    LokPiętro1();
                }
                if (move == "PIĘTRO2")
                {
                    LokPiętro2();
                }
                if (move == "PIĘTRO3")
                {
                    LokPiętro3();
                }
                if (move == "PIĘTRO4")
                {
                    LokPiętro4();
                }
                if (move == "MIESZKANIEHOŁODA")
                {
                    LokMieszkanieHołoda();
                }
                if (move == "DACH")
                {
                    LokDach();
                }
                else { AnimacjaTekstu.WriteRed("Problemy z pisaniem/czytaniem?"); }
            } while (prawda == 0);
            prawda = 0;
        }
        public static void LokPiwnica()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Hołod: Piwnica jak piwnica, ciasno i piździ, wszędzie pełno pajęczyn, mam tu swój składzik ze sprzętami.");
            AnimacjaTekstu.Write("Dostępne pomieszczenia:");
            AnimacjaTekstu.WriteMagneta("Parter, Piętro1, Piętro2, Piętro3, Piętro4");
            Poruszanie1();
        }
        public static void LokParter()
        { 
            Console.Clear();
            AnimacjaTekstu.Write("Wchodzisz na parter, nie ma tu nic poza wyjściem z bloku i wejściem do piwnicy, słyszysz kolejne grzmoty.");
            AnimacjaTekstu.Write("Dostępne pomieszczenia:");
            AnimacjaTekstu.WriteMagneta("Piwnica, Piętro1, Piętro2, Piętro3, Piętro4");
            Poruszanie1();

        }
        public static void LokPiętro1()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Hołod: Piętro pierwsze.. Pies pani Gosi znowu nasrał na wycieraczkę sąsiadów.. Ktoś powinien zrobić z tym porządek.");
            AnimacjaTekstu.Write("Znowu pioruny..");
            AnimacjaTekstu.Write("Dostępne pomieszczenia: ");
            AnimacjaTekstu.WriteMagneta("Piwnica, Parter, Piętro2, Piętro3, Piętro4");
            Poruszanie1();
        }
        public static void LokPiętro2()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Hołod: Ach, piętro drugie, po ostatniej łapance mało kto tu mieszka");
            AnimacjaTekstu.Write("Ciekawe, czy mieszkania zostały nienaruszone");
            AnimacjaTekstu.Write("*JEB*");
            AnimacjaTekstu.Write("Jak tak dalej pójdzie to pożegnam się z Mac`iem");
            AnimacjaTekstu.Write("Dostępne pomieszczenia:");
            AnimacjaTekstu.WriteMagneta("Piwnica, Parter, Piętro1, Piętro3, Piętro4");
            Poruszanie1();
        }
        public static void LokPiętro3()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Piętro trzecie, tutaj mieszkam.. Dziwne..");
            Thread.Sleep(700);
            AnimacjaTekstu.Write("Drzwi wydają się być luźne.. Słyszałem jakieś krzyki ale..");
            Thread.Sleep(700);
            AnimacjaTekstu.Write("*Pizg*");
            AnimacjaTekstu.Write("Mam nadzieję że nic się nie stało");
            AnimacjaTekstu.Write("Dostępne pomieszczenia:");
            AnimacjaTekstu.WriteMagneta("Piwnica, Parter, Piętro1, Piętro2, Piętro4, MieszkanieHołoda");
            Poruszanie1();
        }
        public static void LokPiętro4()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Hołod: Japierdole, czwarte piętro! Tlenu.. Nigdy więcej.. Cardio życia..");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.WriteLine("");
            AnimacjaTekstu.Write("Lepiej..");
            AnimacjaTekstu.Write("Nie ma tu nic poza wejściem na dach, które jest zawsze zamknięte.");
            AnimacjaTekstu.Write("Dostępne lokacje:");
            AnimacjaTekstu.WriteMagneta("Piwnica, Parter, Piętro1, Piętro2, Piętro3");
            Poruszanie1();
        }
        public static void LokMieszkanieHołoda()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Hołod: Co tu się..");
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.Write(".");
            Thread.Sleep(300);
            Console.WriteLine("");
            AnimacjaTekstu.Write("Mamo?! MAMO!");
            AnimacjaTekstu.Write("Pełno krwi.. ");
            AnimacjaTekstu.Write("Mama: Krys..");
            AnimacjaTekstu.Write("Hołod: MAMO! Biegnę!");
            AnimacjaTekstu.Write("Mama: Uciekaj.. Wrócą po ciebie.. Trzymaj klucz.");
            AnimacjaTekstu.Write("Na dachu jest małe pomieszczenie w ktorym możesz się schować, znajdziesz tam też coś do obrony");
            AnimacjaTekstu.Write("BLYAT, RASZU NA CHUI GOŁ GOŁ GOŁ");
            AnimacjaTekstu.Write("Już tu idą, uciekaj, bie..gnij!");
            AnimacjaTekstu.Write("Hołod: Kurwa. Dla mamy już za późno.. Zarżnę każde ruskie ścierwo które stanie mi na drodze..");
            AnimacjaTekstu.Write("Na dachu powinna być jakaś broń.");
            AnimacjaTekstu.Write("Dostępne lokacje:");
            AnimacjaTekstu.WriteMagneta("Piwnica, Parter, Piętro1, Piętro2, Piętro3, Piętro4, Dach");
            Poruszanie1();
        }
        public static void LokDach()
        {
            Console.Clear();
            AnimacjaTekstu.Write("Hołod: Leje jak pojebane, w dodatku pizga piorunami");
            AnimacjaTekstu.Write("*Rozglądając się zauważasz małe pomieszczenenie*");
            AnimacjaTekstu.Write("To chyba o tym wspominała mama, wejdę do środka.");
            AnimacjaTekstu.Write("Prawdopodobnie są w nim wszystkie rzeczy związane z elektryką w tym bloku");
            AnimacjaTekstu.Write("*Otwierasz drzwi*");
            AnimacjaTekstu.Write("Jasna cholera, co tu robi kałach?!");
            AnimacjaTekstu.WriteGreen("Wciśnij dowolny klawisz by podnieść broń");
            Console.ReadKey();
            AnimacjaTekstu.Write("*PIZG*");
            AnimacjaTekstu.Write("*Ze strachu przewracasz się na otwarą słabo zabezpieczoną skrzynkę pod napięciem*");
            AnimacjaTekstu.Write("O.. Kurwa..");
            Thread.Sleep(2500);
            AnimacjaTekstu.Write("*JEB*");
            Pioruny.Nakurwianie();
            Rozdział2();
        }
        public static void Rozdział2()
        {
            Console.Title = "Rozdział2";
            AnimacjaTekstu.Write("Uhh..");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.WriteLine();
            AnimacjaTekstu.Write("Hołod: Gdzie ja kurna..");
            AnimacjaTekstu.Write("Japieprze.. Moja głowa");
            AnimacjaTekstu.WriteGreen("Witaj");
            AnimacjaTekstu.Write("KI CHUJ?!");
            AnimacjaTekstu.WriteGreen("Jestem Twoim przewodnikiem.");
            AnimacjaTekstu.Write("No to nieźle mnie popieściło..");
            AnimacjaTekstu.WriteGreen("Dotykając skrzynki zsynchronizowałeś się z piorunem, który przeciążył sieć.");
            AnimacjaTekstu.WriteGreen("Na dobrą sprawę jesteś martwy, ale jakimś cudem świadomie istniejesz..");
            AnimacjaTekstu.Write("Czy to czasem sobie nie zaprzecza? Chwila.. Ten świat.. Ja go poznaję..");
            AnimacjaTekstu.WriteGreen("Tak. Masz rację. Oto i..");
            AnimacjaTekstu.WriteRed("Hołod the Game");
            AnimacjaTekstu.Write("No dobra, ale w HtG był wybór klasy i rasy, tutaj je..");
            AnimacjaTekstu.WriteGreen("Utkaj łeb. Proszę, oto menu tworzenia postaci");
            AnimacjaTekstu.WriteGreen("*Jak ten dzban mnie wkurwia*");
            AnimacjaTekstu.Write("Wciśnij dowolny klawisz by kontynuować");
            Console.ReadKey();
            Console.Clear();
            Postać.Rasy();
        }
        public static void Demo()
        {
            Console.Clear();
            AnimacjaTekstu.Write("No, jak narazie to tyle <3");
            AnimacjaTekstu.Write("Koniec dema, wkrótce pierwsze walki i system ekwipnuku");
            AnimacjaTekstu.WriteGreen("Aby sprawdzić swoje statystyki wpisz /staty");
            AnimacjaTekstu.Write("Update 1.01");
            Mechaniki.Komendy();
            
        }
    }
    class Postać
    {
        //ints
        public static float BrJednR;
    public static float BrDwuR;
    public static float Łuk;
    public static float ArtMag;
    public static int Witalność;
    public static int Siła;
    public static int Inteligencja;
    public static int Zręczność;
    public static int Exp_Potrzebny;
    public static int Exp_Wymagany;
    public static int Lvl;
    //strings
    public static string klasa;
    public static string rasa;

    public static void Rasy()
    {
        //klasy WojownikCienia, Hołod, Programista, PCtowiec,
        int prawda = 0;

        AnimacjaTekstu.WriteGreen("Wybierz swoją rasę");
        AnimacjaTekstu.Write(">Człowiek");
        AnimacjaTekstu.Write(">Elf Leśny");
        AnimacjaTekstu.Write(">Ork");
        AnimacjaTekstu.Write(">Wysoki Elf");
        AnimacjaTekstu.WriteGreen("Informacje dotyczące ras otrzymasz wpisując /rasy");
        do
        {
            rasa = Console.ReadLine().ToUpper();

            if (rasa == "/RASY")
            {
                Console.WriteLine("");
                AnimacjaTekstu.WriteMagneta("Człowiek:");
                AnimacjaTekstu.Write("Ani krzty w nim magii (nie korzysta z magii)");
                AnimacjaTekstu.Write("Ogarnia łuk (+50% dmg z łuku)");
                AnimacjaTekstu.Write("Dobrze macha mieczem (+100% dmg z jednoręki)");
                AnimacjaTekstu.Write("Technika korzystania z broni dwuręcznej na poziomie casuala (brak bonusów)");
                Console.WriteLine();
                AnimacjaTekstu.WriteMagneta("Elf:");
                AnimacjaTekstu.Write("Ogarnia czarowanie (+50% mag. dmg)");
                AnimacjaTekstu.Write("Chyba ma aimbota (+100% dmg z łuku)");
                AnimacjaTekstu.Write("Broń jednoręczna na poziomie casuala (brak bonusów)");
                AnimacjaTekstu.Write("Broni dwuręcznej to on nawet nie podniesie (+50% dmg z dwuręki)");
                Console.WriteLine();
                AnimacjaTekstu.WriteMagneta("Ork");
                AnimacjaTekstu.Write("Pojebany barbarzyńca");
                AnimacjaTekstu.Write("Może nosić 2 miecze, (+50% całkowitego dmg)");
                AnimacjaTekstu.Write("Zawadiaka wali z dwuręki lepiej jak mental z metina (+125% dmg z dwuręki)");
                AnimacjaTekstu.Write("Łucznik z niego do dupy (brak bonusów)");
                AnimacjaTekstu.Write("Nie korzysta z magii. Sory, cięcia budżetowe");
                Console.WriteLine();
                AnimacjaTekstu.WriteMagneta("Mroczny Elf:");
                AnimacjaTekstu.Write("Większego skurwysyna na dystans nie znajdziesz");
                AnimacjaTekstu.Write("Kolejny pretendent do tytułu snajpera (+75% dmg z łuku)");
                AnimacjaTekstu.Write("Korzysta z energii życiowej smoczych kul mocy (+100% mag. dmg)");
                AnimacjaTekstu.Write("Casualowo korzysta z jednoręki (brak bonusów)");
                AnimacjaTekstu.Write("Siłownia mu obca, nie uniesie broni dwuręcznej (-50% dmg z dwuręki)");
                Console.WriteLine("");


            }
            if (rasa == "CZŁOWIEK")
            {
                prawda = 1;
                BrDwuR = 1;
                BrJednR = 2;
                Łuk = 1.5F;
                ArtMag = 0;
                Klasy();
            }
            if (rasa == "ELF")
            {
                prawda = 1;
                BrJednR = 1;
                BrDwuR = 0.5F;
                Łuk = 2;
                ArtMag = 1.5F;
                Klasy();
            }
            if (rasa == "ORK")
            {
                prawda = 1;
                BrJednR = 1.5F;
                BrDwuR = 2;
                Łuk = 1;
                ArtMag = 0;
                Klasy();
            }
            if (rasa == "MROCZNY ELF")
            {
                prawda = 1;
                BrJednR = 1;
                BrDwuR = 0.5F;
                Łuk = 1.75F;
                ArtMag = 2;
                Klasy();
            }
        } while (prawda == 0);
        prawda = 0;
    }
    public static void Klasy()
    {
        int prawda = 0;
        Console.WriteLine("");
        AnimacjaTekstu.Write("Wybierz swoją klasę:");
        AnimacjaTekstu.Write(">Hołod");
        AnimacjaTekstu.Write(">Programista");
        AnimacjaTekstu.Write(">PCtowiec");
        AnimacjaTekstu.Write(">WojownikCienia");
        AnimacjaTekstu.WriteGreen("Informacje na temat klas wyświetlisz korzystając z /klasy");
        do
        {
            klasa = Console.ReadLine().ToUpper();
            if (klasa == "/KLASY") //klasa
            {
                Informacje.Hołod();
                Informacje.PCtowiec();
                Informacje.Programista();
                Informacje.WojownikCienia();
            }
            if (klasa == "HOŁOD")
            {
                prawda = 1;
                Witalność = 9;
                Siła = -4;
                Inteligencja = -4;
                Zręczność = -5;
                Console.Clear();
                Rozdział1.Demo();
            }
            if (klasa == "PROGRAMISTA")
            {
                prawda = 1;
                Witalność = -3;
                Siła = -4;
                Inteligencja = 6;
                Zręczność = 3;
                Console.Clear();
                Rozdział1.Demo();
            }
            if (klasa == "PCTOWIEC")
            {
                prawda = 1;
                Witalność = 2;
                Siła = 3;
                Inteligencja = 3;
                Zręczność = -10;
                Console.Clear();
                Rozdział1.Demo();
            }
            if (klasa == "WOJOWNIKCIENI")
            {
                prawda = 1;
                Witalność = 4;
                Siła = 6;
                Inteligencja = -10;
                Zręczność = 5;
                Console.Clear();
                Rozdział1.Demo();
            }
            else
            {
                AnimacjaTekstu.WriteRed("Błąd. Spróbuj jeszcze raz.");
            }
        } while (prawda == 0);
        prawda = 0;
    }

    public static void Statystyki()
    {
        AnimacjaTekstu.Write("Klasa: " + Postać.klasa);
        AnimacjaTekstu.WriteGreen("Poziom:" + Lvl);
        AnimacjaTekstu.Write("EXP: " + Exp_Wymagany + "/" + Exp_Potrzebny);
        AnimacjaTekstu.WriteDYellow("Witalność: " + Witalność);
        AnimacjaTekstu.WriteDYellow("Siła: " + Siła);
        AnimacjaTekstu.WriteDYellow("Inteligencja: " + Inteligencja);
        AnimacjaTekstu.WriteDYellow("Zręczność: " + Zręczność);
        Console.ReadKey();

    }
}
}   
// do {} while {} - poruszanie się
//dodać warunki dostania się do pomieszczenia
