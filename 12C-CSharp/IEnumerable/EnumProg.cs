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
    public class CustomCollection : IEnumerable<int>
    {
        private int[] items = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class EnumProg
    {
        static void Main()
        {
            var collection = new CustomCollection();
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
