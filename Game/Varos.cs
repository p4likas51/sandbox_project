using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        
        public static int VidekiEsemeny(int cost)
        {
            string szoveg = "Jelenlegi helyzet: Videkinél kéreget egy napsütötte ember. Adsz neki pénzt?";
            string[] valasztasok = { "Igen", "Nem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            valasztottIndex = ElfogyPenz(valasztottIndex, cost);
            return valasztottIndex;
        }
        public static int Videki()
        {

            string szoveg = "Jelenlegi helyzet: Videki";
            string[] valasztasok = { "Kondi", "Dohi", "Vasútállomás aluljáró" };
            if (veralkoholszint >= 60)
            {
                List<string> list = new();
                list.AddRange(valasztasok);
                list.Add("Lucifer XXX Shop");
                valasztasok = list.ToArray();
            }
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int KondiEsemeny(int cost)
        {
            string szoveg = "Jelenlegi helyzet: Kondiban a legnagyobb csávó pirulákat és injekciót akar neked adni mindössze 1000Ft-ért. Elfogadod?";
            string[] valasztasok = { "Igen", "Nem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            valasztottIndex = ElfogyPenz(valasztottIndex, cost);
            return valasztottIndex;
        }
        public static int Kondi()
        {
            string szoveg = "Jelenlegi helyzet: Kondi";
            string[] valasztasok = { "Vidéki"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int DohiKunyeralas()
        {
            string szoveg = "Jelenlegi helyzet: A hitel miatt megfordul a fejedben, hogy kihasználva jóképűséged szerezz egy kis pénzt.";
            string[] valasztasok = { "Kunyerálás", "Gondolat elhesegetése" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int DohiBolt()
        {
            string szoveg = "Jelenlegi helyzet: Dohi.";
            string[] valasztasok = { "Alkohol vétel", "Cigi vétel", "Nem kell semmi" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Dohi()
        {
            string szoveg = "Jelenlegi helyzet: Dohi";
            string[] valasztasok = { "Vidéki" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int LuciferShopTamadas()
        {
            string szoveg = "Jelenlegi helyzet: Mivel nem adtal pénzt a vidékiben, ezért a család összegyűlt, hogy megverjenek";
            string[] valasztasok = { "Harc" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            if (fegyverek > 0 && bogyok == true)
            {
                Console.WriteLine("A bogyók miatt duzzadó karjaidból a nyers erő párosult a fegyverrel, amit szereztél");
                Console.WriteLine("Nyomj egy gombot a továbblépéshez");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"

  _   _                 _    __ _   _ 
 | \ | |               | |  /_/| | | |
 |  \| |_   _  ___ _ __| |_ ___| | | |
 | . ` | | | |/ _ \ '__| __/ _ \ | | |
 | |\  | |_| |  __/ |  | ||  __/ | |_|
 |_| \_|\__, |\___|_|   \__\___|_| (_)
         __/ |                        
        |___/                         
");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Az elhullottak holmijait ellopod, összeszedtél 2000Ft-ot.");
                Thread.Sleep(5000);
                penz += 2000;
                eletkedv += 50;
            }
            else
            {
                Console.WriteLine("Nem állnak jól az esélyeid, túl nagy a túlerő...");
                Console.WriteLine("Nyomj egy gombot a továbblépéshez");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"

 __      __           _       _   _    __ _   _ 
 \ \    / /          | |     | | | |  /_/| | | |
  \ \  / /__  ___ ___| |_ ___| |_| |_ ___| | | |
   \ \/ / _ \/ __|_  / __/ _ \ __| __/ _ \ | | |
    \  /  __/\__ \/ /| ||  __/ |_| ||  __/ | |_|
     \/ \___||___/___|\__\___|\__|\__\___|_| (_)
                                                
                                                
");
                Console.ForegroundColor = ConsoleColor.White;
                eletkedv = 0;
                idegallapot += 50;
                Thread.Sleep(5000); 
                int eselyKorhaz = rand.Next(1, 101);
                if (eselyKorhaz > 0)
                {
                    Korhaz();
                    KorhazTulelve();
                }
            }
            return valasztottIndex;
        }
        public static int LuciferShopBolt()
        {
            string szoveg = "Jelenlegi helyzet: Lucifer XXX Shop";
            string[] valasztasok = { "Gumiostor vásárlása", "Gimp ruha vásárlása", "Nem kell semmi" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int LuciferShop()
        {
            string szoveg = "Jelenlegi helyzet: Lucifer XXX Shop";
            string[] valasztasok = { "Vidéki" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int VasutLopas()
        {
            string szoveg = "Jelenlegi helyzet: Aluljáróban haladva nem tudod kiverni a fejedből azt a felhalmozódott hitelt. Ekkor meglátsz egy boldog utcazenészt";
            string[] valasztasok = { "Lopsz", "Tovább haladsz" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int VasutWC()
        {
            string szoveg = "Kalandod közben nagyon rádjött a vécézhetnék, biztos elrontottad a pocakod";
            string[] valasztasok = { "Aluljáró WC használata" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Vasut()
        {
            string szoveg = "Jelenlegi helyzet: Vasútállomás aluljáró";
            string[] valasztasok = { "Vidéki", "Eurós bolt", "Jedlik" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int EurosOliver()
        {
            string szoveg = "Jelenlegi helyzet: Az Eurós boltban találkozol szeretett osztálytársaddal Roncz Olivérrel";
            szoveg += "\nKitalálja, hogy kő-papír-ollózzatok, ha ő nyer veszel neki egy hagymáskarikát, ha te akkor ő vesz neked egy rakétát";
            szoveg += "\n(Csak akkor tudsz játszani, ha van elég pénzed egy hagymáskarikára)";
            string[] valasztasok = {"Kő-papír-olló", "Inkább kihagyod"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int OliverAjandeka()
        {
            string szoveg = "Mit vegyen neked Olivér";
            string[] valasztasok = { "Rakéta", "Hagymakarika" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int EurosBolt()
        {
            string szoveg = "Jelenlegi helyzet: Eurós Bolt";
            string[] valasztasok = { "Rakéta vásárlása", "Hagymakarika vásárlása", "Nem kell semmi" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Euros()
        {
            string szoveg = "Jelenlegi helyzet: Eurós Bolt";
            string[] valasztasok = { "Vasútállomás aluljáró" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Jedlik()
        {
            string szoveg = "Jelenlegi helyzet: Jedlik";
            string[] valasztasok = { "Vasútállomás aluljáró" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Korhaz()
        {
            veralkoholszint = 0;
            idegallapot = 50;
            eletkedv = 0;
            int tuleles = rand.Next(0, 101);
            string szoveg = @"

  _  __ __       _       __      
 | |/ //_/      | |     /_/      
 | ' / ___  _ __| |__   __ _ ____
 |  < / _ \| '__| '_ \ / _` |_  /
 | . \ (_) | |  | | | | (_| |/ / 
 |_|\_\___/|_|  |_| |_|\__,_/___|
                                 
                                 
" +
                "Jelenlegi helyzet: \n\tValahogy azon kapon magad hogy egy kórházi ágyon fekszel, nem emlékszel semmire, állapotod nagyon súlyos, még semmi nem dőlt el";
            string[] valasztasok = { "Fekvés a halálos ágyon" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            Thread.Sleep(2000);
            if (tuleles > 70)
            {
                Halal();
            }
            return valasztottIndex;
        }
        public static int KorhazTulelve()
        {
            string szoveg = "Jelenlegi helyzet: Kórházból kiengedtek! Kezdésed helye a legutóbbi helyzeted";
            string[] valasztasok = { "Kezdés" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

    }
}
