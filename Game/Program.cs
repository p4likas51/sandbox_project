namespace Game
{
    internal partial class Program
    {
        static int eletkedv = 70;
        static int veralkoholszint = 0;
        static int idegallapot = 0;
        static int penz = 2000;
        static void Main(string[] args)
        {
            Random random = new Random();
            if (foMenu() == 0)
            {
                bool balinthaztortenes = true;
                if (balinthaztortenes)
                {
                int balinthazesemeny = BalinthazEsemeny();
                    balinthaztortenes = false;
                    if (balinthazesemeny == 0)
                    {
                        eletkedv += 5;
                        Console.WriteLine("Jót aludtál és nagyjából működik");
                    }                    
                }
                do
                {

                    int balinthaz = Balinthaz();
                    if (balinthaz == 0)
                    {                        
                        bool kocsma;
                        do
                        {                            
                            kocsma = true;
                            bool kocsmatortenes = true;
                            if (kocsmatortenes)
                            {
                                int kocsmaesemeny = MakviragkocsmaEsemeny();
                                kocsmatortenes = false;
                                while (kocsmaesemeny == 0)
                                {
                                    veralkoholszint += 10;
                                    eletkedv += 5;
                                    penz -= 50;
                                    kocsmaesemeny = MakviragkocsmaEsemeny();
                                }
                                if (kocsmaesemeny == 2)
                                {
                                    if (random.Next(1, 3) == 1)
                                    {
                                        eletkedv += 50;
                                        Console.WriteLine("Beszélgettél az egyik helyi erővel, aki régi afgán veterán történeteket hablatyolt össze. Mivel tetszett, amit mondott így kicsit jobban érzed magad.  \nTováb a folytatáshoz");
                                        Console.ReadLine();
                                    }
                                    else if (random.Next(1, 3) == 2)
                                    {
                                        idegallapot += 50;
                                        Console.WriteLine("Egyik részeg afgán veterán(Imre bá)nak nem tetszett a pofád és megfenyegetett, hogy gyomron rúg. Bevettette arab háborús taktikáját de nem járt sikerrel így csak mentálisan épített le.  \nTováb a folytatáshoz");
                                        Console.ReadLine();
                                    }
                                    else if (random.Next(1, 100) < 5)
                                    {
                                        Console.WriteLine("Imre bá felismer téged és rég tett fogadalmát beváltja. Erőszakosan rádtámad és te magatehetetlen vagy. Afgán veterán háborús taktikája ellen nem tudod felvenni a versenyt és bár küzdöttél végül alulmaradtál. ");
                                    }

                                }
                            }
                            int makviragkocsma = Makviragkocsma();
                            if (makviragkocsma == 0)
                            {
                                bool viragagyastortenes = true;
                                if (viragagyastortenes)
                                {

                                    int viragagyasesemeny = ViragagyasEsemeny();
                                    viragagyastortenes = false;
                                    if (viragagyasesemeny == 0)
                                    {
                                        if (veralkoholszint < 50)
                                        {
                                            veralkoholszint += 0;
                                        }
                                        else
                                        {
                                        veralkoholszint -= 50;
                                            
                                        }
                                    }
                                }
                                int viragagyas = Viragagyas();
                            }
                            else if (makviragkocsma == 1)
                            {
                                bool wctortenes = true;
                                if (wctortenes)
                                {
                                    int wcesemeny = WCEsemeny();
                                    wctortenes = false;
                                    if (wcesemeny == 0)
                                    {
                                        eletkedv += 5;
                                    }
                                    else if (wcesemeny == 1)
                                    {
                                        veralkoholszint = 0;
                                    }
                                }
                                    int wc = WC();
                            }
                            else if (makviragkocsma == 2)
                            {
                                int dunaszeg = Dunaszeg();
                            }
                            else
                            {
                                kocsma = false;
                            }
                        } while (kocsma);
                        
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
                if (valasztasok.Length > 1)
                {
                    Console.Write($"\nÉletkedv: {eletkedv}\nIdegállapot: {idegallapot}\nVéralkoholszint: {veralkoholszint}\nPénz: {penz}");
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