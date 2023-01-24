using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Polje1 = new int[10];
            int[] Polje2 = new int[10];
            string Brojevi;
            int BrojeviNiz, PrviBroj = 0, DrugiBroj = 0;
            do
            {
                Console.WriteLine("Upišite broj:");
                Brojevi = Console.ReadLine();
                BrojeviNiz = Convert.ToInt32(Brojevi);
                if (BrojeviNiz % 2 != 0)
                    Polje1[PrviBroj++] = BrojeviNiz;
                else
                    Polje2[DrugiBroj++] = BrojeviNiz;
            } while (BrojeviNiz != 0 && PrviBroj < 10 && DrugiBroj < 10);
            Console.WriteLine();
            for (int i = 0; i < PrviBroj; i++)
                Console.WriteLine(Polje1[i]);
            Console.WriteLine();
            for (int i = 0; i < DrugiBroj; i++)
                Console.WriteLine(Polje2[i]);

            Console.ReadKey();
        }
    }
}
