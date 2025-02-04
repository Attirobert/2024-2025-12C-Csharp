using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Lehetővé teszi egy objektum másolatának létrehozását.
Egyetlen metódusa van: Clone.
Mély vagy sekély másolatot hozhat létre.
*/

namespace CloneInterface
{
    public class Person : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Az interfészben deklarált metódus megvalósítása
        public object Clone()
        {
            return new Person { Name = this.Name, Age = this.Age };
        }
    }

    internal class CloneProg
    {
        static void Main(string[] args)
        {
            Person original = new Person { Name = "John", Age = 30 };
            Person clone = (Person)original.Clone();

            Console.WriteLine($"Eredeti: {original.Name}, {original.Age}");
            Console.WriteLine($"Másolat: {clone.Name}, {clone.Age}");
        }
    }
}
