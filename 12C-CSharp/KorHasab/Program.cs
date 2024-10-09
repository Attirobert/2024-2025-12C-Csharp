using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Program
    {
        static void Main(string[] args)
        {
            // A Kor osztály felhasználása
            #region 1. objektum
            // 1. objektumunk
            Kor k1 = new Kor(); // Objektum példány létrehozása üresen
            k1.ReadSugar(15.0); // Sugár megadása
            k1.SetKerulet();    // Kiszámoltatjuk a kerületet
            k1.SetTerulet();    // Kiszámoltatjuk a területet
            Console.WriteLine($"A {k1.GetSugar()} sugarú kör kerülete {k1.GetKerulet()}, területe: {k1.GetTerulet()}");
            #endregion EOf 1. objektum
            #region 2. objektumunk
            Kor k2 = new Kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();
            Console.WriteLine($"A {k2.GetSugar()} sugarú kör kerülete {k2.GetKerulet()}, területe: {k2.GetTerulet()}");
            #endregion EOf 2. objektum

            Console.ReadKey();
        }
    }
}
