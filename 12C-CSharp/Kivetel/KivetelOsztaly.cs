using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class KivetelOsztaly
    {
        // Konstruktor
        public KivetelOsztaly() { }

        #region Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezelés\nAdjon meg egy karaktert!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);
            Console.ReadKey();
        }
        #endregion Nincs kivétel kezelés

        #region Általános kivételkezelés
        public void KivKezAlt()
        {
            Console.WriteLine("\nHiba objektum nélküli kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch
            {
                Console.WriteLine("Hibás adat!");
            }
            Console.ReadKey();
        }
        #endregion Általános kivételkezelés

        #region Kivételkezelés Őshiba objektummal
        public void KivKezOs()
        {
            Console.WriteLine("\nŐs Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
        #endregion Kivételkezelés Őshiba objektummal

        #region Kivételkezelés Hiba objektummal
        public void KivKezObj()
        {
            Console.WriteLine("\nSaját Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        #endregion Kivételkezelés Hiba objektummal

        #region Kivételkezelés név nélküli hiba objektummal
        public void KivKezNoName()
        {
            Console.WriteLine("\nKivételkezelés név nélküli hiba objektummal\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
                if (szam == 0)
                {
                    throw new ArgumentException("A beírt szám nem lehet nulla!");
                }
            }
            catch
            {
                // throw new FormatException("A beírt szám nem egész szám!");
                Console.WriteLine("Hibás adat!");
            }
            Console.ReadKey();
        }
        #endregion Kivételkezelés név nélküli hiba objektummal

        #region Kivételkezelés saját hiba objektummal, üzenet nélkül
        public void KivKezSajatNoMessage()
        {
            // Utasítás a kezelőnek
            Console.WriteLine("\nKivételkezelés saját hiba objektummal, üzenet nélkül\nAdjon meg egy karaktert!");

            try
            {
                // Beolvasott érték
                int szam = Convert.ToInt32(Console.ReadLine());

                // Saját hiba generálása
                if (szam == 0) { throw new SajatException(); }
            }
            catch (SajatException ex)
            {
                Console.WriteLine($"Hibaüzenet: {ex.Message}");
            }
        }
        #endregion Kivételkezelés saját hiba objektummal, üzenet nélkül

        #region Kivételkezelés saját hiba objektummal, üzenettel
        public void KivKezSajatWithMessage()
        {
            Console.WriteLine("\nKivételkezelés saját hiba objektummal, üzenettel\nAdjon meg egy karaktert!");

            try
            {
                // Beolvasott érték
                int szam = Convert.ToInt32(Console.ReadLine());

                // Saját hiba generálása
                if (szam == 0) { throw new SajatException("A szám nem lehet nulla!"); }
            }
            catch (SajatException ex)
            {
                Console.WriteLine($"Hibaüzenet: {ex.Message}");
            }
        }
        #endregion Kivételkezelés saját hiba objektummal, üzenettel
    }
}
