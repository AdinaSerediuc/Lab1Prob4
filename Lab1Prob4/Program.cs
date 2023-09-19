using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1Prob4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Ex 4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”
            */

            int numar = int.Parse(Console.ReadLine);

            if (numar < 0)
                {
                Console.WriteLine("Semnul numarului" + numar + " este -");
            }
            else if (numar = 0)
                {
                Console.WriteLine("Numarul nu are semn" + numar);
            }
            else if (numar > 0)
                {
                Console.WriteLine("Semnul numarului" + numar + "este +");
            }

        }
    }
}
