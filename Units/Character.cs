
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace Characters
{
    public class Character
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        public string ClassName { get; protected set; } = "Character";
        public int MaxStrength { get; protected set; }
        public int MaxDexterity { get; protected set; }
        public int MaxConstitution { get; protected set; }
        public int MaxInteligence { get; protected set; }
        public string Name { get; protected set; }
        public int NumberOfPoints { get; set; } = 5;
        public int Level { get; set; } = 1;
        public int LevelPoints { get; set; }
        public int NextLevelPoints { get; set; } = 1000;

        public int abilityCount;

        public List<string> Abilities { get; protected set; } = new List<string>() {"Fireball", "Double jerk", "Resistance to poison", 
            "Invisibility", "Night vision", "Leap of faith", "Rage", "Clonning", "Water explosion", "Walking on water"};

        public List<string> CharacterAbilities { get; protected set; } = new List<string>();

        protected int strength;
        protected int dexterity;
        protected int constitution;
        protected int inteligence;

        public virtual int Strength 
        {
            get { return strength; }
            set
            {
                strength = value;
            }
        }
        public virtual int Dexterity
        {
            get { return dexterity; }
            set
            {
                dexterity = value;
            }
        }
        public virtual int Constitution
        {
            get { return constitution; }
            set
            {
                constitution = value;
            }
        }
        public virtual int Inteligence
        {
            get { return inteligence; }
            set
            {
                inteligence = value;
            }
        }

        public int HP { get; protected set; }
        public double MP { get; protected set; }
        public int Damage { get; protected set; }
        public double PhysDef { get; protected set; }
        public int MagDamage { get; protected set; }

        [BsonIgnoreIfDefault]
        public List<Item> inventory = new List<Item>();

        public Character()
        {

        }
        public Character(string name, int numOfPoints,
            List<Item> items, List<string> charAbil, List<string> abil,
            int lvl, int lvlPoints, int nextLvlPoints, int abilCount)
        {
            Name = name;
            NumberOfPoints = numOfPoints;
            inventory = items;
            CharacterAbilities = charAbil;
            Abilities = abil;
            Level = lvl;
            LevelPoints = lvlPoints;
            NextLevelPoints = nextLvlPoints;
            abilityCount = abilCount;

        }
        public void AddToInventory(Item item)
        {
            inventory.Add(item);
        }
        public void SetName(string name)
        {
            Name = name;
        }
    }
}