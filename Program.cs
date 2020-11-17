using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPonavljanjeZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] niz=new string[3];
            Console.WriteLine("Upiši tri stringa");
            for (int i=0;i<3;i++)
            {
                niz[i] = Console.ReadLine();
            }
            Array.Sort(niz);
            Array.Reverse(niz);
            foreach (string recenica in niz)
            {
                Console.WriteLine(recenica);
            }
            Console.ReadKey();
        }
    }
}
