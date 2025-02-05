using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Két objektum egyenlőségének ellenőrzésére szolgál.
Egyetlen metódusa az Equals metódus.
*/

namespace EquatInterface
{
    public class Point : IEquatable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public bool Equals(Point other)
        {
            // Egyedi feltételeket határozhatunk meg az egyenlőség vizsgálatához
            if (other == null) return false;
            return this.X == other.X && this.Y == other.Y;
        }
    }

    internal class EquatProg
    {
        static void Main(string[] args)
        {
            Point p1 = new Point { X = 5, Y = 10 };
            Point p2 = new Point { X = 5, Y = 10 };
            Point p3 = new Point { X = 7, Y = 10 };

            Console.WriteLine(p1.Equals(p2)); // True
            Console.WriteLine(p1.Equals(p3)); // False

            Console.ReadKey();
        }
    }
}
