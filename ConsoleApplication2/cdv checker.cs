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
        {
            try
            {
                string om;
                Console.WriteLine("Kérem írja be az OM azonosítót!");
                om = Console.ReadLine();
                check(om);
                Console.WriteLine("Helyes");
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }
            

            Console.ReadKey();

        }
        static void check(string om)
        {

            if (om.Length != 11) throw new ArgumentException("Rossz azonosító");
            if (om[0] != '7') throw new ArgumentException("Hibás az első számjegy");

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                int digit = (int)om[i] - 48;
                if (digit < 0 || digit > 9) throw new ArgumentException("Rossz számjegy");

                sum += digit * (i + 1);
            }
            int cdv = sum % 11;

            if (cdv != (int)om[10] - 48) throw new ArgumentException("Rossz azonosító");
        }
    }
}
