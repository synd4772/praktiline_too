using System;
using System.Drawing;

namespace TARpv23_CSharp
{
    internal class Auto
    {
        public string Regnumber { get; set; }
        public Color Varv { get; set; }
        public Inimene Omnik { get; set; }

        public Auto( string regnumber, Color varv, Inimene omanik)
        {
            this.Regnumber = regnumber;
            this.Varv = varv;
            this.Omnik = omanik;
        }

        public void KelleOmanikAuto()
        {
            Console.WriteLine(this.Omnik);
        }
    }
}