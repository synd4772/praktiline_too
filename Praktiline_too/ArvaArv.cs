using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktilineToo
{
    public class ArvaArv
    {
        Random rndm = new Random();
        int arv, vastus;
        public ArvaArv()
        {
            for (int i = 0; i < 5; i++)
            {
                arv = rndm.Next(1, 11);
                Console.WriteLine("Arva ära arv (1 - 10), katse on {0}", i + 1);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == arv)
                {
                    Console.WriteLine("Arvasite ära! Arv oli {0}", arv);
                    break;
                }
                else
                {
                    Console.WriteLine("Ei arvanud ära! Arv oli {0}", arv);
                }
            }
        }
    }
}
