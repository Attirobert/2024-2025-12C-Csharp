using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macskak
{
    class Program
    {
        enum Animals { Macska, Kutya, Tigris, Farkas };

        static void Main(string[] args)
        {
            Animals b = Animals.Farkas;
            Animals c = Animals.Macska;

            if (b == Animals.Farkas)
            {
                Console.WriteLine("A b állat farkas.");
            }

            if (c == Animals.Macska)
            {
                Console.WriteLine("A c állat Macska.");
            }

            Console.ReadKey();
        }
    }
}
