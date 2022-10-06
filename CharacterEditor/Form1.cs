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

                    if (!CheckParams(item, _selectedCharacter))
                    {
                        MessageBox.Show("This item not suitable for chis character!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    foreach (var it in _selectedCharacter.inventory)
                    {
                        if (it.Type == type)
                        {
                            cmbInventory.Items.Remove(it.Name);
                            _selectedCharacter.RemoveBuffsFromItem(it);
                            _selectedCharacter.inventory.Remove(it);
                            break;
                        }
                    }

                    _selectedCharacter.inventory.Add(item);
                    cmbInventory.Items.Add(item.Name);
                    _selectedCharacter.GetBuffsFromItem(item);
                    Database.ReplaceByName(_selectedCharacter.Name, _selectedCharacter);

                    tbHP.Text = _selectedCharacter.HP.ToString();
                    tbMP.Text = _selectedCharacter.MP.ToString();
                    tbDamage.Text = _selectedCharacter.Damage.ToString();
                    tbPhysDef.Text = _selectedCharacter.PhysDef.ToString();
                    tbMagDamage.Text = _selectedCharacter.MagDamage.ToString();
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

        private bool CheckParams(Item item, Character ch)
        {
            return  ch.HP + item.IncMP >= 0 && ch.MP + item.IncMP >= 0 
                && ch.Damage + item.IncDamage >= 0 && ch.PhysDef + item.IncPhysDefense >= 0 
                && ch.MagDamage + item.IncMagDamage >= 0;
        }
    }
}