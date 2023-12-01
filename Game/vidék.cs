using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        Random rand = new Random();
       public static int BalinthazEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Bálint alszik a szobájában teljesen illuminált állapotban összeokádva.Szeretnél-e továbbaludni? (Talán jobban lesz)";
            string[] valasztasok = {"Igen", "Nem"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
            
        }
        public static int Balinthaz()
        {
            string szoveg = "Jelenlegi helyzet: Bálint háza";
            string[] valasztasok = { "Mákvirág kocsma", "Győrzámolyi buszmegálló" };
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
            string[] valasztasok = { "Virágágyás", "Huggyozda(WC)", "Dunaszeg", "Bálint háza"};
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
            string[] valasztasok = {"Mákvirág kocsma"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }


        //public static int DunaszegEsemeny()
        //{
        //    string szoveg = "Jelenlegi helyzet: Miután úgy gondoltad, hogy neked mindenáron Dunaszegre kell menni gyanúsan sétálsz az utcákon.";
        //    string[] valasztasok = { "Fazakas sufnija", "Győrzámolyi buszmegálló", "Mákvirág kocsma" };
        //    int valasztottIndex = Menu(szoveg, valasztasok);
        //    return valasztottIndex;
        //}
        public static int Dunaszeg()
        {
            string szoveg = "Jelenlegi helyzet: Dunaszeg";
            string[] valasztasok = { "Fazakas sufnija", "Győrzámolyi buszmegálló", "Mákvirág kocsma"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int Fazakassufni()
        {
            string szoveg = "Jelenlegi helyzet: Fazakas sufnija";
            string[] valasztasok = {"Dunaszeg"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Gyorzamolyibuszmeg()
        {
            string szoveg = "Jelenlegi helyzet: Győrzámolyi buszmegálló";
            string[] valasztasok = {"Vidéki", "Bálint háza", "Mákvirág kocsma" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
    }
}
