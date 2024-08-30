using System;

namespace PraktilineToo
{
    public class Korrutustabel 
    {
        public Korrutustabel()
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}