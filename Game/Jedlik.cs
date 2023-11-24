using System;
using System.Collections.Generic;
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
            string szoveg = ("Jelenlegi helyzet: Jedlik bejárata");
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 2);
            if (randomNumber == 0)
            {
                Console.WriteLine("Találkozol a biztonsági őrrel aki megdorogál a cigiszagod miatt");
                idegallapot += 5;
                randomNumber = randomEvent.Next(0, 101);
                if (randomNumber <= 15)
                {
                    Console.WriteLine("Biztiboy megmotoz téged és minden fegyveredet elveszi");
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
            string szoveg = ("Jelenlegi helyzet: Fazakas Miklós matekterme");
            if (true) //Majd a vidéki sufnitól fogg függeni
            {
                Console.WriteLine("Fazakas Miklós mérges mert elfutottál. Látni sem akar ezért kiküld óráról.");
                eletkedv += 5;
            }
            else
            {
                Console.WriteLine("Kínok között de nagy nehezen sikerült átvészelni az óráját.");
                eletkedv -= 5;
            }
            string[] valasztasok = { "Folyosó" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Vinczeterem()
        {
            string szoveg = ("Jelenlegi helyzet: PLC terem Vincze Flórián társaságában");
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if (randomNumber <= 25)
            {
                Console.WriteLine("Vincze Flórián úgy dönt hogy ma nem akar izmozni elmarad a tanóra.");
            }
            else
            {
                int palitolLopottIndex = 0;
                string[] igenVagyNem = { "Elbeszélgetsz Vincze Flóriánnal", "Nem akarod cseszegetni ezért csöndben maradsz" };
                palitolLopottFunction();
                if (palitolLopottIndex == 0)
                {
                    Console.WriteLine("Vincze Flórián elmondja hogy a B épületben a mai nap nem működnek a kamerák - támadt egy csalafinta ötleted.");
                    // 100%-ra változtatja a multiméter lopás esélyét
                }
                if (palitolLopottIndex == 1)
                {
                    Console.WriteLine("Megvolt a chilles kis óra csak a szokásos.");
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
            bool voltAmmonia = false;
            string szoveg = ("Jelenlegi helyzet: A Híres C# terem minden pompájában");
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 2);
            if (randomNumber == 0 && voltAmmonia == false)
            {
                Console.WriteLine("Ahogyan a terem közelébe érsz érzed ahogyan a tudőt megtelik ammónigázzal és megszédülsz. A nap folyamán gyengébnek fogod magad érezni.");
                voltAmmonia = true;
                //kihatással lesz az endgame fightra
                Console.WriteLine("Kis híján de túlélted a progot érvágás nélkül.");
            }
            else
            {
                Console.WriteLine("Kis híján de túlélted a progot érvágás nélkül.");
            }
            string[] valasztasok = { "Folyosó", "Padlás" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        static void cPadlas() 
        {
            bool voltTömő = false;
            Console.WriteLine("Jelenlegi helyzet: Az átkozott padlás öltöző a 41-es terem fölött.");
            if (voltTömő == false)
            {
                Console.WriteLine("Találtál egy kósza tömőt. Nem tudod hogy honnan van és milyen de a biztonság kedvéért elrakod.");
                //inventoryba megy
                voltTömő = true;
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
            string szoveg = ("Jelenlegi helyzet: Folyosó");
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if (randomNumber <= 20)
            {
                Console.WriteLine("Találtál aprót elhajítva a földön. Elég hanyag volt előző gazdája, te sokkal jobban bánsz majd vele.");
                //pénz ++
            }
            else
            {
                Console.WriteLine("Majdnem infarktust kapsz mikor a folyón megpillantod Fortuna Edinát. Megközelít és kéjen rádmosolyog kapa fogaival");
                eletkedv -= 5;
                idegallapot += 5;
            }
            string[] valasztasok = { "Büfé", "Jedlik wéce", "B épület átjáró" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
    }
}

