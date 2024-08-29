using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PraktilineToo
{
    public class SuurimNeliarvuline
    {
        int[] arvud = new int[4];
        string sone = "";
        public SuurimNeliarvuline()
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine("Sisesta arv");
                arvud[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arvud);
            Array.Reverse(arvud);
            sone = string.Join("", arvud);

            Console.WriteLine("Suurim neljakohaline arv on {0}", sone);
        }
    }
}
