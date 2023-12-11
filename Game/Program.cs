using System.ComponentModel.Design;

namespace Game
{
    internal partial class Program
    {
        static int eletkedv = 0;
        static int veralkoholszint = 0;
        static int idegallapot = 70;
        static int penz = 4000;
        static bool megtamadnak = false;
        static bool bogyok = false;
        static bool fomenu = true;
        static int fegyverek = 0;
        static bool ostor = false;
        static int tulelve = 1;
        static Random rand = new Random();
        // balint valtozoi
        static bool multimeter = false;
        static bool snussz = false;
        static void Main(string[] args)
        {
            if (foMenu() == 0)
            {
                fomenu = false;
                bool tortenesVideki = true;
                if (tortenesVideki)
                {
                    int videki_esemeny = VidekiEsemeny(200);
                    tortenesVideki = false;
                    if (videki_esemeny == 0)
                    {
                        penz -= 200;
                    }
                    else
                    {
                        megtamadnak = true;
                    }
                }
                bool tortenesKondi = true;
                bool tortenesDohi = true;
                bool tortenesAluljaro = true;
                bool tortenesEuros = true;
                do
                {
                    int videki = Videki();
                    switch (videki)
                    {
                        case 0:
                            if (tortenesKondi)
                            {
                                int kondiesemeny = KondiEsemeny(1000);
                                tortenesKondi = false;
                                if (kondiesemeny == 0)
                                {
                                    penz -= 1000;
                                    bogyok = true;
                                }

                            }
                            int kondi = Kondi();
                            break;
                        case 1:
                            if (tortenesDohi)
                            {
                                int dohiKunyeralasEsemeny = DohiKunyeralas();
                                if (dohiKunyeralasEsemeny == 0)
                                {
                                    if (rand.Next(0, 101) >= 70)
                                    {
                                        penz += 500;
                                    }
                                    else
                                    {
                                        eletkedv -= 20;
                                    }
                                }
                                tortenesDohi = false;
                            }
                            int dohiBolt;
                            do
                            {
                                dohiBolt = DohiBolt();
                                switch (dohiBolt)
                                {
                                    case 0:
                                        if (ElfogyPenz(0, 500) != 1)
                                        {
                                            idegallapot -= 20;
                                            eletkedv += 20;
                                            veralkoholszint += 20;
                                            penz -= 500;
                                        }
                                        break;
                                    case 1:
                                        if (ElfogyPenz(0, 1000) != 1)
                                        {
                                            idegallapot -= 30;
                                            penz -= 1000;
                                            eletkedv += 30;
                                        }
                                        break;
                                }
                            } while (dohiBolt != 2);
                            int dohi = Dohi();
                            break;
                        case 2:
                            if (tortenesAluljaro)
                            {
                                int aluljaroLopas = VasutLopas();
                                if (aluljaroLopas == 0)
                                {
                                    penz += 500;
                                }
                                VasutWC();
                                int pont = WcJatek();
                                if (pont >= 500)
                                {
                                    eletkedv += 40;
                                    idegallapot -= 20;
                                }
                                else
                                {
                                    eletkedv -= 20;
                                    idegallapot += 20;
                                }
                                tortenesAluljaro = false;
                            }
                            int vasut;
                            int euros = 1;
                            int jedlik = 1;

                            do
                            {
                                vasut = Vasut();
                                
                                do
                                {
                                    switch (vasut)
                                    {
                                        case 1:
                                            if (tortenesEuros)
                                            {
                                                int taliOliverrel = EurosOliver();
                                                tortenesEuros = false;
                                                if (taliOliverrel == 0 && ElfogyPenz(0, 300) != 1)
                                                {
                                                    int jatek = Jatek();
                                                    if (jatek == 0)
                                                    {
                                                        int ajandek = OliverAjandeka();
                                                        if (ajandek == 0)
                                                        {
                                                            idegallapot -= 20;
                                                            veralkoholszint += 20;
                                                        }
                                                        else
                                                        {
                                                            eletkedv += 20;
                                                        }
                                                    }
                                                    else if (jatek == 1)
                                                    {
                                                        penz -= 300;
                                                    }
                                                }
                                            }
                                            int eurosBolt;
                                            do
                                            {
                                                eurosBolt = EurosBolt();
                                                switch (eurosBolt)
                                                {
                                                    case 0:
                                                        if (ElfogyPenz(0, 350) != 1)
                                                        {
                                                            idegallapot -= 20;
                                                            veralkoholszint += 20;
                                                            penz -= 350;
                                                        }
                                                        break;
                                                    case 1:
                                                        if (ElfogyPenz(0, 300) != 1)
                                                        {
                                                            penz -= 300;
                                                            eletkedv += 20;
                                                        }
                                                        break;
                                                }
                                            } while (eurosBolt != 2);
                                            euros = Euros();
                                            break;
                                        case 2:
                                            Korhaz();
                                            jedlik = KorhazTulelve();

                                            break;
                                    }

                                } while (euros != 0 && jedlik != 0 && vasut != 0);
                            } while (vasut != 0);
                            break;
                        case 3:
                            if (megtamadnak)
                            {
                                int tamadasXXXShop = LuciferShopTamadas();
                                megtamadnak = false;
                            }

                            int XXXBolt;
                            do
                            {
                                XXXBolt = LuciferShopBolt();
                                switch (XXXBolt)
                                {
                                    case 0:
                                        if (ElfogyPenz(0, 1500) != 1)
                                        {
                                            fegyverek++;
                                            ostor = true;
                                            penz -= 1500;
                                        }
                                        break;
                                    case 1:
                                        if (ElfogyPenz(0, 1000) != 1)
                                        {
                                            penz -= 1000;
                                            eletkedv += 30;
                                        }
                                        break;
                                }
                            } while (XXXBolt != 2);
                            break;

                    }

                } while (true);
            }
        }
        public static int Menu(string szoveg, string[] valasztasok)
        {
            int valasztottIndex = 0;
            
            return programFut();
            void opciokMegjelenitese()
            {
                
                Console.WriteLine(szoveg);
                for (int i = 0; i < valasztasok.Length; i++)
                {
                    string jelenlegiPozicio = valasztasok[i];
                    if (i == valasztottIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine($"<< {jelenlegiPozicio} >>");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (fomenu == false)
                {
                    bool korhaz = statisztika();
                    if (korhaz == false)
                    {
                        eletkedv = statisztikaKiIro(eletkedv, 10, "Életkedv");
                        idegallapot = statisztikaKiIro(idegallapot, 12, "Idegállapot");
                        veralkoholszint = statisztikaKiIro(veralkoholszint, 14, "Véralkoholszint");
                        Console.WriteLine($"\nPénz: {penz}");
                        Console.WriteLine("\nTárgyaid megnézéséhez nyomd meg az: 'I' betűt");
                    }
                    if (tulelve == 0)
                    {
                        tulelve = 1;
                        Console.Clear();
                        opciokMegjelenitese();
                    }
                }
                

            }
            int programFut()
            {
                ConsoleKey lenyomottBetu;
                do
                {
                    Console.Clear();
                    opciokMegjelenitese();

                    ConsoleKeyInfo betuInfo = Console.ReadKey(true);
                    lenyomottBetu = betuInfo.Key;
                    if (lenyomottBetu == ConsoleKey.I)
                    {
                        Inventory();
                        
                    }
                    if (lenyomottBetu == ConsoleKey.UpArrow)
                    {
                        valasztottIndex--;
                        if (valasztottIndex == -1)
                        {
                            valasztottIndex = valasztasok.Length - 1;
                        }
                    }
                    else if (lenyomottBetu == ConsoleKey.DownArrow)
                    {
                        valasztottIndex++;
                        if (valasztottIndex == valasztasok.Length)
                        {
                            valasztottIndex = 0;
                        }
                    }
                } while (lenyomottBetu != ConsoleKey.Enter);
                return valasztottIndex;
            }

        }
        public static bool statisztika()
        {
            bool korhaz = false;
            if (eletkedv == 100)
            {
                idegallapot -= 50;
                eletkedv = 0;
            }
            if (idegallapot == 100 || veralkoholszint == 100)
            {
                korhaz = true;
                Console.Clear();
                Korhaz();
                tulelve = KorhazTulelve();
            }
            return korhaz;
        }
        public static int statisztikaKiIro(int value, int color, string stat)
        {
            Console.WriteLine($"\n{stat}:\n");
            if (value > 100)
            {
                value = 100;
            }
            else if (value < 0)
            {
                value = 0;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.BackgroundColor = (ConsoleColor)color;
                if (i >= (value / 5))
                {
                    Console.BackgroundColor = ConsoleColor.White;
                }
                if (i == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(value);
                    Console.ForegroundColor= ConsoleColor.White;
                }
                Console.Write(" ");
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine();
            return value;
        }
        
        public static int Inventory()
        {
            string szoveg = "Tárgyaid:";
            if (bogyok) szoveg += "\n\tBogyók";
            if (snussz) szoveg += "\n\tSnüssz";
            if (ostor) szoveg += "\n\tOstor";
            Console.WriteLine("Használható:");
            string[] valasztasok = {"Kilépés"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }


        public static int foMenu()
        {
            string szoveg = @"
     /$$$$$$$            /$$ /$$             /$$                                                                                                             /$$
    | $$__  $$          | $$|__/            | $$                                                                                                            | $$
    | $$  \ $$  /$$$$$$ | $$ /$$ /$$$$$$$  /$$$$$$                /$$$$$$   /$$$$$$  /$$   /$$             /$$$$$$$   /$$$$$$   /$$$$$$        /$$  /$$$$$$ | $$
    | $$$$$$$  |____  $$| $$| $$| $$__  $$|_  $$_/               /$$__  $$ /$$__  $$| $$  | $$            | $$__  $$ |____  $$ /$$__  $$      |__/ |____  $$| $$
    | $$__  $$  /$$$$$$$| $$| $$| $$  \ $$  | $$                | $$$$$$$$| $$  \ $$| $$  | $$            | $$  \ $$  /$$$$$$$| $$  \ $$       /$$  /$$$$$$$|__/
    | $$  \ $$ /$$__  $$| $$| $$| $$  | $$  | $$ /$$            | $$_____/| $$  | $$| $$  | $$            | $$  | $$ /$$__  $$| $$  | $$      | $$ /$$__  $$    
    | $$$$$$$/|  $$$$$$$| $$| $$| $$  | $$  |  $$$$/            |  $$$$$$$|  $$$$$$$|  $$$$$$$            | $$  | $$|  $$$$$$$| $$$$$$$/      | $$|  $$$$$$$ /$$
    |_______/  \_______/|__/|__/|__/  |__/   \___/               \_______/ \____  $$ \____  $$            |__/  |__/ \_______/| $$____/       | $$ \_______/|__/
                                                                           /$$  \ $$ /$$  | $$                                | $$       /$$  | $$              
                                                                          |  $$$$$$/|  $$$$$$/                                | $$      |  $$$$$$/              
                                                                           \______/  \______/                                 |__/       \______/               
            ";

            string[] valasztasok = { "Játékhoz Nyomj Entert!" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

    }
}