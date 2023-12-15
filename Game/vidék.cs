using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        public static int BalinthazEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Bálint alszik a szobájában teljesen illuminált állapotban. Szeretnél-e továbbaludni? (Talán jobban lesz)";
            string[] valasztasok = { "Igen", "Nem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;

        }
        public static int Balinthaz()
        {
            string szoveg = "Jelenlegi helyzet: Bálint háza";
            string[] valasztasok = { "Mákvirág kocsma", "Győrzámolyi buszmegálló", "WC használata" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }




        public static int MakviragkocsmaEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Bálint a kocsmában sóvárog egy hideg korsó sör után és már habzik a szája az izgalomtól. A nagy tartózás ellenére fontolgatja, hogy igyon. Kérsz egy korsó sört? " +
                "\nHa esetleg nem akarsz inni, beszélgethetsz a helyi alkoholistákkal. Vigyázz, akár veszélyes kimenetelű is lehet!";
            string[] valasztasok = { "Igen", "Nem", "Beszélgetés az alkeszekkel" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Makviragkocsma()
        {
            string szoveg = "Jelenlegi helyzet: Mákvirág kocsma";
            string[] valasztasok = { "HITEL VISSZAFIZETÉSE", "Virágágyás", "Huggyozda(WC)", "Dunaszeg", "Bálint háza", };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }



        public static int ViragagyasEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Bálint miután kivánszorgott valahogyan a virágágyásba, bevetette magát a dzsumbujba. Esetleg egy alvás nem ártana neki. Szeretnél aludni?";
            string[] valasztasok = { "Igen", "Nem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Viragagyas()
        {
            string szoveg = "Jelenlegi helyzet: Mákvirágkocsma mögöti virágágyás";
            string[] valasztasok = { "Mákvirág kocsma" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }


        public static int WCEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: A kocsma wc-je elég lepusztult és sötét van. Pintér már nagyon pang, okádnia is kell de még kardozni is van kedve. Melyiket csinálnád szívesebben?";
            string[] valasztasok = { "Kardozás", "Hányás" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int WC()
        {
            string szoveg = "Jelenlegi helyzet: Mákvirág kocsma huggyozdája";
            string[] valasztasok = { "Mákvirág kocsma" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }


        public static int DunaszegEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Miután úgy gondoltad, hogy neked mindenáron Dunaszegre kell menni gyanúsan sétálsz a homályos utcákon. Egszer csak arra leszel figyelmes, hogy a sötétségből előjön egy csapat kiéhezett vadliba. Döntés előtt állsz.";
            string[] valasztasok = { "Ellentámadást indíasz a vadlibák ellen", "Elfutsz mint egy gyáva nyúl" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Dunaszeg()
        {
            string szoveg = "Jelenlegi helyzet: Dunaszeg";
            string[] valasztasok = { "Fazakas sufnija", "Mákvirág kocsma" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }


        public static int FazakassufniEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Miután összegyűjtötted a bátorságod betörtél horror módon Fazakas sufnijába. Azonban nem várt esemény történt mivel a Tanár Úr épp tilogonometila egyenleteket oldott és szembe találtad magad vele. \nHárom választásod van. Vigyázz, akár veszélyes kimenetelű is lehet!";
            string[] valasztasok = { "Földön heverő valamilyen tárgy ellopása", "Menekülés amerre látsz", "Bzonytalan döntés meghozása" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Fazakassufni()
        {
            string szoveg = "Jelenlegi helyzet: Fazakas sufnija";
            string[] valasztasok = { "Dunaszeg" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }


        public static int GyorzamolyibuszmegEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Győrzámolyon, hogy nem jön a busz elég gyakori esemeny, ezért mindig a közelben lerakod a drótszamarat ilyen és más típusú veszélyhezetek miatt. Nincs más választásod át kell kelni a töltésen.";
            string[] valasztasok = { "Vidéki" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Gyorzamolyibuszmeg()
        {
            string szoveg = "Jelenlegi helyzet: Győrzámolyi buszmegálló";
            string[] valasztasok = { "Vidéki", "Bálint háza", };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int HitelHelyszin()
        {
            string szoveg = "Jelenlegi helyzet: Az évek során felhalmozódott hitel visszafizetésére máig kaptál haladékot, valamilyen módon törlesztened kell (6000Ft)";
            if (penz < 6000)
            {
                szoveg += "\n\nBármennyire győzködöd a kocsmárost, ennyi pénz nem lesz elég!";
                szoveg += "\nMegszólal egy hang a fejedben, hogy van erre egy másik mód is...\n";
            }
            string[] valasztasok = {"Engedsz a kísértésnek", "Vissza"};
            if (penz >= 6000)
            {
                List<string> list = new();
                list.AddRange(valasztasok);
                list[0] = "HITEL VISSZAFIZETÉSE";
                valasztasok = list.ToArray();
            }
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
    }
}
