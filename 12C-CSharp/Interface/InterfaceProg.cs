using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ez a példa az interfészek használatára (IComparable) mutat példát.
 * Az IComparable interfész a C#-ban egy beépített interfész, amely lehetővé teszi, hogy objektumokat összehasonlítsunk össze egymással. Ez különösen hasznos, amikor egyéni objektumokat szeretnénk rendezni vagy összehasonlítani, például listákban vagy más gyűjteményekben.
 * Az interfész egyetlen metódust definiál: int CompareTo(object obj);
 * Visszatérési értéke:
 * 0: Az objektumok egyenlőek.
 * -1: Az aktuális objektum kisebb, mint a másik objektum.
 * 1: Az aktuális objektum nagyobb, mint a másik objektum.
 */

namespace Interface
{
    public class Person : IComparable<Person>
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // IComparable<Person> implementáció
        public int CompareTo(Person other)
        {
            if (other == null) return 1; // Az aktuális objektum nagyobb, ha a másik null
            return this.Age.CompareTo(other.Age);   // A két Age tulajdonságot hasonlítja össze az interfészben megadott módon adja vissza az eredményt
        }

        // Az ősosztály ToString metódusát felül írjuk
        public override string ToString()
        {
            return $"{Name} ({Age} éves)";
        }
    }
    class InterfaceProg
    {
        static void Main(string[] args)
        {
            // Létrehozunk néhány Person objektumot
            List<Person> people = new List<Person>
            {
                new Person("Anna", 25),
                new Person("Béla", 30),
                new Person("Cecília", 20),
                new Person("Dénes", 35)
            };

            // Lista rendezése az Age alapján
            people.Sort();

            // Rendezett lista kiíratása
            Console.WriteLine("Rendezett lista:");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
