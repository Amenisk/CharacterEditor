using Characters;
using CharactersData;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace CharacterEditor
{
    public partial class CharacterEditor : Form
    {
        private Character _selectedCharacter;
        private bool isLoaded;
        private string loadName;
        public CharacterEditor()
        {
            InitializeComponent();
            BsonClassMap.RegisterClassMap<Character>();
            BsonClassMap.RegisterClassMap<Wizard>();
            BsonClassMap.RegisterClassMap<Rogue>();
            BsonClassMap.RegisterClassMap<Warrior>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbNames.Items.Clear();
            List<string> names = Database.OutputListNames();
            foreach (var name in names)
            {
                cmbNames.Items.Add(name);
            }

        }
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            if (lbCharacters.SelectedItem != null && tbName.Text != "")
            {
                switch (lbCharacters.SelectedItem.ToString())
                {
                    case "Warrior":
                        _selectedCharacter = new Warrior();
                        break;

                    case "Rogue":
                        _selectedCharacter = new Rogue();
                        break;

                    case "Wizard":
                        _selectedCharacter = new Wizard();
                        break;

                    default:
                        break;
                }

                _selectedCharacter.SetName(tbName.Text.ToString());
                FillingInCharacteristics();
                tbCountOfPoints.Text = _selectedCharacter.NumberOfPoints.ToString();
                isLoaded = false;
                FillingAddAbility();
                EquipmentFilling();
            }
            else
            {
                MessageBox.Show($"Select character and enter his name", "Error!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FillingInCharacteristics()
        {
            tbStrength.Text = _selectedCharacter.Strength.ToString();
            tbDexterity.Text = _selectedCharacter.Dexterity.ToString();
            tbConstitution.Text = _selectedCharacter.Constitution.ToString();
            tbInteligence.Text = _selectedCharacter.Inteligence.ToString();
            tbHP.Text = _selectedCharacter.HP.ToString();
            tbMP.Text = _selectedCharacter.MP.ToString();
            tbDamage.Text = _selectedCharacter.Damage.ToString();
            tbPhysDef.Text = _selectedCharacter.PhysDef.ToString();
            tbMagDamage.Text = _selectedCharacter.MagDamage.ToString();
            tbCountOfPoints.Text = _selectedCharacter.NumberOfPoints.ToString();
            tbName.Text = _selectedCharacter.Name.ToString();
            tbLvlPoints.Text = _selectedCharacter.LevelPoints.ToString();
            tbNextLvlPoints.Text = _selectedCharacter.NextLevelPoints.ToString();
            tbLvl.Text = _selectedCharacter.Level.ToString();
        }
        private void btnIncreaseStrength_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null && _selectedCharacter.NumberOfPoints > 0
                && _selectedCharacter.Strength + 1 <= _selectedCharacter.MaxStrength)
            {
                _selectedCharacter.Strength++;
                AfterIncreasing();
            }
        }
        private void btnIncreaseDexterity_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null && _selectedCharacter.NumberOfPoints > 0
                && _selectedCharacter.Dexterity + 1 <= _selectedCharacter.MaxDexterity)
            {
                _selectedCharacter.Dexterity++;
                AfterIncreasing();
            }
        }
        private void btnIncreaseConstitution_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null && _selectedCharacter.NumberOfPoints > 0
                && _selectedCharacter.Constitution + 1 <= _selectedCharacter.MaxConstitution)
            {
                _selectedCharacter.Constitution++;
                AfterIncreasing();
            }
        }
        private void btnIncreaseInteligence_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null && _selectedCharacter.NumberOfPoints > 0
                && _selectedCharacter.Inteligence + 1 <= _selectedCharacter.MaxInteligence)
            {
                _selectedCharacter.Inteligence++;
                AfterIncreasing();
            }
        }
        private void AfterIncreasing()
        {
            _selectedCharacter.NumberOfPoints--;
            FillingInCharacteristics();
        }
        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            if (tbName.Text != "")
            {
                if (!isLoaded)
                {
                    Database.AddToDatabase(_selectedCharacter);
                }
                else
                {
                    _selectedCharacter.SetName(tbName.Text);
                    Database.ReplaceByName(loadName, _selectedCharacter);
                }
                Form1_Load(sender, e);

                tbStrength.Text = "";
                tbDexterity.Text = "";
                tbConstitution.Text = "";
                tbInteligence.Text = "";
                tbHP.Text = "";
                tbMP.Text = "";
                tbDamage.Text = "";
                tbPhysDef.Text = "";
                tbMagDamage.Text = "";
                tbCountOfPoints.Text = "";
                tbName.Text = "";
                tbLvl.Text = "";
                tbNextLvlPoints.Text = "";
                tbLvlPoints.Text = "";
                cmbInventory.Items.Clear();
                cmbWeapons.Items.Clear();
                cmbHelmets.Items.Clear();
                cmbArmors.Items.Clear();

                isLoaded = false;
            }

        }
        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNames.SelectedItem != null)
            {
                _selectedCharacter = Database.FindByName(cmbNames.SelectedItem.ToString());
                FillingInCharacteristics();
                cmbInventory.Items.Clear();
                foreach (var item in _selectedCharacter.inventory)
                {
                    cmbInventory.Items.Add(item.Name);
                }
                isLoaded = true;
                loadName = _selectedCharacter.Name;
                FillingAddAbility();
                FillingAbilities();
                EquipmentFilling();
                CalculateInventoryBuffs();
            }
        }

        private void btnPlus1000Lvl_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null)
            {
                _selectedCharacter.LevelPoints += 1000;
                tbLvlPoints.Text = _selectedCharacter.LevelPoints.ToString();
                SwitchToNextLvl();
            }
        }
        private void btnPlus100Lvl_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null)
            {
                _selectedCharacter.LevelPoints += 100;
                tbLvlPoints.Text = _selectedCharacter.LevelPoints.ToString();
                SwitchToNextLvl();
            }
        }
        private void btnPlus500Lvl_Click(object sender, EventArgs e)
        {
            if (_selectedCharacter != null)
            {
                _selectedCharacter.LevelPoints += 500;
                tbLvlPoints.Text = _selectedCharacter.LevelPoints.ToString();
                SwitchToNextLvl();
            }
        }
        private void SwitchToNextLvl()
        {
            if (_selectedCharacter.LevelPoints >= _selectedCharacter.NextLevelPoints)
            {
                _selectedCharacter.Level++;
                _selectedCharacter.NextLevelPoints += 1000 * _selectedCharacter.Level;
                tbLvl.Text = _selectedCharacter.Level.ToString();
                tbNextLvlPoints.Text = _selectedCharacter.NextLevelPoints.ToString();
                _selectedCharacter.NumberOfPoints += 5;
                tbCountOfPoints.Text = _selectedCharacter.NumberOfPoints.ToString();
                EquipmentFilling();

                if (_selectedCharacter.Level % 3 == 0)
                {
                    _selectedCharacter.abilityCount++;
                }

                if (_selectedCharacter.abilityCount > 0)
                {
                    cmbAddAbility.Enabled = true;
                    btnAddAbility.Enabled = true;
                }
            }
        }
        private void FillingAbilities()
        {
            cmbAbilities.Items.Clear();
            foreach (var ability in _selectedCharacter.CharacterAbilities)
            {
                cmbAbilities.Items.Add(ability);
            }
        }
        private void FillingAddAbility()
        {
            cmbAddAbility.Items.Clear();
            foreach (var ability in _selectedCharacter.Abilities)
            {
                cmbAddAbility.Items.Add(ability);
            }
        }
        private void btnAddAbility_Click(object sender, EventArgs e)
        {
            if (cmbAddAbility.SelectedItem != null)
            {
                _selectedCharacter.CharacterAbilities.Add(cmbAddAbility.SelectedItem.ToString());
                _selectedCharacter.Abilities.Remove(cmbAddAbility.SelectedItem.ToString());
                FillingAbilities();
                FillingAddAbility();
                _selectedCharacter.abilityCount--;

                if (_selectedCharacter.abilityCount < 1)
                {
                    cmbAddAbility.Enabled = false;
                    btnAddAbility.Enabled = false;
                }
            }
        }

        private void btnSelectWeapon_Click(object sender, EventArgs e)
        {
            SelectItem("Weapon", cmbWeapons.SelectedItem.ToString());
            cmbWeapons.SelectedItem = null;
        }

        private void cmbWeapons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EquipmentFilling()
        {
            var weapons = Database.GetNameEquipment(_selectedCharacter, "Weapon");
            var helmets = Database.GetNameEquipment(_selectedCharacter, "Helmet");
            var armors = Database.GetNameEquipment(_selectedCharacter, "Armor");
            cmbWeapons.Items.Clear();
            cmbHelmets.Items.Clear();
            cmbArmors.Items.Clear();

            foreach (var weapon in weapons)
            {
                cmbWeapons.Items.Add(weapon);
            }

            foreach (var helmet in helmets)
            {
                cmbHelmets.Items.Add(helmet);
            }

            foreach (var armor in armors)
            {
                cmbArmors.Items.Add(armor);
            }
        }

        private void SelectItem(string type, string nameItem)
        {
            if (nameItem != null)
            {
                if (isLoaded)
                {
                    Item item = Database.FindItemByName
                       (nameItem, type);

                    foreach (var it in _selectedCharacter.inventory)
                    {
                        if (it.Type == type)
                        {
                            cmbInventory.Items.Remove(it.Name);
                            CalculateBuffsFromItem(it, false);
                            _selectedCharacter.inventory.Remove(it);
                            break;
                        }
                    }

                    _selectedCharacter.inventory.Add(item);
                    cmbInventory.Items.Add(item.Name);
                    CalculateBuffsFromItem(item, true);
                    Database.UpdateInventory(_selectedCharacter.Name, _selectedCharacter.inventory);
                }
                else
                {
                    MessageBox.Show("Save or select the character first!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSelecthelmet_Click(object sender, EventArgs e)
        {
            SelectItem("Helmet", cmbHelmets.SelectedItem.ToString());
            cmbHelmets.SelectedItem = null;
        }

        private void btnSelectArmor_Click(object sender, EventArgs e)
        {
            SelectItem("Armor", cmbArmors.SelectedItem.ToString());
            cmbArmors.SelectedItem = null;
        }

        private void CalculateBuffsFromItem(Item item, bool isSelect)
        {
            int x = 1;
            if (!isSelect) x = -1;

            tbStrength.Text = (int.Parse(tbStrength.Text) + x * item.IncStrength).ToString();
            tbDexterity.Text = (int.Parse(tbDexterity.Text) + x * item.IncDexterity).ToString();
            tbConstitution.Text = (int.Parse(tbConstitution.Text) + x * item.IncConstitution).ToString();
            tbInteligence.Text = (int.Parse(tbInteligence.Text) + x * item.IncInteligence).ToString();
            tbHP.Text = (int.Parse(tbHP.Text) + x * item.IncHP).ToString();
            tbMP.Text = (int.Parse(tbMP.Text) + x * item.IncMP).ToString();
            tbDamage.Text = (int.Parse(tbDamage.Text) + x * item.IncDamage).ToString();
            tbPhysDef.Text = (int.Parse(tbPhysDef.Text) + x * item.IncPhysDefense).ToString();
            tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + x * item.IncMagDamage).ToString();

            switch (_selectedCharacter.ClassName)
            {
                case "Warrior":
                    tbHP.Text = (int.Parse(tbHP.Text) + x * 
                        (2 * item.IncStrength + 10 * item.IncConstitution)).ToString();
                    tbMP.Text = (double.Parse(tbMP.Text) + x * item.IncInteligence).ToString();
                    tbDamage.Text = (int.Parse(tbDamage.Text) + x * 
                        (5 * item.IncStrength + item.IncDexterity)).ToString();
                    tbPhysDef.Text = (double.Parse(tbPhysDef.Text) + x * 
                        (item.IncDexterity  + 2 * item.IncConstitution)).ToString();
                    tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + x * item.IncMagDamage).ToString();
                    break;

                case "Rogue":
                    tbHP.Text = (int.Parse(tbHP.Text) + x *
                        (item.IncStrength + 6 * item.IncConstitution)).ToString();
                    tbMP.Text = (double.Parse(tbMP.Text) + x * 1.5 * item.IncInteligence).ToString();
                    tbDamage.Text = (int.Parse(tbDamage.Text) + x *
                        (2 * item.IncStrength + 4 * item.IncDexterity)).ToString();
                    tbPhysDef.Text = (double.Parse(tbPhysDef.Text) + x *
                        (1.5 * item.IncDexterity)).ToString();
                    tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + x * 2 * item.IncMagDamage).ToString();
                    break;

                case "Wizard":
                    tbHP.Text = (int.Parse(tbHP.Text) + x *
                        (item.IncStrength + 3 * item.IncConstitution)).ToString();
                    tbMP.Text = (double.Parse(tbMP.Text) + x * 2 * item.IncInteligence).ToString();
                    tbDamage.Text = (int.Parse(tbDamage.Text) + x * 3 * item.IncStrength).ToString();
                    tbPhysDef.Text = (double.Parse(tbPhysDef.Text) + x *
                        (0.5 * item.IncDexterity + item.IncConstitution)).ToString();
                    tbMagDamage.Text = (int.Parse(tbMagDamage.Text) + x * 5 * item.IncMagDamage).ToString();
                    break;

                default:
                    break;
            }
        }

        private void CalculateInventoryBuffs()
        {
            foreach(var item in _selectedCharacter.inventory)
            {
                CalculateBuffsFromItem(item, true);
            }
        }
    }
}