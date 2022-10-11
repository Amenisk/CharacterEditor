using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace CharacterEditor
{
    public partial class CharacterStats : Form
    {
        public CharacterStats(Character character)
        {
            InitializeComponent();
            FillingCharacteristics(character);
        }

        private void FillingCharacteristics(Character ch)
        {
            tbName.Text = ch.Name;
            tbStrength.Text = ch.Strength.ToString();
            tbDexterity.Text = ch.Dexterity.ToString();
            tbConstitution.Text = ch.Constitution.ToString();
            tbInteligence.Text = ch.Inteligence.ToString();
            tbLvl.Text = ch.Level.ToString();
            tbLvlPoints.Text = ch.LevelPoints.ToString();
            tbNextLvlPoints.Text = ch.NextLevelPoints.ToString();
            tbHP.Text = ch.HP.ToString();
            tbMP.Text = ch.MP.ToString();
            tbDamage.Text = ch.Damage.ToString();
            tbPhysDef.Text = ch.PhysDef.ToString();
            tbMagDamage.Text = ch.MagDamage.ToString();

            foreach(var item in ch.inventory)
            {
                cmbInventory.Items.Add(item.Name);
                CalculateBuffsFromItem(item, ch.ClassName);
            }

            foreach(var abil in ch.CharacterAbilities)
            {
                cmbAbilities.Items.Add(abil);
            }
        }

        private void CalculateBuffsFromItem(Item item, string className)
        {
            tbStrength.Text = (int.Parse(tbStrength.Text) + item.IncStrength).ToString();
            tbDexterity.Text = (int.Parse(tbDexterity.Text) + item.IncDexterity).ToString();
            tbConstitution.Text = (int.Parse(tbConstitution.Text) + item.IncConstitution).ToString();
            tbInteligence.Text = (int.Parse(tbInteligence.Text) + item.IncInteligence).ToString();
            tbHP.Text = (int.Parse(tbHP.Text) + item.IncHP).ToString();
            tbMP.Text = (double.Parse(tbMP.Text) + item.IncMP).ToString();
            tbDamage.Text = (int.Parse(tbDamage.Text) + item.IncDamage).ToString();
            tbPhysDef.Text = (double.Parse(tbPhysDef.Text) + item.IncPhysDefense).ToString();
            tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + item.IncMagDamage).ToString();

            switch (className)
            {
                case "Warrior":
                    tbHP.Text = (int.Parse(tbHP.Text) +
                        (2 * item.IncStrength + 10 * item.IncConstitution)).ToString();
                    tbMP.Text = (double.Parse(tbMP.Text) + item.IncInteligence).ToString();
                    tbDamage.Text = (int.Parse(tbDamage.Text) +
                        (5 * item.IncStrength + item.IncDexterity)).ToString();
                    tbPhysDef.Text = (double.Parse(tbPhysDef.Text) +
                        (item.IncDexterity + 2 * item.IncConstitution)).ToString();
                    tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + item.IncMagDamage).ToString();
                    break;

                case "Rogue":
                    tbHP.Text = (int.Parse(tbHP.Text) +
                        (item.IncStrength + 6 * item.IncConstitution)).ToString();
                    tbMP.Text = (double.Parse(tbMP.Text) + 1.5 * item.IncInteligence).ToString();
                    tbDamage.Text = (int.Parse(tbDamage.Text) + 
                        (2 * item.IncStrength + 4 * item.IncDexterity)).ToString();
                    tbPhysDef.Text = (double.Parse(tbPhysDef.Text) +
                        (1.5 * item.IncDexterity)).ToString();
                    tbMagDamage.Text = (int.Parse(tbMagDamage.Text) +2 * item.IncMagDamage).ToString();
                    break;

                case "Wizard":
                    tbHP.Text = (int.Parse(tbHP.Text) +
                        (item.IncStrength + 3 * item.IncConstitution)).ToString();
                    tbMP.Text = (double.Parse(tbMP.Text) + 2 * item.IncInteligence).ToString();
                    tbDamage.Text = (int.Parse(tbDamage.Text) + 3 * item.IncStrength).ToString();
                    tbPhysDef.Text = (double.Parse(tbPhysDef.Text) +
                        (0.5 * item.IncDexterity + item.IncConstitution)).ToString();
                    tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + 5 * item.IncMagDamage).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
