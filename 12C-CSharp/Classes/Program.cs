using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Allat
    {
        // Osztályváltozók (properties)
        private string nev;
        private string fajta;
        private string szin;
        private int kor;
        protected string hang;

        public Allat(string nev, string fajta, string szin)
        {
            this.nev = nev;
            this.fajta = fajta;
            this.szin = szin;
        }

        public Allat()
        {
            this.nev = "anonim";
            this.fajta = "ismeretlen";
            this.szin = "fekete";
            this.kor = 0;
        }

        public void setNev(string p){this.nev = p;}
        public string getNev(){return this.nev;}

        public int getKor(){return this.kor;}
        public void setKor(int p)
        {
                if (p > 0 && p < 50) this.kor = p / 0;
        }

        public void setFajta(string p){this.fajta = p;}
        public string getFajta() {return this.fajta;}

        public void setSzin(string p){this.szin = p;}
        public string getSzin(){return this.szin;}

        public string hangotAd()
        {
            return this.hang;
        }

    }

    class Kutya : Allat
    {
        // Osztályváltozó
        private string gazda;

        public Kutya(string nev, string fajta, string szin) : base(nev, fajta, szin)
        {
            this.gazda = "ismeretlen";
            this.hang = "vau vau";
        }

        public Kutya() : base()
        {
            this.gazda = "ismeretlen";
            this.setNev("neve nincs");
            this.setSzin("ismeretlen");
            this.setKor(0);
            this.setFajta("ismeretlen");
            this.hang = "Én egy beszélő kutya vagyok. A nevem: " + this.getNev();
        }

        public void setGazda(string p) { this.gazda = p; }
        public string getGazda() { return this.gazda; }
    }
    
    class Macska : Allat
    {
        public Macska(string nev, string fajta, string szin) : base(nev, fajta, szin)
        {
            this.hang = "miau miau";
        }

        public Macska() : base()
        {
            this.setNev("neve nincs");
            this.setSzin("ismeretlen");
            this.setKor(0);
            this.setFajta("ismeretlen");
            this.hang = "Én egy beszélő macska vagyok. A nevem: " + this.getNev();

        }
    }

    // Polimorfizmus példa
    class Home
    {
        // Osztályváltozó
        List<Allat> szobak = new List<Allat>();
        Random r = new Random();

        public Home() { }

        public void allatAdd(Allat p)
        {
            this.szobak.Add(p);
        }

        public Allat getAllat()
        {
            return this.szobak[r.Next(0, this.szobak.Count)];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Példányosítunk objektumokat
            Allat allat1 = new Allat("Bodri", "Puli", "fekete");
            allat1.setKor(2);
            Console.WriteLine("Az állat1 neve: {0}, kora {1} év", allat1.getNev(), allat1.getKor()); 
            
            Allat allat2 = new Allat("Bolhás", "Komondor", "fehér");
            Console.WriteLine("\nAz állat2 neve: {0}", allat2.getNev());

            Allat allat3 = new Allat();
            Console.WriteLine("\nAz állat3 neve: {0}, " +
    "\nkora {1} év \nfajtája: {2} \nszíne: {3}", allat3.getNev(), allat3.getKor(), allat3.getFajta(), allat3.getSzin());

            allat3.setNev("Vadász");
            allat3.setFajta("Agár");
            allat3.setSzin("barna");
            allat3.setKor(5);
            Console.WriteLine("\nAz állat3 neve: {0}, " +
                "\nkora {1} év \nfajtája: {2} \nszíne: {3}", allat3.getNev(), allat3.getKor(), allat3.getFajta(), allat3.getSzin());

            Console.WriteLine("\nAz állat3 hangja: {0}", allat3.hangotAd());
            Console.WriteLine("\n============== Származtatott ==================\n");
            Kutya kutya1 = new Kutya("Bogár", "puli", "fekete");
            kutya1.setKor(6);
            kutya1.setGazda("Pista bá");
            Console.WriteLine("\nA kutya1 neve: {0}, " +
                "\nkora {1} év \nfajtája: {2} \nszíne: {3}\ngazdája: {4}", kutya1.getNev(), kutya1.getKor(), kutya1.getFajta(), kutya1.getSzin(), kutya1.getGazda());
            Console.WriteLine("A kutya1 hangja: {0}", kutya1.hangotAd());

            Macska macska1 = new Macska("Cirmos", "sziámi", "barnás");
            macska1.setKor(2);
            Console.WriteLine("\n\nA macska1 neve: {0}, " +
                "\nkora {1} év \nfajtája: {2} \nszíne: {3}", macska1.getNev(), macska1.getKor(), macska1.getFajta(), macska1.getSzin());
            Console.WriteLine("A macska1 hangja: {0}", macska1.hangotAd());

            Console.ReadKey();

            // Poliformizmus példa
            Console.WriteLine("================ Poliformizmus példa ===============");

            // Példányosítjuk a Home-ot
            Home sweetHome = new Home();

            // Beköltöztetjük az állatokat
            for (int i = 0; i < 20; i++)
            {
                sweetHome.allatAdd(new Kutya());
                sweetHome.allatAdd(new Macska());
            }

            // Kihívjuk az állatokat
            Allat a = new Allat();
            for (int i = 0; i < 20; i++)
            {
                a = sweetHome.getAllat();
                Console.WriteLine("\n {0}", a.hangotAd());
                Console.WriteLine("Fajtám {0}: ", a.getFajta());
                Console.WriteLine("Korom {0}: ", a.getKor());
                Console.WriteLine("Színem {0}: ", a.getSzin());
            }

            Console.ReadKey();
        }
    }
}
