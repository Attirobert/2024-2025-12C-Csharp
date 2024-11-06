using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Kor2
    {
        // Osztályváltozók
        private double sugár,
            kerület,
            terület;

        // Konstruktorok
        public Kor2() { }

        public Kor2(double r)
        {
            this.sugár = r;
            számítások();
        }

        // Metódusok
        public void SetSugár(double r)
        {
            this.sugár = r;
            számítások();
        }

        private void kalkKerület()
        {
            this.kerület = 2 * this.sugár * Math.PI;
        }

        private double kalkTerület(double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        private void számítások()
        {
            kalkKerület();
            this.terület = kalkTerület(this.sugár);
        }

        public double GetKerület() { return this.kerület; }
        public double GetTerület() { return this.terület; }
        public double GetSugár() { return this.sugár; }
    }
}
