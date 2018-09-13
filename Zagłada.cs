using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hołod_the_Game
{
    class Zagłada
    {   
        public static void Zagłada1()
        {
            AnimacjaTekstu.Write("TRYB NADAL W TRAKCIE DOPRACOWYWANIA");
            Thread.Sleep(5000);
            Console.WriteLine("");
            AnimacjaTekstu.Write("Tak na prawdę, to nawet nie zacząłem -Hubi");
            AnimacjaTekstu.Write("Wciśnij dowolny klawisz");
            Console.ReadKey();
            MenuGłówne.StartMenuGłówne();
        }
    }
}
