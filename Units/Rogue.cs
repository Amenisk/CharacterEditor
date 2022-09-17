using System;

namespace Characters
{
	public class Rogue : Character
	{
        public override int Strength
        {
            get { return strength; }
            set
            {
                if (value > MaxStrength)
                {

                }
                else
                {
                    Damage += (value - strength) * 2;
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
                if (value > MaxDexterity)
                {

                }
                else
                {
                    Damage += (value - dexterity) * 4;
                    PhysDef += (value - dexterity) * 1.5;

                    dexterity = value;
                }

            }
        }
        public override int Constitution
        {
            get { return constitution; }
            set
            {
                if (value > MaxConstitution)
                {

                }
                else
                {
                    HP += (value - constitution) * 6;

                    constitution = value;
                }

            }
        }
        public override int Inteligence
        {
            get { return inteligence; }
            set
            {
                if (value > MaxInteligence)
                {

                }
                else
                {
                    MP += (value - inteligence) * 1.5;
                    MagDamage += (value - inteligence) * 2;

                    inteligence = value;
                }

            }
        }
        public Rogue()
		{
            MaxStrength = 55;
            MaxDexterity = 250;
            MaxConstitution = 80;
            MaxInteligence = 70;
            Strength = 15;
            Dexterity = 30;
            Constitution = 20;
            Inteligence = 15;
        }
	}
}
