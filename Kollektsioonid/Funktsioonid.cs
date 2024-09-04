using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektsioonid
{
    public class Funktsioonid
    {
        static public float SBI(Inimene inimene)
        {
            if (inimene.gender == Gender.Male)
            {
                return 66.0f + (13.7f * inimene.Kaal) + (5.0f * inimene.Pikkus) - (6.8f * inimene.Vanus);
            }
            else
            {
                return 655.0f + (9.6f * inimene.Kaal) + (1.8f * inimene.Pikkus) - (4.7f * inimene.Vanus);
            }
        }
    }
}
