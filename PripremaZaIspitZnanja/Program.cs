using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Polje1 = { 1, 2, 3, 4, 5, 6, 7 };
            int[] Polje2 = { 3, 2, 8, 5, 5, 7 };
            int BrojClanova, Brojac = 0;
            if (Polje1.Length < Polje2.Length)
                BrojClanova = Polje1.Length;
            else
                BrojClanova = Polje2.Length;
            for (int i = 0; i < BrojClanova; i++)
                if (Polje1[i] == Polje2[i])
                    Brojac++;
            Console.WriteLine("Broj zajedničkih članova je " + Brojac);

            Console.ReadKey();
        }
    }
}
