using System;

namespace PraktilineToo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Valige rakendus:" +
                "\n1 - Loo juhuslikult arvud N ja M ja sisesta massiivi arvud N'st M'ni. Trüki arvude ruudud ekraanile. N ja M arvud on vahemikus (-100,100).\n" +
                "2 - Küsi kasutajalt viis arvu, salvesta neid massiivi ning väljasta nende summa, aritmeetiline keskmine ja korrutis. \n" +
                "3 - Küsi viielt kasutajalt nimed ja vanused, salvesta nende andmeid massiivi ning väljasta summaarne vanus, aritmeetiline keskmine, vaanema ja noorema inimeste nimed ja vanused. \n" +
                "4 - Ütle kasutajale \"Osta elevant ära!\". Senikaua korda küsimust, kuni kasutaja lõpuks ise kirjutab \"elevant\".\n" +
                "5 - Mis arv mõtles välja arvuti? Kasuta vähemalt 5 katset, et seda teada.\n" +
                "6- Küsi kasutajalt 4 arvu ning väljasta nendest koostatud suurim neliarvuline arv.\n" +
                "7 - Korrutustabel väljata ekraanile sellisel kujul;");

                int vastus;
                try
                {
                    vastus = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Sisesta arv.");
                    continue;
                }
                switch (vastus)
                {
                    case 1:
                        new Juhuslikult();
                        break;
                    case 2:
                        new Aritmeetiline();
                        break;
                    case 3:
                        new Kusitlus();
                        break;
                    case 4:
                        Console.WriteLine("nothing");   
                        break;
                    case 5:
                        new ArvaArv();
                        break;
                    case 6:
                        new SuurimNeliarvuline();
                        break;
                    case 7:
                        new Korrutustabel();
                        break;
                    default:
                        Console.WriteLine("Vale valik. Proovi sisesta muu arv.");
                        break;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
