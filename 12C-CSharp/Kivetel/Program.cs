using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class Program
    {
        static void Main(string[] args)
        {
            // Osztály példányosítása
            KivetelOsztaly k = new KivetelOsztaly();

            //k.KivKezNincs();    // Nincs hibakezelés, futásidejű hiba
            //k.KivKezAlt();      // Általános hibakezelés, a hiba adataihoz nem férünk hozzá
            //k.KivKezOs();       // Minden hibát az ősosztállyal fogunk el. Ezért csak általános megoldást adhatunk.
            //k.KivKezObj();      // Minden hibát a saját kivétel osztályával fogunk el.  A hiba típusától függően különböző módokon járhatunk el.
            //k.KivKezNoName();     // Új hiba objektumot példányosítunk, amit tovább dobunk és a rendszer hibakezelője dolgoz fel.
            //k.KivKezSajatNoMessage();   // Saját hiba objektumot használunk, amiben nem adtunk meg üzenetet
            k.KivKezSajatWithMessage(); // Saját hiba objektumot használunk, saját üzenettel

            Console.ReadKey();
        }
    }
}
