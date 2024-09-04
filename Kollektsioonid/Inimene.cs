using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektsioonid
{
    public class Inimene
    {
        public Gender gender { get; set; }
        public int Vanus { get; set; }
        public float Pikkus { get; set; }
        public float Kaal {  get; set; }

        public Inimene(Gender gender, int vanus, float pikkus, float kaal)
        {
            this.gender = gender;
            this.Vanus = vanus;
            this.Pikkus = pikkus;
            this.Kaal = kaal;
        }
        public Inimene() { }

    }

    public enum Gender { 
        Male, Female
    }
}
