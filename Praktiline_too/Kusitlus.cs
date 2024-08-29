using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktilineToo
{
    public class Kusitlus
    {
        int sum = 0;
        int[] vanem = new int[2] {-1, 0};
        int[] noorem = new int[2] {-1, 0};
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

                sum += vanused[i];

                if (vanem[0] == -1 || vanem[1] < vanused[i])
                {
                    vanem[1] = vanused[i];
                    vanem[0] = i;
                }
                if (noorem[0] == -1 || noorem[1] > vanused[i])
                {
                    noorem[1] = vanused[i];
                    noorem[0] = i;
                }
            }
            Console.WriteLine("summaarne vanusevahe on {0} aastat, keskmine vanus on {1} aastat, kõige vanem inimene on {2} ({3} aastat) , kõige norem inimene on {4} ({5} aastat)", sum, sum / vanused.Length, nimed[vanem[0]], vanem[1], nimed[noorem[0]], noorem[1]);
        }
    }
}
