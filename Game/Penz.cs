using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal partial class Program
    {
        public static int ElfogyPenz(int index, int cost)
        {
            if (index == 0 && penz < cost)
            {
                index++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"

  _   _ _                       _   __                 __                   _ _ 
 | \ | (_)                     | | /_/                /_/                  | | |
 |  \| |_ _ __   ___ ___    ___| | ___  __ _   _ __   ___ _ __  _______  __| | |
 | . ` | | '_ \ / __/ __|  / _ \ |/ _ \/ _` | | '_ \ / _ \ '_ \|_  / _ \/ _` | |
 | |\  | | | | | (__\__ \ |  __/ |  __/ (_| | | |_) |  __/ | | |/ /  __/ (_| |_|
 |_| \_|_|_| |_|\___|___/  \___|_|\___|\__, | | .__/ \___|_| |_/___\___|\__,_(_)
                                        __/ | | |                               
                                       |___/  |_|                               
");
                Thread.Sleep(1500);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return index;
        }
    }
}
