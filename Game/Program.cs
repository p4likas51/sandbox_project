namespace Game
{
    internal partial class Program
    {
        static int eletkedv = 70;
        static int veralkoholszint = 0;
        static int idegallapot = 0;
        static int penz = 2000;
        static bool megtamadnak = false;
        static bool bogyok = false;
        static bool fomenu = true;
        static void Main(string[] args)
        {
            Random rand = new Random();
            if (foMenu() == 0)
            {
                fomenu = false;
                bool tortenesVideki = true;
                if (tortenesVideki)
                {
                    int videki_esemeny = VidekiEsemeny();
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
                do
                {
                    int videki = Videki();
                    switch (videki)
                    {
                        case 0:
                            if (tortenesKondi)
                            {
                                int kondiesemeny = KondiEsemeny();
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
                                        idegallapot -= 20;
                                        eletkedv += 20;
                                        veralkoholszint += 20;
                                        penz -= 500;
                                        break;
                                    case 1:
                                        idegallapot -= 30;
                                        penz -= 1000;
                                        eletkedv += 30;
                                        break;
                                }
                            } while (dohiBolt != 2);
                            int dohi = Dohi();
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
                    statisztikak(eletkedv, 10, "Életkedv");
                    statisztikak(idegallapot, 12, "Idegállapot");
                    statisztikak(veralkoholszint, 14, "Véralkoholszint");
                    Console.WriteLine($"\nPénz: {penz}");
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
        public static void statisztikak(int value, int color, string stat)
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