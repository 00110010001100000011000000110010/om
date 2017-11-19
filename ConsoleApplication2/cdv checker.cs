using System;
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
            om = Console.ReadLine();
            if (om.Length == 11) Console.WriteLine("Azonosító ellenőrzése...");
            else Console.WriteLine("Rossz azonosító");
            if (om[0] != '7' ) Console.WriteLine("nope");
            else Console.WriteLine("ok");
            int sum = 0;
            for (int i=0; i<10; i++) {
                sum+=((int) om[i]) * (i+1); 
            }
            int cdv = sum % 11;

            if (cdv != (int) om[10] - 48) Console.WriteLine("Rossz azonosító");
            else Console.WriteLine("Helyes");
            

            Console.ReadKey();

        }
    }
}
