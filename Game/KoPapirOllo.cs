﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        public static float KorokSzama()
        {
            string szoveg = "Hány körig menjen a játék?";
            string[] valasztasok = { "1", "3", "5" };
            int valasztottIndex = Menu(szoveg, valasztasok);
            return valasztottIndex;
        }
        public static void Jatek()
        {
            float korok = KorokSzama();
            if (korok == 0) korok = 1;
            else if (korok == 1) korok = 3;
            else korok = 5;
            int gep = 0;
            int jatekos = 0;

            for (int i = 0; i <= korok; i++)
            {
                if (gep < (korok / 2) && jatekos < (korok / 2))
                {
                    int gepTipp = rand.Next(0, 3);
                    int jatekosTipp = Valasztas();
                    Console.Clear();
                    Console.WriteLine("A továbblépéshez nyomj meg egy gombot");
                    Console.ReadLine();
                    Console.WriteLine($"Jelenlegi állás: {jatekos} - {gep} (Te - Olivér)\n");
                    Console.Write("Olivér választása: ");
                    if (gepTipp == 0) Console.WriteLine("Kő");
                    else if (gepTipp == 1) Console.WriteLine("Papír");
                    else Console.WriteLine("Olló");
                    if (jatekosTipp == gepTipp)
                    {
                        Console.WriteLine("\nDöntetlen");
                        Thread.Sleep(2000);
                    }
                    else if ((jatekosTipp == 0 && gepTipp == 1) ||
                             (jatekosTipp == 1 && gepTipp == 2) ||
                             (jatekosTipp == 2 && gepTipp == 0))
                    {
                        Console.WriteLine("\nOlivér nyert");
                        Console.ReadLine();
                        gep++;
                    }
                    else
                    {
                        Console.WriteLine("\nTe nyertél");
                        Console.ReadLine();
                        jatekos++;
                    }
                }
                
            }
            Console.Clear();
            Console.Write("\nJáték győztese: ");
            if (jatekos > gep)
            {
                Console.WriteLine("Te");
            }
            else
            {
                Console.WriteLine("Olivér");
                Console.WriteLine($"Jelenlegi állás: {jatekos} - {gep} (Te - Olivér)\n");
                Console.WriteLine("Ez azt jelenti, hogy Olivérnek fizetsz egy hagymáskarikát");
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
