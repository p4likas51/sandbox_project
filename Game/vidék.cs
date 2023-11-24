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

        public static int Makviragkocsma()
        {
            string szoveg = "Jelenlegi helyzet: Mákvirág kocsma";
            string[] valasztasok = { "Virágágyás", "Huggyozda(WC)", "Dunaszeg", "Vissza"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int WCEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Mákvirág kocsma huggyozdája";
            string[] valasztasok = { "Vissza" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int WC()
        {
            string szoveg = "Jelenlegi helyzet: Mákvirág kocsma huggyozdája";
            string[] valasztasok = {"Vissza"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int Dunaszeg()
        {
            string szoveg = "Jelenlegi helyzet: Dunaszeg";
            string[] valasztasok = { "Fazakas sufnija", "Győrzámolyi megálló", "Vissza"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int Fazakassufni()
        {
            string szoveg = "Jelenlegi helyzet: Fazakas sufnija";
            string[] valasztasok = {"Vissza"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }

        public static int GyorzamolyibuszmegEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Győrzámolyi buszmegállóban várakozol de pár nyugger nem bír magával és kiengedi világfájdalmát. Sőt be is szólnak, amiért egy kisebb idegsokkot kaptál.";
            string[] valasztasok = { "Vidéki", "Bálint háza", "Vissza" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Gyorzamolyibuszmeg()
        {
            string szoveg = "Jelenlegi helyzet: Győrzámolyi buszmegálló";
            string[] valasztasok = {"Vidéki", "Bálint háza", "Vissza"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
    }
}
