using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too
{
    public class Kusitlus
    {
        string[] nimed = new string[5];
        int[] vanused = new int[5];
        public Kusitlus() 
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Mis nimi sul on?");
                nimed[i] = Console.ReadLine();
                Console.WriteLine("Kui vana sa oled?");
                vanused[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
