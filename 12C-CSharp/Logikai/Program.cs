using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logikai
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true,
                b = true;

            #region És kapcsolat
            Console.WriteLine("Az és (&&) kapcsolat");
            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b = {a && b}");

            a = true;
            b = false;
            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b = {a && b}");

            a = false;
            b = true;
            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b = {a && b}");

            a = false;
            b = false;
            Console.WriteLine($"Ha a={a} és b={b}, akkor a&&b = {a && b}");
            #endregion Eof És kapcsolat

            #region Vagy kapcsolat
            a = true;
            b = true;
            Console.WriteLine("\nA 'vagy' (||) kapcsolat");
            Console.WriteLine($"Ha a={a} vagy b={b}, akkor a||b = {a || b}");

            a = true;
            b = false;
            Console.WriteLine($"Ha a={a} vagy b={b}, akkor a||b = {a || b}");

            a = false;
            b = true;
            Console.WriteLine($"Ha a={a} vagy b={b}, akkor a||b = {a || b}");

            a = false;
            b = false;
            Console.WriteLine($"Ha a={a} vagy b={b}, akkor a||b = {a || b}");

            #endregion Eof Vagy kapcsolat

            Console.ReadKey();
        }

    }
}
