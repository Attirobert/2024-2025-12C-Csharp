using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Kor
    {
        // Az osztály feladata a sugárból kiszámítja a kör területét és kerületét

        // Osztályváltozók
        private double sugar,
            kerulet,
            terulet;

        // Konstruktorok
        public Kor(){}

        public Kor(double r)
        {
            this.sugar = r;
        }

        // Metódusok
        public void ReadSugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        public void SetTerulet()
        {
            double eredmény1 = 0.0,
                eredmény2=0.0;

            eredmény1 = this.sugar * this.sugar * Math.PI;

            eredmény2 = Math.Pow(this.sugar, 2) * Math.PI;

            if (eredmény1 == eredmény2)
            {
                this.terulet = eredmény1;
            }
            else
            {
                Console.WriteLine($"Eredmény1 ({eredmény1}) != Eredmény2 ({eredmény2})");
            }
        }

        public double GetKerulet() { return this.kerulet; }
        public double GetTerulet() { return this.terulet; }
        public double GetSugar() { return this.sugar; }
    }
}
