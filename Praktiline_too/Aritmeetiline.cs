using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiline_too
{
    public class Aritmeetiline
    {
        int[] numbers = new int[5];
        int sum = 0;
        int sum2 = 1;
        public Aritmeetiline()
        {
            Console.WriteLine("Sisesta viis arvu");
            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    numbers[i] = int.Parse(Console.ReadLine());
                    sum += numbers[i];
                    sum2 *= numbers[i];
                }
                catch
                {
                    Console.WriteLine("Viga");
                }
            }
            Console.WriteLine("Nende summa on {0}, keskmine arv on {1} ja nende korrutis on {2}", sum, sum / numbers.Length, sum2);

        }
    }
}
