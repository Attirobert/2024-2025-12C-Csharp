using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * IEnumerable és IEnumerator interfészek
Az IEnumerable lehetővé teszi, hogy egy osztály elemeit iterálni lehessen, például egy foreach ciklusban.
Rövid leírás:
Az IEnumerable a GetEnumerator metódust határozza meg.
Az IEnumerator a MoveNext, Reset és Current metódusokat/properties-t tartalmazza.
*/

namespace EnumerableNevTer
{
    /* Az osztály egy GetEnumerator metódust biztosít, amely egyedi CustomEnumerator objektumot ad vissza.
       Az IEnumerable<int> interfész használata lehetővé teszi, hogy a kollekció bejárható legyen foreach ciklussal.
    */
    public class CustomCollection : IEnumerable<int>
    {

        // Megadjuk az osztály elemeit
        private int[] items = { 1, 2, 4, 3, 5 };

        // Egyedi CustomEnumerator objektumot ad vissza.
        // Az IEnumerable<int> interfész használata lehetővé teszi, hogy a kollekció bejárható legyen foreach ciklussal.
        public IEnumerator<int> GetEnumerator()
        {
            return new CustomEnumerator(items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    // Egyedi Enumerator osztály az elemek iterálásához
    public class CustomEnumerator : IEnumerator<int>
    {
        private int[] _items;
        private int _position = -1; // Az enumerátor kezdeti állapota

        public CustomEnumerator(int[] items)
        {
            _items = items;
        }

        // MoveNext: Lép a következő elemre a kollekcióban
        public bool MoveNext()
        {
            _position++;
            return (_position < _items.Length);
        }

        // Reset: Az enumerátort visszaállítja a kezdeti állapotba
        public void Reset()
        {
            _position = -1;
        }

        // Current: Az aktuális elem visszaadása
        public int Current
        {
            get
            {
                if (_position < 0 || _position >= _items.Length)
                    throw new InvalidOperationException("A pozíció kívül esik az érvényes tartományon.");
                return _items[_position];
            }
        }

        object IEnumerator.Current => Current; // Az interfész explicit implementációja

        // Dispose: Nem szükséges, de implementálható, ha szükséges az erőforrások felszabadítása
        public void Dispose() { }
    }


    class Program
    {
        static void Main()
        {
            // Az osztály példányosítása
            var collection = new CustomCollection();

            Console.WriteLine("Iterálás foreach ciklussal:");
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIterálás manuálisan az IEnumerator-rel:");
            using (IEnumerator<int> enumerator = collection.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }

            Console.ReadKey();
        }
    }
}
