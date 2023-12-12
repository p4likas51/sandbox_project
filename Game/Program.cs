namespace Game
{
    internal partial class Program
    {
        static int eletkedv = 70;
        static int veralkoholszint = 0;
        static int idegallapot = 0;
        static int penz = 2000;
        static bool vegyestuzelesukazanhofokmeropalca = false;
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
                bool dunaszegtortenes = true;
                do
                {

                    int balinthaz = Balinthaz();
                    if (balinthaz == 0)
                    {
                        bool kocsma;
                        bool kocsmatortenes = true;
                        do
                        {
                            kocsma = true;
                            if (kocsmatortenes)
                            {
                                int kocsmaesemeny = MakviragkocsmaEsemeny();


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
                                    else if (random.Next(1, 100) <= 5)
                                    {
                                        Console.WriteLine("Imre bá felismer téged és rég tett fogadalmát beváltja. Erőszakosan rádtámad és te magatehetetlen vagy. Afgán veterán háborús taktikája ellen nem tudod felvenni a versenyt és bár küzdöttél végül alulmaradtál. ");
                                        Environment.Exit(0);
                                    }

                                }
                            }
                            kocsmatortenes = false;
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
                                        if (veralkoholszint > 50)
                                        {
                                            Console.WriteLine("A nagy ivászat után aludtál egy jót így a májad kicsit megnyugodott");
                                            Console.ReadLine();
                                            veralkoholszint = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Picikét aludtál");
                                            Console.ReadLine();
                                            veralkoholszint -= 10;
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
                                        Console.WriteLine("A sötétben egy rabdom emberrel kardoztál és elég jó volt. Így kicsit vidámabban fogod elhagyni a budit.");
                                        eletkedv += 5;
                                    }
                                    else if (wcesemeny == 1)
                                    {
                                        Console.WriteLine("Nem bírtad tovább és hánytál egyett. Ezért megkönnyebültebben távolzol a helységből");
                                        Console.ReadLine();
                                        veralkoholszint -= 15;
                                    }
                                }
                                int wc = WC();
                            }
                            else if (makviragkocsma == 2)
                            {
                                kocsmatortenes = true;
                                if (random.Next(1, 101) >= 35)
                                {
                                    if (dunaszegtortenes)
                                    {
                                        int dunaszegesemeny = DunaszegEsemeny();
                                        dunaszegtortenes = false;
                                        if (dunaszegesemeny == 0)
                                        {
                                            idegallapot += 15;

                                            Console.WriteLine("Harcban vagy");
                                            string text = ".......";
                                            int delay = 300;
                                            foreach (char c in text)
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(delay);
                                            }
                                            Console.WriteLine("Azt választottad, hogy szembe szállsz a gúnár hadsereggel, azonban fizikai felépítésed miatt a csatában alulmaradtál. Tudván a tények állását kisebb idegbaj tört rád.");
                                            Console.ReadLine();

                                        }
                                        else if (dunaszegesemeny == 1)
                                        {
                                            eletkedv -= 15;
                                            Console.WriteLine("Úgy gondoltad, hogy most nem alkalmas csatába szállni ezért felkötötted a nyúlcipődet. Lelkileg ez annyira megviselt, hogy majdnem szívbajt kaptál. Az életkedved is csökkent te gyász.");
                                            Console.ReadLine();
                                        }
                                    }
                                    kocsmatortenes = true;

                                    int dunaszeg = Dunaszeg();
                                    if (dunaszeg == 0)
                                    {
                                        bool sufnitortenes = true;
                                        if (sufnitortenes)
                                        {
                                            int sufniesemeny = FazakassufniEsemeny();
                                            sufnitortenes = false;
                                            if (sufniesemeny == 0)
                                            {
                                                Console.WriteLine("Gyors reagálásúként felvetted az első dolgot a földről, ami a kezedbe került (kazánhőfokmérő). És voltál olyan ügyes, hogy még kiléted lebukása előtt el tudtad hagyni a helyszínt. Fazakas Tanár Úrt nem zavarta ez a különös eset.");
                                                vegyestuzelesukazanhofokmeropalca = true;
                                            }
                                            else if (sufniesemeny == 1)
                                            {
                                                Console.WriteLine("Esztelen menekülés");
                                                string text = ".......";
                                                int delay = 600;
                                                foreach (char c in text)
                                                {
                                                    Console.Write(c);
                                                    Thread.Sleep(delay);
                                                }
                                                Console.WriteLine("200-as vérnyomással kirontottál a fészerből és a kukoricafölden keresztül menekülve valahogy kijutottál a szorult helyzetből. Ezért visszatérsz Dunaszeg szívébe.");
                                                Console.ReadLine();
                                                idegallapot += 15;
                                            }
                                            else if (sufniesemeny == 2)
                                            {
                                                Console.WriteLine("Pontos okát nem tudni de a bizonytalan döntéshozás közben tragikus gyorsasággal hagytad itt a bolygót. Szemtanúk szerint nagy fények voltak, a hatóságok azóta sem találtak meg");
                                                Console.ReadLine();
                                                Environment.Exit(0);
                                            }
                                        }

                                        int fazakassufni = Fazakassufni();
                                    }
                                    else if (dunaszeg == 1)
                                    {
                                        Console.WriteLine("Szerencsére gond nélkül eljutottál a zámyolyi buszmegállóba.");
                                        Console.ReadLine();
                                        int gyorzamolybuszmeg = Gyorzamolyibuszmeg();
                                    }
                                }

                            }
                            else
                            {
                                kocsma = false;
                            }
                        } while (kocsma);

                    }
                    else if (balinthaz == 1)
                    {
                        Console.WriteLine("Random nyuggerek mint MINDIG a megállóban kiengedték világfájdalmukat és el kezdtek beszólogatni. Nem bírtad magadat tűrtöztenip és egy kisebb migrént kaptál.");
                        Console.ReadLine();
                        idegallapot = 30;

                        int gyorzamolybuszmeg = Gyorzamolyibuszmeg();
                        if (gyorzamolybuszmeg == 0)
                        {
                            if (random.Next(1, 3) == 2)
                            {
                                int buszmegesemeny = GyorzamolyibuszmegEsemeny();
                                if (buszmegesemeny == 0)
                                {
                                    if (random.Next(1, 3) == 1)
                                    {
                                        eletkedv += 10;
                                        Console.WriteLine("Szép utad volt");
                                    }
                                    else
                                    {
                                        idegallapot += 10;
                                        Console.WriteLine("Elestél");
                                    }

                                }
                            }
                            // videki
                        }
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