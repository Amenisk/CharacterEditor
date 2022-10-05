using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Item
    {
        public string Name { get; private set; }
        public string ItemClass { get; private set; }
        public string Type { get; private set; }
        public int LvlItem { get; private set; }
        public int IncHP { get; private set; }
        public int IncMP { get; private set; }
        public int IncDamage { get; private set; }
        public int IncPhysDefense { get; private set; }
        public int IncMagDamage { get; private set; }

        public Item(string name, string itemClass, string type, int lvlItem, 
            int hp, int mp, int damage, int physDef, int magDamage)
        {
            Name = name;
            ItemClass = itemClass;
            Type = type;
            LvlItem = lvlItem;
            IncHP = hp;
            IncMP = mp;
            IncDamage = damage;
            IncPhysDefense = physDef;
            IncMagDamage = magDamage;
        }
    }
}
