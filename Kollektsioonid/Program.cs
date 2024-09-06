using System;

namespace Kollektsioonid
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            string err = "proovi veel";
            /* Ülesanne 1 */

            Console.WriteLine("Sisesta tühikuga numbrid");
            string[] sNumbers = Console.ReadLine().Split();
            int[] iNumbers = new int[sNumbers.Length];
            try
            {
                for (int i = 0; i < sNumbers.Length; i++)
                {
                    iNumbers[i] = int.Parse(sNumbers[i]);
                }
            }
            catch
            {
                Console.WriteLine(err);
            }
            int[] result = new int[] {};
            for(int i = 0; i < iNumbers.Length; i++)
            {
                int leftNumber = 0;
                int rightNumber = 0;
                if (iNumbers.Length == 1)
                {
                    result[i] = iNumbers[i];
                }
                if (i == 0)
                {
                    leftNumber = iNumbers[iNumbers.Length - 1];
                    rightNumber = iNumbers[i + 1];
                   
                }
                else if(i == iNumbers.Length - 1)
                {
                    rightNumber = iNumbers[0];
                    leftNumber = iNumbers[i - 1];
                }

                result[i] =  leftNumber + rightNumber;
                Console.Write(result[i].ToString(), " ");
            }
            Console.WriteLine("");


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

            /* Ülesanne 3 */

            List<Product> products = new List<Product>()
            {
                new Product("apple", 124), new Product("pear", 114), new Product("banana", 142), new Product("orange", 97)
            };

            Inimene inimene = new Inimene();
            Console.WriteLine("Täitke järgmised andmed");
            try
            {
                Console.WriteLine("Milline on teie vanus?");
                inimene.Vanus = int.Parse(Console.ReadLine());
                Console.WriteLine("Milline on teie kasv?");
                inimene.Pikkus = float.Parse(Console.ReadLine());
                Console.WriteLine("Milline on teie kaal?");
                inimene.Kaal = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine(err);
            }

            Console.WriteLine("Sinu SBI on" , Funktsioonid.SBI(inimene));





            /* Ülesanne 4 */

            Dictionary<string, string> sonastik = new Dictionary<string, string>();
            sonastik.Add("Tallinn", "Harjumaa");
            sonastik.Add("Tartu", "Tartumaa");
            sonastik.Add("Pärnu", "Pärnumaa");

            while (true)
            {
                Console.WriteLine("\n1. otsige linna või maakonda \n2. lisage uus kirje \n3. teadmiste testimine \n4. break");
                string valik = Console.ReadLine();

                if (valik == "1")
                {
                    Console.WriteLine("Sisestage linn või maakonna nimi:");
                    string sisend = Console.ReadLine();
                    if (sonastik.ContainsKey(sisend))
                    {
                        Console.WriteLine($"Maakond: {sonastik[sisend]}");
                    }
                    else if (sonastik.ContainsValue(sisend))
                    {
                        foreach (var paar in sonastik)
                        {
                            if (paar.Value == sisend)
                            {
                                Console.WriteLine($"Pealinn: {paar.Key}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Seda kirjet ei leitud.");
                    }
                }
                else if (valik == "2")
                {
                    Console.WriteLine("Sisestage maakonna nimi:");
                    string maakonnaNimi = Console.ReadLine();
                    Console.WriteLine("Sisestage pealinna nimi:");
                    string pealinnaNimi = Console.ReadLine();

                    if (!sonastik.ContainsKey(pealinnaNimi))
                    {
                        sonastik.Add(pealinnaNimi, maakonnaNimi);
                        Console.WriteLine("Kirje lisatud.");
                    }
                    else
                    {
                        Console.WriteLine("See pealinn on juba sõnastikus.");
                    }
                }
                else if (valik == "3")
                {
                    int õigedVastused = 0;
                    int kysimusteArv = sonastik.Count;
                    Random rand = new Random();
                    List<string> linnad = new List<string>(sonastik.Keys);

                    foreach (var linn in linnad)
                    {
                        Console.WriteLine($"Mis on maakond pealinnale: {linn}?");
                        string vastus = Console.ReadLine();

                        if (vastus.Equals(sonastik[linn], StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("Õige!");
                            õigedVastused++;
                        }
                        else
                        {
                            Console.WriteLine($"Vale. Õige vastus on {sonastik[linn]}.");
                        }
                    }

                    double tulemus = (double)õigedVastused / kysimusteArv * 100;
                    Console.WriteLine($"Teie tulemus on {tulemus}%");
                }
                else if (valik == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(err);
                }
            }
               


            /* Ülesanne 5 */
            List<Item> materials = new List<Item>() {
            new Item("wood", ItemType.Material, null), new Item("metall", ItemType.Material, null), new Item("plastic", ItemType.Material, null)
            };

            List<Item> items = new List<Item>()
            {
            new Item("sword", ItemType.Item, new Recept(new List<Item>() {materials[0], materials[1], materials[1] })),
            new Item("axe", ItemType.Item, new Recept(new List<Item>() {materials[0], materials[1], materials[2] })),
            new Item("stick", ItemType.Item, new Recept(new List<Item>() {materials[1], materials[1]}))
            };

            List<Item> inventory = new List<Item>();


            while (true)
            {
                Console.WriteLine("---------\n1. leida asjad\n2. luua midagi\n3. vaatada kotti\n 4. break");
                int vastus = 0;
                try
                {
                    vastus = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine(err);
                }
                if (vastus == 1)
                {
                    Random rand = new Random();
                    int x = rand.Next(0, 3);
                    inventory.Add(materials[x]);
                    Console.WriteLine("sa leiad - ", materials[x].Name);

                }
                else if (vastus == 2)
                {
                    for (int i = 0; i < items.Count(); i++)
                    {
                        Console.WriteLine(items[i].Name, ",");
                    }
                    Console.WriteLine("Mida sa soovid?");
                    try
                    {
                        vastus = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine(err);
                    }
                    bool success = items[vastus].Recept.Try(inventory);
                    if (success)
                    {
                        Console.WriteLine("Sa võid teha seda.");
                        Console.WriteLine("kas te tahate teha seda?");
                        try
                        {
                            vastus = int.Parse(Console.ReadLine());

                        }
                        catch
                        {
                            Console.WriteLine(err);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sa ei või teha seda.");

                    }



                }
                else if (vastus == 3)
                {
                    for (int i = 0; i < inventory.Count(); i++)
                    {
                        Console.WriteLine(inventory[i].Name);
                    }
                    Console.WriteLine("");
                }
                else if (vastus == 4)
                {
                    break;
                }
            }




        }
    }
}