using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektsioonid
{
    public class Recept
    {
        List<Item> RequiredItems = new List<Item>();

        public Recept(List<Item> requiredItems)
        {
            this.RequiredItems = requiredItems;
        }

        public bool Try(List<Item> items)
        {
            List<Item> TempList = this.RequiredItems;
            for (int i = 0; i < items.Count(); i++)
            {
                for (int j = 0;  j < TempList.Count; j++)
                {
                    if (items[i] == TempList[j] && items[i].Type == ItemType.Material)
                    {
                        TempList.RemoveAt(j);
                        break;
                    }
                }
            }
            if (TempList.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
