using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
                    vegyestuzelesukazanhofokmeropalca = false;
                    ostor = false;
                    snussz = false;
                    multimeter = false;
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
            if (vegyestuzelesukazanhofokmeropalca == true)
            {
                Console.WriteLine("\nKínok között de nagy nehezen sikerült átvészelni az óráját.");
                eletkedv -= 5;
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nFazakas Miklós mérges mert elfutottál. Látni sem akar ezért kiküld óráról.");
                eletkedv += 5;
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
                    multiMeterChance = 100;
                    Console.ReadKey();
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
            string szoveg = ("\nJelenlegi helyzet: Az átkozott padlás öltöző a 41-es terem fölött.");
            Console.WriteLine(szoveg);
            if (voltTömő == false)
            {
                Console.WriteLine("\nTaláltál egy kósza tömőt. Nem tudod hogy honnan van és milyen de a biztonság kedvéért elrakod.");
                Console.ReadKey();
                snussz = true;
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
                penz += 500;
            }
            else
            {
                Console.WriteLine("\nMajdnem infarktust kapsz mikor a folyosón megpillantod Fortuna Edinát. Megközelít és kéjen rádmosolyog kapa fogaival");
                Console.ReadKey();
                eletkedv -= 5;
                idegallapot += 5;
            }
            string[] valasztasok = { "Büfé", "Jedlik wéce", "B épület átjáró", "Nővérke" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int Bufe()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Büfé");
            Console.WriteLine(szoveg);           
            if (bogyok == true && voltálmáritt == false) //talán lesz good-bad beszélgetés opció nagyon nem akarom megcsinálni
            {
                Console.WriteLine("Megközelíted a büfé létesítményét célod az egyértelmű. A SZÖKÉS (meg egy kis extra)");
                Console.WriteLine("Megközelíted a büfés csajt, most döl el hogy siker lesz-e vagy bukás.");
                Console.ReadLine();
                Console.WriteLine("Hosszas beszélgetés után számos mély témáról, elérsz a lényegre - elkéred a telefonszámát és ő boldogan odaadja neked." +
                    "\nEzután szépen megkéred hogy engedjen ki a büfé hátulján keresztül. Biztonság kedvéért elkezded feszegetni magadat" +
                    "\nTermészetesen miután a kiinduló kapcsolat alapja le lett helyezve segítségedre fordul.");
                Console.ReadLine();
                eletkedv += 25;
                idegallapot -= 10;
                voltálmáritt = true;
                return 1;
            }
            else if (voltálmáritt == true)
            {
                Console.WriteLine("Ahogyan elkezded a büfé felé venni az irányodat, belegondolsz hogy előzőleg mi történt és inkább sarkon fordulsz");
                Console.ReadLine();
                return 3;
            }
            else if (voltálmáritt == false)
            {
                Console.WriteLine("Megközelíted a büfé létesítményét célod az egyértelmű. A SZÖKÉS (meg egy kis extra)");
                Console.WriteLine("Megközelíted a büfés csajt, most döl el hogy siker lesz-e vagy bukás.");
                Console.ReadLine();
                Console.WriteLine("Hiába erölteted a beszélgetést de az nem halad sehova sem, és kínos csönd áll be." +
                "\nMindennek ellenére azért rápróbálsz hogy esetlegesen kienged-e ebből az átkozott épületből");
                Console.WriteLine("Kérésed hallatán hangosan kiröhög és megjegyzi hogy ilyen testalkattal ki se férnél a hátsóajtón majd elhajt.");
                eletkedv -= 25;
                idegallapot += 10;
                Console.ReadLine();
                voltálmáritt = true;
                return 2;
            }
            return 3;


        }
        public static int JedlikWC()
        {
            string choice;
            int Value;
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Jedlik WC");
            Console.WriteLine(szoveg);
            do
            {
                Console.WriteLine("Beléptél a földi pokolba ahol minden fajta nemi betegség megtalálható - a jedlik véce- mit teszel? " +
                    "\n1.Hotbox " +
                    "\n2.Elengeded a hugyhólyagodat aztán jólvanazúgy");
                choice = Console.ReadLine();
                int.TryParse(choice, out int value);
                Value = value;
            } while (Value != 1 && Value != 2);

            if (Value == 1)
            {
                Console.WriteLine("Tiszta élvezettel telefújtad az egész budoir helységét rákkeltő füsttel és kielégítve érzed magad.");
                Console.ReadLine();
                eletkedv += 5;
                Random randomEvent = new Random();
                int randomNumber = randomEvent.Next(0, 101);
                if (randomNumber <= 40)
                {
                    Console.WriteLine("Tündike éppen a bagarellózásod közben jött be kéjkedni a férfi mellékhelységbe. Házirend szegésedet jelentette a hologramm igazgatónak aki kiküld az iskolából");
                    Console.ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Úgy döntöttél hogy a házirendet betartó talpnyaló leszel és a WC-t arra használod amire kitalálták. Egy kifejezetten jót hugyoztál");
                Console.ReadLine();
                idegallapot -= 5;
            }
            string[] valasztasok = { "Büfé", "B épület átjáró" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int BFolyoso() 
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: B épület-hez hátsó kapu");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if (randomNumber <= 40)
            {
                Console.WriteLine("Ahogyan elkezdesz közeledni az önműködő pokolkapu felé már távolról látod hogy itt valami sántít. Itt bizony megint nincs nyitva a hátsó kapu." +
                    "\nRájössz hogy most meg kell kerülnöd a fél világot és kis híján agygörcsöt kapsz");
                Console.ReadLine();
                idegallapot += 5;
            }
            else
            {
                Console.WriteLine("Az iskola vezetőségének sikerült megnyomnia a varázsgombot és ki tudott engedni a kapun.");
                Console.ReadLine();
            }
            string[] valasztasok = { "Tesi öltöző", "Szűcs Gábor terem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int Nővérke()
        {
            string choice;
            int Value;
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Az iskolai orvosi igazolás adására felhatalmazott személy tanyája" +
                "\nMegpróbálhatsz kijutni ebből a fosból az igazolásával de akkor sok contentből kimaradsz.");
            Console.WriteLine(szoveg);
            Console.ReadLine();
            do
            {
                Console.WriteLine("Mi a következő cselekedeted? " +
                    "\n1.Bemész igazolásért " +
                    "\n2.Inkább végigszenveded a napot hátha találsz még valamit");
                choice = Console.ReadLine();
                int.TryParse(choice, out int value);
                Value = value;
            } while (Value != 1 && Value != 2);
            if (Value == 1 && AnnyiraNemAkarom == false)
            {
                Console.WriteLine("");
                Console.ReadLine();
                eletkedv += 5;
                Random randomEvent = new Random();
                int randomNumber = randomEvent.Next(0, 101);
                if (randomNumber <= 70)
                {
                    Console.WriteLine("A nővérke már akkor mosolyog mikor meglátja hogy már megint te vagy és pontosan tudja mi a célod." +
                        "\nTeljes átéléssel eljátszod a hattyúk halálát ami meghatja és hazaküld");
                    kiszokes = true;
                    Console.ReadLine();
                    return 0;
                }
                else
                {
                    Console.WriteLine("Hiába esedezel elötte térdre rogyva, ő úgy döntött hogy ma bizony meg kell bírkoznod az akadájokkal ebben a szutykos épületben");
                    string[] valasztasok = { "Folyosó" };
                    int valasztottIndex = Menu(szoveg, valasztasok);
                    return valasztottIndex;
                }
            }
            else if (AnnyiraNemAkarom == false)
            {
                Console.WriteLine("Hosszú gondolkozás után a jobbik feled nyeri a fejedben a vitát és úgy döntesz hogy már azért már a ló nemiszervének is van vége és isten legerősebb katonájaként megpróbálod átvészelni a napot");
                string[] valasztasok = { "Folyosó" };
                int valasztottIndex = Menu(szoveg, valasztasok);
                return valasztottIndex;
            }
            else
            {
                Console.WriteLine("Már ahogyan kezded másodjára megközelíteni a védőnő irodáját, távolról elkerget a világ másik végére pofátlanságod miatt");
                return 0;
            }
        }
        public static int TesiOltozo() 
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Testnevelés öltöző");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if(randomNumber <=50 && voltOltozes == false)
            {
                Console.WriteLine("Benjámin megdícséri hogy igazán jól esik neki a gyatádon keresztül látszódó férfiasságod. Ez örömmel tölt el");
                Console.ReadLine();
                voltOltozes = true;
                eletkedv += 5;
                string[] valasztasok = { "Tesi terem", "Szűcs Gábor terem" };
                int valasztottIndex = Menu(szoveg, valasztasok);
                return valasztottIndex;
            }
            else if(randomNumber >=50 && voltOltozes == false)
            {
                Console.WriteLine("Hallod ahogy Olivér az öltöző másik feléből kijelenti álláspontját miszerint az elektromos roller a király." +
                    "\nEnnek hallatán hirtelen lyukat tudnál ütni a falba");
                Console.ReadLine();
                voltOltozes = true;
                eletkedv -= 5;
                string[] valasztasok = { "Tesi terem", "Szűcs Gábor terem" };
                int valasztottIndex = Menu(szoveg, valasztasok);
                return valasztottIndex;
            }
            else
            {
                Console.WriteLine("Ismét a tesi öltözőbe találod magadat és hirtelem megszólal egy hang a jobb füledből." +
                    "\n'Mi a faszért akarsz megint bemenni oda hát megőrültél?'" +
                    "\nElsötétedik a világ és hirtelen kint vagy a Jedlikből");
                Console.ReadLine();
                return JedlikKijarat();
            }

        }
        public static int TesiTerem()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: Testnevelés öltöző");
            Console.WriteLine(szoveg);
            string choice;
            int Value;
            int Roplabda = 0;
            do
            {
                Console.WriteLine("Ahogyan elsuhansz a ping-pong asztalok mellett megpillantod Németh Ádám-ot és a hatalmas bicepszeit. Zavartságodban gondolkozol hogy mi tévő legyél." +
                    "\n1.Megdícséred a cipőjét" +
                    "\n2.Elpirulsz hatalmas ágyúi láttán és csöndben maradsz");
                choice = Console.ReadLine();
                int.TryParse(choice, out int value);
                Value = value;
            } while (Value != 1 && Value != 2);
            if (Value == 1)
            {
                Console.WriteLine("Németh Ádám nagyon hálás dicséreted hallatán és viszonozza a kedves szavakat.");
                Console.ReadLine();
                eletkedv += 5;
                Roplabda -= 1;
            }
            else
            {
                Roplabda += 1;
            }
            Console.WriteLine("Ahogyan belépsz a terembe meglátod a borzasztó röplabda hálókat. Már tudod mi következik" +
                "\nNagyra táguló bociszemekkel kérleled Németh Ádámot hogy had engedje el ezt most így." +
                "\nA tanárúr mélyen gondolkodásba esik");
            Console.ReadLine();
            if (Roplabda == -1)
            {
                Console.WriteLine("Először kételkedsz sikeredben, de mivel megdícsérted a lépőjét kegyelmes veled szemben");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Hosszú gondolkodás után úgy dönt hogy jóból is megárt a sok és ma bármi is történjék izmozni kell.");
                Console.ReadLine();
                idegallapot += 5;
            }
            string[] valasztasok = { "Hazamész a picsába", "Szűcs Gábor terem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int SZGTerem()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: B7 Szűcs Gábor társaságában");
            Console.WriteLine(szoveg);
            Random randomEvent = new Random();
            int randomNumber = randomEvent.Next(0, 101);
            if (randomNumber <= 15) 
            {
                Console.WriteLine("A tanárúr bejött a terembe de mivel ennyit tervezett mára ezzel a lendülettel ki is ment. Így könnyedén le tudod nyúlni az értékes elektronikai eszközt a teremből");
                multimeter = true;
                Console.ReadLine();
            }
            else
            {
                string choice;
                int Value;
                do
                {
                    Console.WriteLine("Mihejst belépsz a terembe szemrevételezed a sok elektronikai eszközt ami a teremben található." +
                        "\n eszedbe jut hogy a mai nap nem működnke a kamerák, egy döntés áll elébe." +
                        "\n1.Megpróbálod ellponi a multimétert." +
                        "\n2.Inkább tanulmányozod a Karnough-táblát");
                    choice = Console.ReadLine();
                    int.TryParse(choice, out int value);
                    Value = value;
                } while (Value != 1 && Value != 2);
                if (multiMeterChance == 100 && Value == 1 && ennyitTerveztemMára == false)
                {
                    Console.WriteLine("Könnyedén elrakod a multimétert és teljes nyugodtsággodat megőrzöd annak tudatában hogy nincs bizonyíték.");
                    Console.ReadLine();
                    multimeter = true;
                    ennyitTerveztemMára = true;
                }
                else if (multiMeterChance != 100 && Value == 1 && ennyitTerveztemMára == false)
                {
                    Console.WriteLine("Hirtelen zsebrerakod a multimétert viszont fentáll a veszélye hogy a portás látta a kamerán. Szíved elkezd sietve verni");
                    Console.ReadLine();
                    multimeter = true;
                    Random RandomCaught = new Random();
                    int GettinCaught = RandomCaught.Next(0, 101);
                    if(GettinCaught <= 30)
                    {
                        Console.WriteLine("Ahogyan vége van az órának megközelít a biztiboy és a hiányzó multimétert keresi rajtad." +
                            "\nEgy gyors motozás után megtalálja és visszaveszi, valamint minden illegális tárgyat elkoboz tőled.");
                        Console.ReadLine();
                        idegallapot += 30;
                        vegyestuzelesukazanhofokmeropalca = false;
                        ostor = false;
                        snussz = false;
                        multimeter = false;
                        ennyitTerveztemMára = true;
                    }
                    else
                    {
                        Console.WriteLine("Szerencsére a portás éppen aludt a kamerákat meg nem volt kedve visszanézni. A multiméter a tiéd.");
                        Console.ReadLine();
                        multimeter = true;
                        ennyitTerveztemMára = true;
                    }
                }
                else if (ennyitTerveztemMára == false)
                {
                    Console.WriteLine("Már golyózik a szemed az igazság táblák miatt mikor hirtelen meghallod csengét és világi megkönnyebülésben részesedsz.");
                    Console.ReadLine();
                    ennyitTerveztemMára = true;
                }
                else
                {
                    Console.WriteLine("Józan ember nem jönne be másodjára ebbe a terembe még kinzás fenyegetésével sem. Hirtelen észreveszed magadat és gyorsan kisietsz a teremből");
                }
            }
            string[] valasztasok = { "Hazamész a picsába", "Tesi öltöző" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int JedlikKijarat()
        {
            Console.Clear();
            string szoveg = ("\nJelenlegi helyzet: A Jedlik kijárata");
            Console.WriteLine(szoveg);
            Console.WriteLine("EZZZZAAAAAAAAAAAAAZZZZZZZZZZZ ÁÁÁÁÁÁÁÁÁÁÁÁÁÁ, VÉÉÉÉÉÉÉÉÉÉÉÉGREEEEE");
            if (megtamadnak == true)
            {
                Console.WriteLine("Hiába a nagy örömöd, hirtelen megtámadnak a genetikai hulladékok.");
                Console.ReadLine();
                if (bogyok == true && fegyverek > 0)
                {
                    Console.WriteLine("Fölszívod magadat és elkalapálod az összeset." +
                        "\nBosszúból minden értéküket ellopod");
                    Console.ReadLine();
                    penz += 2000;
                    string[] valasztasok = { "Vasútállomás aluljáró" };
                    int valasztottIndex = Menu(szoveg, valasztasok);
                    return valasztottIndex;
                }
                else
                {
                    Console.WriteLine("Gyorsan megvolt a hepe-hupa pikk-pakk miszlikre téptek és már eleged van");
                    Console.ReadLine();
                    penz -= 5000;
                    eletkedv -= 15;
                    idegallapot += 30;
                    Korhaz();
                    return KorhazTulelve();
                }
            }
            else
            {
                string[] valasztasok = { "Vasútállomás aluljáró" };
                int valasztottIndex = Menu(szoveg, valasztasok);
                return valasztottIndex;
            }
        }
    }
}

