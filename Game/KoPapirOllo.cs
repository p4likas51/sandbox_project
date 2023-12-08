using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        public static int KorokSzama()
        {
            string szoveg = "Hány körig menjen a játék?";
            string[] valasztasok = { "1", "3", "5" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static void Jatek()
        {
            int korok = KorokSzama();
            if (korok == 0) korok = 1;
            else if (korok == 1) korok = 3;
            else korok = 5;
            int gep = 0;
            int jatekos = 0;

            for (int i = 0; i <= korok; i++)
            {
                int gepTipp = rand.Next(0, 3);
                int jatekosTipp = Valasztas();
                Console.Write("Olivér választása: ");
                if (gepTipp == 0) Console.WriteLine("Kő");
                else if (gepTipp == 1) Console.WriteLine("Papír");
                else Console.WriteLine("Olló");
                Thread.Sleep(2000);
                if (jatekosTipp == gepTipp)
                {
                    Console.WriteLine("Döntetlen");
                    Thread.Sleep(2000);
                }
                else if ((jatekosTipp == 0 && gepTipp == 1) ||
                         (jatekosTipp == 1 && gepTipp == 2) ||
                         (jatekosTipp == 2 && gepTipp == 0))
                {
                    Console.WriteLine("Olivér nyert");
                    Thread.Sleep(2000);
                    gep++;
                }
                else
                {
                    Console.WriteLine("Te nyertél");
                    Thread.Sleep(2000);
                    jatekos++;
                }
            }
            if (jatekos > gep)
            {
                Console.WriteLine("Te nyertél");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Olivér nyert");
                Console.ReadLine();
            }
        }
        public static int Valasztas()
        {
            string szoveg = "Választás:";
            string[] valasztasok = { "Kő", "Papír", "Olló"};
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        
    }
}
