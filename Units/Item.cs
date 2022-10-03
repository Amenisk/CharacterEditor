using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Item
    {
        public string Name { get; set; }
        public string ItemClass { get; set; }
        public string Type { get; set; }
        public int lvlItem { get; set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
