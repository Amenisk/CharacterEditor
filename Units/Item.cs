using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Characters
{
    public class Item
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string Name { get; private set; }
        public string ItemClass { get; private set; }
        public string Type { get; private set; }
        public int LvlItem { get; private set; }
        public int IncStrength { get; private set; }
        public int IncDexterity { get; private set; }
        public int IncConstitution { get; private set; }
        public int IncInteligence { get; private set; }
        public int Inc { get; private set; }
        public int IncHP { get; private set; }
        public int IncMP { get; private set; }
        public int IncDamage { get; private set; }
        public int IncPhysDefense { get; private set; }
        public int IncMagDamage { get; private set; }

        public Item() {}

        public Item(string name, string itemClass, string type, int lvlItem, 
            int hp, int mp, int damage, int physDef, int magDamage, 
            int incStrength, int incDexterity, int incConstitution, int incInteligence)
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
            IncStrength = incStrength;
            IncDexterity = incDexterity;
            IncConstitution = incConstitution;
            IncInteligence = incInteligence;
        }
    }
}
