using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Példa a következőkre:
 * virtual, override
 * A virtual kulcsszó azt jelzi, hogy egy metódus, property felülírható egy származtatott osztályban. A virtual tagok alapértelmezett viselkedést biztosítanak az ősosztályban, de a származtatott osztályban az override kulcsszóval módosíthatjuk ezt a viselkedést.
 * Mikor használjuk a virtual kulcsszót?
    - Ha egy alapértelmezett implementációt szeretnél megadni az ősosztályban.
    - Ha azt szeretnéd, hogy a származtatott osztályok felülírhassák ezt az alapértelmezett viselkedést.
    - Ha polimorfizmust szeretnél megvalósítani az objektumorientált programozásban.
**************
 * sealed
 * A sealed kulcsszó lezárja az osztályokat vagy metódusokat a további örökléstől vagy felülírástól, ezáltal biztosítva a stabilitást és a logika változatlanságát a kódbázisban.
 * 
 * Mikor használjuk?
 * sealed osztály:
Ha egy osztályt véglegessé szeretnénk tenni, és biztossá akarjuk tenni, hogy más osztályok ne örököljék és módosítsák azt.
Példa: Beépített osztályok, mint a System.String vagy System.Math, sealed osztályok.
 * sealed metódus:
Ha egy metódust egy származtatott osztályban felülírunk, de nem akarjuk engedni, hogy további származtatott osztályok ezt a metódust újra felülírják.
 */
namespace Orokles
{
    // Átlagos osztály
    class Allat
    {
        // Properties
        public string Name { get; set; }
        public string Hang { get; set; }

        // Konstruktorok
        public Allat()
        {
            this.Name = "Anonim";
            this.Hang = "Én egy Allat vagyok";
        }

        public Allat(string name)
        {
            this.Name = name;
            this.Hang = "Én egy Allat vagyok";
        }

        // Metódusok
        public void hangotAd()
        {
            Console.WriteLine("Ezt a Allat.hangotAd() metódus írta ki.");
            Console.ReadKey();
        }

        // Virtuális metódus
        public virtual void mozog()
        {
            Console.WriteLine("Ezt a virtuális mozog() metódus írta ki.");
            Console.ReadKey();
        }
    }

    // ok
    class Kutya : Allat
    {
        public Kutya() : base()
        {
            this.Hang = "Én egy kutya vagyok";
            Console.ReadKey();
        }

        // Átlagos metódus felülírása (shadow hatás)
        public void hangotAd()
        {
            Console.WriteLine("Ezt a Kutya.hangotAd() metódus írta ki.");
            Console.ReadKey();
        }

        // Felül írt virtuális metódus lezárással
        public sealed override void mozog()
        {
            Console.WriteLine("Ezt a lezárt mozog() metódus írta ki.");
            Console.ReadKey();
        }
    }

    class Komondor : Kutya
    {
        public Komondor() : base()
        {
            this.Name = "Komondor";
        }

        // Lezárt metódust nem írhatjuk felül
        //public override void mozog()
        //{
        //    Console.WriteLine("Elindultam");
        //}

        public void mozog(){ }
    }

    // Osztály lezárása
    sealed class Macska : Allat
    {
        public Macska()
        {
            this.Name = "Cicamica";
        }
    }

    /*//Lezárt osztályból nem származtatható
    class Sziami : Macska
    {

    }*/

    internal class OroklesProg
    {
        static void Main(string[] args)
        {
        }
    }
}
