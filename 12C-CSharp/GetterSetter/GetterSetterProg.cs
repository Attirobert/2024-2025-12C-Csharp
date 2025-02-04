using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ez a példa a property-k használatát mutatja be.
 * A property egy olyan változó, amely publikus és van két metódusa: 
 *   - set az értékének az ellenőrzött beállításához és 
 *   - get metódus az értékének az ellenörzött visszaadásához.
 * Tulajdon képpen az osztályváltozók (amelyek private láthatóságúak és külön írtunk hozzá beállító és kiolvasó metódusokat) egyszerűsített kezelését teszi lehetővé.
 */

namespace GetterSetter
{
    class Person
    {
        public Person() { }

        // Property alap deklarációja
        // Itt nem ellenőrizzük a beírást és a kiírást.  Az osztályváltozó is név nélküli, nem férünk közvetlenül hozzá
        public string Name { get; set; }

        // Ha a property mögötti osztályváltozóhoz közvetlenül hozzá akarunk férni, akkor a következő módon járunk el:
        private int id;
        public int Id { get => id; set => id = 101; }

        // Ez pedig az eredeti, eddig használt megoldás
        private int age; // Osztályváltozó
        public void setAge(int age) { this.age = age; }
        public int getAge() { return this.age; }

        // Abban az esetben, ha összetettebb beviteli és / vagy kiolvasási eljárást használunk, akkor érdemesebb a hagyományos módon eljárni
        private int gender;
        public void setGender(string gender)
        {
            switch (gender)
            {
                case "Férfi": this.gender = 1; break;

                case "Nő": this.gender = 2; break;

                default: this.gender = 3; break;
            }
        }

        public string getGender()
        {
            switch (this.gender)
            {
                case 1: return "Férfi";
                case 2: return "Nő";
                default: return "Ismeretlen";
            }
        }
    }



    class GetterSetterProg
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Ádám";
            Console.WriteLine(person.Name);

            person.Id = 99;
            Console.WriteLine(person.Id);

            Console.ReadKey();
        }
    }
}
