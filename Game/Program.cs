namespace Game
{
    internal partial class Program
    {
        static int eletkedv = 70;
        static int veralkoholszint = 0;
        static int idegallapot = 0;
        static int penz = 2000;
        static int multiMeterChance = 50;
        static bool voltOltozes = false;
        static bool voltTömő = false;
        static bool voltAmmonia = false;
        static bool voltOra = false;
        static bool ennyitTerveztemMára = false;
        static bool AnnyiraNemAkarom = false;
        static bool Vanigazolás = false;

        static void Main(string[] args)
        {
            if (foMenu() == 0)
            {
                int indexBejarat = JedlikBejarat();
                switch (indexBejarat)
                {
                    case 0:
                        FazakasTerem();
                        break;
                    case 1:
                        Vinczeterem();
                        break;
                    case 2:
                        int nemtudom = CTerem();
                        if (nemtudom == 1)
                        {
                            cPadlas();
                        }
                        break;
                }
                int dokument = Folyoso();
                switch (dokument)
                {
                    case 0:
                        Bufe();
                        break; 
                    case 1:
                        int querySelector = JedlikWC();
                        if (querySelector == 0)
                        {
                            Bufe();
                        }
                        break;
                    case 2:
                        break;
                    case 3:
                        Nővérke();
                        break;
                }
                if (Vanigazolás ==true)
                {
                    JedlikKijarat();
                }
                else
                {
                    int dokumentPont = BFolyoso();
                    switch (dokumentPont)
                    {
                        case 0:
                            int námbör_sziksz = TesiOltozo();
                            if (námbör_sziksz == 0)
                            {
                                int guh = TesiTerem();
                                if (guh == 0)
                                {
                                    JedlikKijarat();
                                }
                                else
                                {
                                    int nem2 = SZGTerem();
                                    if (nem2 == 0)
                                    {
                                        JedlikKijarat();
                                    }
                                    else
                                    {
                                        TesiOltozo();
                                    }
                                }
                            }
                            else
                            {
                                int nem1 = SZGTerem();
                                if (nem1 == 0)
                                {
                                    JedlikKijarat();
                                }
                                else
                                {
                                    int námbör_sziksz1 = TesiOltozo();
                                    if (námbör_sziksz1 == 0)
                                    {
                                        int guh1 = TesiTerem();
                                        if (guh1 == 0)
                                        {
                                            JedlikKijarat();
                                        }
                                        else
                                        {
                                            int nem2 = SZGTerem();
                                            if (nem2 == 0)
                                            {
                                                JedlikKijarat();
                                            }
                                            else
                                            {
                                                TesiOltozo();
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        case 1:
                            int nem = SZGTerem();
                            if (nem == 0)
                            {
                                JedlikKijarat();
                            }
                            else
                            {
                                int námbör_sziksz3 = TesiOltozo();
                                if (námbör_sziksz3 == 0)
                                {
                                    int guh3 = TesiTerem();
                                    if (guh3 == 0)
                                    {
                                        JedlikKijarat();
                                    }
                                    else
                                    {
                                        int nem3 = SZGTerem();
                                        if (nem3 == 0)
                                        {
                                            JedlikKijarat();
                                        }
                                        else
                                        {
                                            TesiOltozo();
                                        }
                                    }
                                }
                            }
                            break;
                    }
                    //Vasútállomás függvény
                }
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