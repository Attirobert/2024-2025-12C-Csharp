using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Írjunk olyan programot, amely addig kér
be egész számokat a billentyűzetről, amíg azok összege meg nem haladja a 100-at. A
beolvasás végén írjuk ki azt, hogy a bekért számok közül hány volt páros, és hány volt
páratlan.
 */
namespace TobbElem
{
    class TobbElemOsztaly
    {
        // Osztályváltozók
        private int szam;
        private bool isParos;

        // Konstruktor
        public TobbElemOsztaly()
        {
            this.szam = 0;
            this.isParos = false;
        }

        public void GetSzam(int p)
        {
            this.szam = p;
        }

        public void SetSzamTipus()
        {
            this.isParos = szam % 2 == 0;
        }

        public bool outSzamTipus()
        {
            return this.isParos;
        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            // osztályváltozók
            string valasz = String.Empty;
            int paros = 0,
                szam = 0,
            paratlan = 0;


            // Példányosítjuk az osztályt,
            // más néven objektumot hozunk létre az osztályból
            TobbElemOsztaly a = new TobbElemOsztaly();

            // Szám megadása
            while (paros + paratlan < 100)
            {
                Console.WriteLine("Adj meg egy egész számot!");
                szam = Convert.ToInt32(Console.ReadLine());
                a.GetSzam(szam);
                a.SetSzamTipus();
                if (a.outSzamTipus())
                {
                    valasz = "páros";
                    paros += szam;
                }
                else
                {
                    valasz = "páratlan";
                    paratlan += szam;
                }
                Console.WriteLine($"A szám típusa: {valasz}, eddig a számok összege: {paros + paratlan}");
                Console.ReadKey();

            }
        }
    }
}
