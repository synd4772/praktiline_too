using System;
using System.Collections;

namespace PraktilineToo
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolams");
            string vas = Console.ReadLine();
            if (vas != null && arrayList.Contains(vas))
            {
                Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vas) + " kohal");
            }
            else
            {
                Console.WriteLine("nothing");
            }
        }
    }
}