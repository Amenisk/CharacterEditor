using System;

namespace Characters
{
    public class Wizard:Character
    {
        public override int Strength
        {
            get { return strength; }
            set
            {
                if (value > MaxStrength) {}
                else
                {
                    Damage += (value - strength) * 3;
                    HP += value - strength;

                    strength = value;
                }

            }
        }
        public override int Dexterity
        {
            get { return dexterity; }
            set
            {
                if (value > MaxDexterity) {}
                else
                {
                    PhysDef += (value - dexterity) * 0.5;

                    dexterity = value;
                }

            }
        }
        public override int Constitution
        {
            get { return constitution; }
            set
            {
                if (value > MaxConstitution) {}
                else
                {
                    HP += (value - constitution) * 3;
                    PhysDef += value - constitution;

                    constitution = value;
                }

            }
        }
        public override int Inteligence
        {
            get { return inteligence; }
            set
            {
                if (value > MaxInteligence){}
                else
                {
                    MP += (value - inteligence) * 2;
                    MagDamage += (value - inteligence) * 5;

                    inteligence = value;
                }

            }
        }
        public Wizard()
        {
            MaxStrength = 45;
            MaxDexterity = 70;
            MaxConstitution = 60;
            MaxInteligence = 250;
            Strength = 10;
            Dexterity = 20;
            Constitution = 15;
            Inteligence = 35;
            ClassName = "Wizard";
        }
        
        public Wizard(int strength, int dexterity, int constitution, int intiligence, string name)
        {
            MaxStrength = 45;
            MaxDexterity = 70;
            MaxConstitution = 60;
            MaxInteligence = 250;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Inteligence = intiligence;
            ClassName = "Rogue";
            Name = name;
        }
    }
}
