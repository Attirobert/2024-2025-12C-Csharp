using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class KivetelOsztaly
    {
        public KivetelOsztaly() { }

        // Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezelés\nAdjon meg egy karaktert!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A beírt szám: {0}", szam);
            Console.ReadKey();
        }

        // Általános kivételkezelés
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

        // Őshiba objektummal
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
        // Hiba objektummal
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

        // Saját hiba objektummal
        public void KivKezSaját()
        {
            Console.WriteLine("\nSaját Hiba objektummal kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("A beírt szám: {0}", szam);
            }
            catch 
            {
                throw new Exception("A beírt szám nem egész szám!");
            }
            Console.ReadKey();
        }
    }
}
