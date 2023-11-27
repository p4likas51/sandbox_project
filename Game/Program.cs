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
            if (foMenu() == 0)
            {
                bool balinthaztortenes = true;
                if (balinthaztortenes)
                {
                int balinthazesemeny = BalinthazEsemeny();
                    balinthaztortenes = false;
                    if (balinthazesemeny == 0)
                    {
                        eletkedv += 20;
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
                            int makviragkocsma = Makviragkocsma();
                            if (makviragkocsma == 0)
                            {
                                int viragagyas = Viragagyas();
                            }
                            else if (makviragkocsma == 1)
                            {
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