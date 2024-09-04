using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektsioonid
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Calories { get; set; }

        public Product(string name, decimal calories)
        {
            this.Name = name;
            this.Calories = calories;
        }


    }
}
