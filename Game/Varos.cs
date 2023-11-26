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
        public static int VidekiEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Videkinél kéreget egy napsütötte ember. Adsz neki pénzt?";
            string[] valasztasok = { "Igen", "Nem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Videki()
        {

            string szoveg = "Jelenlegi helyzet: Videki";
            string[] valasztasok = { "Kondi", "Dohi", "Vasútállomás aluljáró" };
            if (veralkoholszint >= 70)
            {
                List<string> list = new();
                list.AddRange(valasztasok);
                list.Add("Lucifer XXX Shop");
                valasztasok = list.ToArray();
            }
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int KondiEsemeny()
        {
            string szoveg = "Jelenlegi helyzet: Kondiban a legnagyobb csávó pirulákat és injekciót akar neked adni mindössze 1000Ft-ért. Elfogadod?";
            string[] valasztasok = { "Igen", "Nem" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Kondi()
        {
            string szoveg = "Jelenlegi helyzet: Kondi";
            string[] valasztasok = { "Vidéki" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int DohiKunyeralas()
        {
            string szoveg = "Jelenlegi helyzet: A hitel miatt megfordul a fejedben, hogy kihasználva jóképűséged szerezz egy kis pénzt.";
            string[] valasztasok = { "Kunyerálás", "Gondolat elhesegetése" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int DohiBolt()
        {
            string szoveg = "Jelenlegi helyzet: Dohi.";
            string[] valasztasok = { "Alkohol vétel", "Cigi vétel", "Nem kell semmi" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static int Dohi()
        {
            string szoveg = "Jelenlegi helyzet: Dohi";
            string[] valasztasok = { "Vidéki" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
    }
}
