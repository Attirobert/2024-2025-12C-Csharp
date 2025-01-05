using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    public class SajatException : Exception
    {
        // Alapértelmezett, üres konstruktor
        public SajatException() : base() { }

        // Konstruktor az üzenet beállítására
        public SajatException(string message) : base(message) { }
    }
}
