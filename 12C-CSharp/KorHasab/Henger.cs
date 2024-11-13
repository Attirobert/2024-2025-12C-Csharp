using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Henger : Kor
    {
        // osztályváltozók
        private double magasság,
            térfogat;

        // Konstruktor
        public Henger(double r, double m)
        {
            this.sugar = r;
            this.magasság = m;
            SetTerulet();   // Az eredmény a terulet nevű osztályváltozóba kerül
            this.térfogat = this.terulet * this.magasság;
        }

        public double GetTérfogat() { return this.térfogat; }
        public double GetMagasság() { return this.magasság; }

    }
}
