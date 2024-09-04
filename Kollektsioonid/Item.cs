using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektsioonid
{
    public class Item
    {
        public string Name { get; set; }
        public ItemType Type { get; set; }
        public Recept? Recept { get; set; }

        public Item(string name, ItemType type, Recept? recept) 
        {
            this.Name = name;
            this.Type = type;
            if (recept != null)
            {
                this.Recept = recept;
            }
        }

    }

    public enum ItemType
    {
        Item, Material
    }
}
