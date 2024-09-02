using System;
using System.Collections;
using System.Drawing;

namespace TARpv23_CSharp
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            List<Inimene> inimesed = new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjotr";
            inimene1.Vanus = 352;
            Inimene inimene2 = new Inimene("Jelizaveta");
            inimene2.Vanus = 98;
            Inimene inimene3 = new Inimene("Vlad", 17);
            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);
            inimesed.Add(new Inimene("Irina", 18));

            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine($"{inimene.Nimi} on {inimene.Vanus} aastat vana");
            }

            Auto auto1 = new Auto("681MRP", Color.Bisque, inimene1);
            Auto auto2 = new Auto("180ABC", Color.NavajoWhite, inimene2);
            Auto auto3 = new Auto("079TDI", Color.Red, inimene3);

            auto1.KelleOmanikAuto();
            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();
            register.Add(auto1, inimene1);
            register.Add(auto2, inimene2);
            register.Add(auto3, inimene3);
            foreach(var item in register)
            {
                Console.WriteLine($"{item.Key.Regnumber} - {item.Value.Nimi}");
            }
            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine(pair.Key.Regnumber + "-" + pair.Value.Nimi);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");



            Random random = new Random();
            int[] ints = new int[20];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = random.Next(1, 60);        
            }
            int[] ints2 = new int[20];


        }
    }
}