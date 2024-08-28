using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too
{
    public class Juhuslikult
    {
        int N, M, arv;
        Random rndm = new Random();

        public Juhuslikult()
        {
            N = rndm.Next(-100, 100);
            M = rndm.Next(N, 100);
            int[] massiv = new int[M - N];
            for (int i = 0; i < massiv.Length; i++)
            {
                
                massiv[i] = N;
                N++;
                Console.WriteLine(massiv[i] * massiv[i]);
            }
            
        }
    }
}
