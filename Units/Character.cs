
using System;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Characters
{
    public class Character
    {
        public ObjectId _id;
        public string ClassName { get; protected set; } = "Character";
        public int MaxStrength { get; protected set; }
        public int MaxDexterity { get; protected set; }
        public int MaxConstitution { get; protected set; }
        public int MaxInteligence { get; protected set; }
        public string Name { get; protected set; }
        public int NumberOfPoints { get; set; } = 99;

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

        public void SetName(string name)
        {
            Name = name;
        }
    }
}