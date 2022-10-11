using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class CharacterInfo
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public CharacterInfo(string name, int lvl)
        {
            Name = name;
            Level = lvl;
        }
    }
}
