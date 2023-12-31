﻿using System;
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
        static bool tortenesKondi = true;
        static bool tortenesDohi = true;
        static bool tortenesAluljaro = true;
        static bool tortenesEuros = true;
        static bool Multimetereladas = true;
        static bool multiellettadva = false;
        static Random random = new Random();
        // balint valtozoi
        static bool voltálmáritt = false;
        static bool kiszokes = false;
        static int multiMeterChance = 50;
        static bool voltOltozes = false;
        static bool voltTömő = false;
        static bool voltAmmonia = false;
        static bool voltOra = false;
        static bool ennyitTerveztemMára = false;
        static bool AnnyiraNemAkarom = false;
        static bool multimeter = false;
        static bool snussz = false;
        static bool voltFolyoso = false;
        // levi valtozoi
        static bool vegyestuzelesukazanhofokmeropalca = false;
        static int gyorzamolybuszmeg = -1;


        static void Main(string[] args)
        {

            if (foMenu() == 0)
            {
                fomenu = false;
                #region Vidék
                bool balintHazTortenes = true;
                if (balintHazTortenes)
                {
                    int balintHazEsemeny = BalinthazEsemeny();
                    balintHazTortenes = false;
                    if (balintHazEsemeny == 0)
                    {
                        eletkedv += 5;
                        Console.WriteLine("Jót aludtál és nagyjából működnek a motorikus képességeid");
                        Console.ReadLine();
                    }
                    int balintHaz;
                    bool dunaszegtortenes = true;
                    bool sufnitortenes = true;
                    bool otthoniWC = true;
                    do
                    {
                        do
                        {
                            bool kocsmaTortenes;
                            balintHaz = Balinthaz();
                            switch (balintHaz)
                            {
                                case 0:
                                    int randomKocsma = random.Next(1, 3);
                                    kocsmaTortenes = true;
                                    int kocsmaesemeny = MakviragkocsmaEsemeny();
                                    if (kocsmaTortenes)
                                    {
                                        while (kocsmaesemeny == 0)
                                        {
                                            veralkoholszint += 10;
                                            eletkedv += 5;
                                            penz -= 300;
                                            kocsmaesemeny = MakviragkocsmaEsemeny();
                                        }
                                        if (kocsmaesemeny == 2)
                                        {
                                            if (randomKocsma == 1)
                                            {
                                                eletkedv += 20;
                                                Console.WriteLine("Beszélgettél az egyik helyi erővel, aki régi afgán veterán történeteket hablatyolt össze. Mivel tetszett, amit mondott így kicsit jobban érzed magad.  \nTováb a folytatáshoz");
                                                Console.ReadLine();
                                            }
                                            else if (randomKocsma == 2)
                                            {
                                                idegallapot += 40;
                                                Console.WriteLine("Egyik részeg afgán veterán(Imre bá)nak nem tetszett a pofád és megfenyegetett, hogy gyomron rúg. Bevettette arab háborús taktikáját de nem járt sikerrel így csak mentálisan épített le.  \nTováb a folytatáshoz");
                                                Console.ReadLine();
                                                if (random.Next(1, 100) <= 5)
                                                {
                                                    Console.WriteLine("Imre bá felismer téged és rég tett fogadalmát beváltja. Erőszakosan rádtámad és te magatehetetlen vagy. Afgán veterán háborús taktikája ellen nem tudod felvenni a versenyt és bár küzdöttél végül alulmaradtál. ");
                                                    Console.ReadLine();
                                                    Halal();
                                                }
                                            }
                                        }
                                    }
                                    kocsmaTortenes = false;

                                    int makviragkocsma;
                                    do
                                    {
                                        makviragkocsma = Makviragkocsma();
                                        if (makviragkocsma == 0)
                                        {
                                            int hitelHelyszin =HitelHelyszin();
                                            if (penz >= 6000 && hitelHelyszin == 0)
                                            {
                                                Joveg();
                                            }
                                            else if (hitelHelyszin == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("A kocsmában egy hatalmas tömegverekedést indítottál");
                                                Console.WriteLine("Ebből még bármi lehet...");
                                                Console.WriteLine("Vigyél be egy hatalmas jobbhorgot");
                                                Console.ReadLine();
                                                if (bogyok && fegyverek > 0 && veralkoholszint < 60)
                                                {
                                                    Console.WriteLine("Izomtól duzzadó tested és a fegyvered segítségével legyőzted az ellenséget");
                                                    Console.ReadLine();
                                                    Console.WriteLine("Diadalittasan távozol");
                                                    Console.ReadLine();
                                                    Joveg();
                                                }
                                                else if (bogyok && fegyverek > 0 && veralkoholszint >= 60)
                                                {
                                                    Console.WriteLine("Izomtól duzzadó tested és a fegyvered habár jó munkát végzett a testedben lévő alkohol miatt kordinálatlan mozgásodat könnyű volt kicselezni");
                                                    Console.ReadLine();
                                                    Console.WriteLine("Egy akkora ütést kaptál, amitől már hat hónapja kómában vagy, nem jók az esélyeid");
                                                    Console.ReadLine();
                                                    Halal();
                                                }
                                                else if (bogyok && fegyverek == 0 && veralkoholszint < 60)
                                                {
                                                    Console.WriteLine("Izomtól duzzadó tested nem bizonyult elégnek, akadtak olyanok akik késsel támadtak rád");
                                                    Console.ReadLine();
                                                    Console.WriteLine("Késsel rád mért nagy szúrás miatt, a kórházban fekszel nincsenek jó kilátásaid");
                                                    Console.ReadLine();
                                                    Halal();
                                                }
                                                else if (!bogyok && fegyverek < 0 && veralkoholszint < 60)
                                                {
                                                    Console.WriteLine("Fegyvereddel hadonásztál, de senki sem vett komolyan olyan gyenge vagy és könnyűszerrel kicsavarták a kezedből a fegyvert");
                                                    Console.ReadLine();
                                                    Console.WriteLine("Ezután úgy szétvertek, hogy édesanyád se ismerne rád");
                                                    Console.ReadLine();
                                                    Halal();
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Egyedül vagy az egész kocsma ellen, ennek nem lesz jó vége...");
                                                    Console.ReadLine();
                                                    Console.WriteLine("Úgy szétvertek, hogy édesanyád se ismerne rád");
                                                    Console.ReadLine();
                                                    Halal();
                                                }
                                            }
                                        }
                                        else if (makviragkocsma == 1)
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
                                        else if (makviragkocsma == 2)
                                        {
                                            bool wctortenes = true;
                                            if (wctortenes)
                                            {
                                                int wcesemeny = WCEsemeny();
                                                wctortenes = false;
                                                if (wcesemeny == 0)
                                                {
                                                    Console.WriteLine("A sötétben egy random emberrel kardoztál és elég jó volt. Így kicsit vidámabban fogod elhagyni a budit.");
                                                    Console.ReadLine();
                                                    eletkedv += 5;
                                                    idegallapot -= 10;
                                                }
                                                else if (wcesemeny == 1)
                                                {
                                                    Console.WriteLine("Nem bírtad tovább és hánytál egyett. Ezért megkönnyebültebben távolzol a helységből");
                                                    Console.ReadLine();
                                                    veralkoholszint -= 15;
                                                    idegallapot -= 5;
                                                }
                                            }
                                            int wc = WC();
                                        }
                                        //else if (makviragkocsma == 4)
                                        //{
                                        //    Console.WriteLine("Eljutottál gond nélkül");
                                        //    int gyorzamolybuszmeg = Gyorzamolyibuszmeg();
                                        //}
                                        else if (makviragkocsma == 3)
                                        {
                                            kocsmaTortenes = true;
                                            if (random.Next(1, 101) >= 35 && dunaszegtortenes)
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
                                                    Console.WriteLine("Úgy gondoltad, hogy most nem alkalmas csatába szállni ezért felkötötted a nyúlcipődet. Lelkileg ez annyira megviselt, hogy majdnem szívbajt kaptál. Az életkedved is csökkent.");
                                                    Console.ReadLine();
                                                }
                                            }
                                            int dunaszeg;
                                            do
                                            {
                                                kocsmaTortenes = true;
                                                dunaszeg = Dunaszeg();
                                                if (dunaszeg == 0)
                                                {
                                                    if (sufnitortenes)
                                                    {
                                                        int sufniesemeny = FazakassufniEsemeny();
                                                        sufnitortenes = false;
                                                        if (sufniesemeny == 0)
                                                        {
                                                            Console.WriteLine("Gyors reagálásúként felvetted az első dolgot a földről, ami a kezedbe került (kazánhőfokmérő). És voltál olyan ügyes, hogy még kiléted lebukása előtt el tudtad hagyni a helyszínt. Fazakas Tanár Úrt nem zavarta ez a különös eset.");
                                                            Console.ReadLine();
                                                            vegyestuzelesukazanhofokmeropalca = true;
                                                            fegyverek++;
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
                                                            Halal();
                                                        }
                                                    }

                                                    int fazakassufni = Fazakassufni();
                                                }
                                            } while (dunaszeg != 1);
                                        }
                                    } while (makviragkocsma != 4);
                                    break;
                                case 1:
                                    Console.WriteLine("Random nyuggerek mint MINDIG a megállóban kiengedték világfájdalmukat és el kezdtek beszólogatni. Nem bírtad magadat tűrtöztenip és egy kisebb migrént kaptál.");
                                    Console.ReadLine();
                                    idegallapot += 20;
                                    gyorzamolybuszmeg = Gyorzamolyibuszmeg();
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
                                                    Console.ReadLine();
                                                }
                                                else
                                                {
                                                    idegallapot += 10;
                                                    Console.WriteLine("Elestél");
                                                    Console.ReadLine();
                                                }

                                            }
                                        }
                                        #endregion
                                        #region Várospt1
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

                                        int videki;
                                        do
                                        {
                                            videki = Videki();
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
                                                            if (random.Next(0, 101) >= 70)
                                                            {
                                                                penz += 500;
                                                            }
                                                            else
                                                            {
                                                                eletkedv -= 20;
                                                            }
                                                        }
                                                        else if (dohiKunyeralasEsemeny == 2)
                                                        {
                                                            if (multimeter)
                                                            {
                                                                Console.WriteLine("A híres nemzeti előtt állsz és az előzőleg megszerzett multimétert megpróbálod rásozni valakire." +
                                                                    "\nKis idő után szembejön veled egy filippínó gyármunkás aki szívesen elfogadja ajánlatodat mondván: 'Köcönöm cépen 3000 pínz jó alkatrész.'");
                                                                Console.ReadLine();
                                                                penz += 3000;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("Egy hang megszólal a fejed hátuljából: Mégis milyen multimétert akarsz eladni hogyha nincsen nálad te world of tanks játékos.");
                                                                Console.ReadLine();
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
                                                            case 3:
                                                                if (multimeter && Multimetereladas)
                                                                {
                                                                    Console.WriteLine("Beveted megnyerő mosolyod, és megpróbáod eladni a megszerzett multimétert");
                                                                    Console.ReadLine();
                                                                    Console.WriteLine("Meglepő módon sikerült kaptál érte 2000-et");
                                                                    Console.ReadLine();
                                                                    penz += 2000;
                                                                    eletkedv += 10;
                                                                    Multimetereladas = false;
                                                                    multimeter = false;
                                                                    multiellettadva = true;
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
                                                                #endregion
                                                                #region Jedlik
                                                                case 2:
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
                                                                    do
                                                                    {
                                                                        switch (dokument)
                                                                        {
                                                                            case 0:
                                                                                int bufeigenvagynemmegőrülöknemigaz = Bufe();
                                                                                if (bufeigenvagynemmegőrülöknemigaz == 1)
                                                                                {
                                                                                    //Vasútállomás függvény
                                                                                    kiszokes = true;
                                                                                }
                                                                                else if (!kiszokes)
                                                                                {
                                                                                    dokument = Folyoso();
                                                                                }
                                                                                break;
                                                                            case 1:
                                                                                int faszomkivan = JedlikWC();
                                                                                if (faszomkivan == 1)
                                                                                {
                                                                                    kiszokes = true;
                                                                                }
                                                                                else
                                                                                {
                                                                                    dokument = Folyoso();
                                                                                }
                                                                                break;
                                                                            case 3:
                                                                                Nővérke();
                                                                                break;
                                                                        }
                                                                    } while (dokument != 2 && kiszokes != true);
                                                                    
                                                                    if (kiszokes == true)
                                                                    {
                                                                        jedlik = JedlikKijarat();
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
                                                                                        jedlik = JedlikKijarat();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        int nem2 = SZGTerem();
                                                                                        if (nem2 == 0)
                                                                                        {
                                                                                            jedlik = JedlikKijarat();
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
                                                                                        jedlik = JedlikKijarat();
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        int námbör_sziksz1 = TesiOltozo();
                                                                                        if (námbör_sziksz1 == 0)
                                                                                        {
                                                                                            int guh1 = TesiTerem();
                                                                                            if (guh1 == 0)
                                                                                            {
                                                                                                jedlik = JedlikKijarat();
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                int nem2 = SZGTerem();
                                                                                                if (nem2 == 0)
                                                                                                {
                                                                                                    jedlik = JedlikKijarat();
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    námbör_sziksz1 = TesiOltozo();
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
                                                                                    jedlik = JedlikKijarat();
                                                                                }
                                                                                else
                                                                                {
                                                                                    int námbör_sziksz3 = TesiOltozo();
                                                                                    if (námbör_sziksz3 == 0)
                                                                                    {
                                                                                        int guh3 = TesiTerem();
                                                                                        if (guh3 == 0)
                                                                                        {
                                                                                            jedlik = JedlikKijarat();
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            int nem3 = SZGTerem();
                                                                                            if (nem3 == 0)
                                                                                            {
                                                                                                jedlik = JedlikKijarat();
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


                                                                    break;
                                                            }

                                                        } while (euros != 0 && jedlik != 0 && vasut != 0);
                                                    } while (vasut != 0);
                                                    break;
                                                #endregion
                                                #region Várospt2
                                                case 4:
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
                                                    #endregion
                                            }

                                        } while (videki != 3);


                                    }
                                    break;
                                #region Vidékkiegészítő
                                case 2:
                                    if (otthoniWC)
                                    {
                                        idegallapot -= 20;
                                        otthoniWC = false;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Most voltál, nem jön semmi...");
                                        Console.ReadLine();
                                    }
                                    break;
                            }
                        } while (gyorzamolybuszmeg != 1);
                        #endregion
                    } while (true);
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
                        Console.WriteLine("\n------------------------------------------------------------------\n");
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
                    Console.ForegroundColor = ConsoleColor.White;
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
            if (multimeter) szoveg += "\n\tMultimeter";
            if (vegyestuzelesukazanhofokmeropalca) szoveg += "\n\tKazánhőfokmérő";
            string[] valasztasok = { "Kilépés" };
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