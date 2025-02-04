using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Az erőforrások (például fájlok vagy adatbázis-kapcsolatok) felszabadítására szolgál.
Az Dispose metódus meghatározza az erőforrások felszabadításának logikáját.
Gyakran használják a using kulcsszóval.
*/

namespace DisposInterface
{
    // Ezt a mintát fájlok, adatbázisok kezelésénél használjuk és nyelvi szinten implementálva van az IDisposable interfész
    public class FileManager : IDisposable
    {
        private FileStream fileStream;

        public FileManager(string filePath)
        {
            fileStream = new FileStream(filePath, FileMode.OpenOrCreate);
        }

        public void WriteData(string data)
        {
            var writer = new StreamWriter(fileStream);
            writer.Write(data);
            writer.Flush();
        }

        public void Dispose()
        {
            fileStream?.Dispose();
            Console.WriteLine("Erőforrások felszabadítva.");
        }
    }

    class DisposProg
    {
        static void Main()
        {
            using (var manager = new FileManager("minta.txt"))
            {
                manager.WriteData("Hello, World!");
            } // Itt automatikusan meghívódik a Dispose metódus

            Console.ReadKey();
        }
    }
}
