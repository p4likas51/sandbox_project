using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        public static int JedlikBejarat()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Jedlik bejárata");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 2);
            if (randomNumber == 0)
            {
                Console.WriteLine("\nTalálkozol a biztonsági őrrel aki megdorogál a cigiszagod miatt");
                Console.ReadKey();
                idegallapot += 5;
                randomNumber = randomEvent.Next(0, 101);
                if (randomNumber <= 15)
                {
                    Console.WriteLine("\nBiztiboy megmotoz téged és minden fegyveredet elveszi");
                    Console.ReadKey();
                    //fegyverek elvesztése
                }
            }
            else
            {

            }
            string[] valasztasok = { "Fazakas terem", "Vincze Flórián terem", "C# terem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int FazakasTerem()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Fazakas Miklós matekterme");
            Console.WriteLine(szoveg);
            if (true) //Majd a vidéki sufnitól fogg függeni
            {
                Console.WriteLine("\nFazakas Miklós mérges mert elfutottál. Látni sem akar ezért kiküld óráról.");
                eletkedv += 5;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nKínok között de nagy nehezen sikerült átvészelni az óráját.");
                eletkedv -= 5;
                Console.ReadKey();
            }
            string[] valasztasok = { "Folyosó" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Vinczeterem()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: PLC terem Vincze Flórián társaságában");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if (randomNumber <= 25)
            {
                Console.WriteLine("\nVincze Flórián úgy dönt hogy ma nem akar izmozni elmarad a tanóra.");
                Console.ReadKey();
            }
            else
            {
                int palitolLopottIndex = 0;
                string[] igenVagyNem = { "Elbeszélgetsz Vincze Flóriánnal", "Nem akarod cseszegetni ezért csöndben maradsz" };
                palitolLopottFunction();
                if (palitolLopottIndex == 0)
                {
                    Console.WriteLine("\nVincze Flórián elmondja hogy a B épületben a mai nap nem működnek a kamerák - támadt egy csalafinta ötleted.");
                    Console.ReadKey();
                    // 100%-ra változtatja a multiméter lopás esélyét
                }
                if (palitolLopottIndex == 1)
                {
                    Console.WriteLine("\nMegvolt a chilles kis óra csak a szokásos.");
                    Console.ReadKey();
                }
                void valaszthatoEsemeny()
                {
                    Console.WriteLine(szoveg);
                    for (int i = 0; i < igenVagyNem.Length; i++)
                    {
                        string jelenlegiPozicio = igenVagyNem[i];
                        if (i == palitolLopottIndex)
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
                }
                int palitolLopottFunction()
                {
                    ConsoleKey lenyomottBetu;
                    do
                    {
                        Console.Clear();
                        valaszthatoEsemeny();

                        ConsoleKeyInfo betuInfo = Console.ReadKey(true);
                        lenyomottBetu = betuInfo.Key;
                        if (lenyomottBetu == ConsoleKey.UpArrow)
                        {
                            palitolLopottIndex--;
                            if (palitolLopottIndex == -1)
                            {
                                palitolLopottIndex = igenVagyNem.Length - 1;
                            }
                        }
                        else if (lenyomottBetu == ConsoleKey.DownArrow)
                        {
                            palitolLopottIndex++;
                            if (palitolLopottIndex == igenVagyNem.Length)
                            {
                                palitolLopottIndex = 0;
                            }
                        }
                    } while (lenyomottBetu != ConsoleKey.Enter);
                    return palitolLopottIndex;
                }
            }
            string[] valasztasok = { "Folyosó" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int CTerem()
        {
            Console.Clear();
            bool voltAmmonia = false;
            bool voltOra = false;
            string szoveg = ("\nJelenlegi helyzet: A Híres C# terem minden pompájában");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 2);
            if (randomNumber == 0 && voltAmmonia == false && voltOra == false)
            {
                Console.WriteLine("\nAhogyan a terem közelébe érsz érzed ahogyan a tudőt megtelik ammónigázzal és megszédülsz. A nap folyamán gyengébnek fogod magad érezni.");
                Console.ReadKey();
                voltAmmonia = true;
                //kihatással lesz az endgame fightra
                Console.WriteLine("\nKis híján de túlélted a progot érvágás nélkül.");
                voltOra = true;
                Console.ReadKey();
            }
            else if (voltOra == false)
            {
                Console.WriteLine("\nKis híján de túlélted a progot érvágás nélkül.");
                voltOra = true;
                Console.ReadKey();
            }
            else
            {
                Folyoso();
            }
            string[] valasztasok = { "Folyosó", "Padlás" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        static void cPadlas() 
        {
            Console.Clear();
            bool voltTömő = false;
            string szoveg = ("\nJelenlegi helyzet: Az átkozott padlás öltöző a 41-es terem fölött.");
            Console.WriteLine(szoveg);
            if (voltTömő == false)
            {
                Console.WriteLine("\nTaláltál egy kósza tömőt. Nem tudod hogy honnan van és milyen de a biztonság kedvéért elrakod.");
                Console.ReadKey();
                //inventoryba megy
                voltTömő = true;
                CTerem();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("<< C#terem >>");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                CTerem();
            }

        }
        public static int Folyoso()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Folyosó");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if (randomNumber <= 20)
            {
                Console.WriteLine("\nTaláltál aprót elhajítva a földön. Elég hanyag volt előző gazdája, te sokkal jobban bánsz majd vele.");
                Console.ReadKey();
                //pénz ++
            }
            else
            {
                Console.WriteLine("\nMajdnem infarktust kapsz mikor a folyosón megpillantod Fortuna Edinát. Megközelít és kéjen rádmosolyog kapa fogaival");
                Console.ReadKey();
                eletkedv -= 5;
                idegallapot += 5;
            }
            string[] valasztasok = { "Büfé", "Jedlik wéce", "B épület átjáró" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
    }
}

