﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace om
{
    class Program
    {
        static void Main(string[] args)
        {string om;
            Console.WriteLine("Kérem írja be az OM azonosítót!");
            om =  Console.ReadLine();
            if (om.Length == 11) Console.WriteLine("Azonosító ellenőrzése...");
            else Console.WriteLine("Rossz azonosító");
            if (om[0] != '7' ) Console.WriteLine("nope");
            else Console.WriteLine("ok");
            int cdv = (((int)om[0] - 48) * 1 + ((int)om[1] - 48) * 2 + ((int)om[2] - 48)* 3 + ((int)om[3] - 48) * 4 + ((int)om[4] - 48) * 5 + ((int)om[5] - 48) * 6 + ((int)om[6] - 48) * 7 + ((int)om[7] - 48) *8 + ((int)om[8] - 48) * 9 + ((int)om[9] - 48) * 10) %11;
            Console.WriteLine(cdv);
            if (cdv != (int) om[10] - 48) Console.WriteLine("Rossz azonosító");
            else Console.WriteLine("Helyes");
            

            Console.ReadKey();

        }
    }
}
