using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Ez a példa az Abstract kulcsszó használatát mutatja be.
 * Az abstract kulcsszóval olyan osztályokat és metódusokat jelölünk, amelyeket nem lehet közvetlenül példányosítani, illetve végrehajtani. Az abstract osztályokat alapként használják más osztályok számára, míg az abstract metódusok deklarációkat tartalmaznak, de nem adnak meg implementációt.
 * 
 * Fontos jellemzők:
    - Abstract osztály: Csak származtatott osztályokon keresztül használható. Tartalmazhat absztrakt és nem absztrakt (működő) metódusokat is.
    - Abstract metódus: Csak absztrakt osztályban lehet, és a származtatott osztálynak kötelező megvalósítania.
 */

namespace Abstract
{
    abstract class Shape
    {
        // Abstract metódus - nincs implementáció
        // Ennek a kódját a leszármazottban kötelező megírni!
        public abstract double GetArea();

        // Normál metódus - van implementáció
        public void DisplayShape()
        {
            Console.WriteLine("Ez egy alakzat");
        }
    }

    class Circle : Shape
    {
        private double sugar;

        public Circle(double r)
        {
            this.sugar = r;
        }

        // Abstract metódus implementálása
        public override double GetArea()
        {
            return Math.PI * sugar * sugar;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Shape példányosítása nem lehetséges:
            // Shape shape = new Shape(); // Fordítási hiba!

            // Circle példányosítása:
            Circle circle = new Circle(5);
            Console.WriteLine("A kör területe: " + circle.GetArea());
            circle.DisplayShape();  // A DisplayShape metódust a szülő osztályból hívja meg.

            Console.ReadKey();
        }
    }
}
