using System;

namespace Kollektsioonid
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            /* Ülesanne 1 */



            /* Ülesanne 2 */

            int size = 20;
            Random rnd = new Random();
            List<int> list = new List<int>(size);
            
            for (int i = 0; i < size; i++)
            {
                list.Add(rnd.Next(1,101));
            }

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (list[i] % 2 == 0)
                {
                    list1.Add(list[i]);
                }
                else
                {
                    list2.Add(list[i]);
                }
            }

            list1.Concat(list2);
            Console.WriteLine((decimal) 14142141.12);

            /* Ülesanne 3 */

           

            /* Ülesanne 4 */



            /* Ülesanne 5 */



        }
    }
}