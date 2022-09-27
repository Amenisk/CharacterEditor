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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    Database.AddToDataBase(_selectedCharacter);
                }
                else
                {
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
                cmbInventory.Items.Clear();
                isLoaded = false;
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbChooseCharacter_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNames.SelectedItem != null)
            {
                _selectedCharacter = Database.FindByName(cmbNames.SelectedItem.ToString());
                FillingInCharacteristics();
                foreach(var item in _selectedCharacter.inventory)
                {
                    cmbInventory.Items.Add(item.Name);
                }
                isLoaded = true;
                loadName = _selectedCharacter.Name;
            }
        }

        private void cmbNames_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tbTextPhysDef_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(tbAddItem.Text != "" && _selectedCharacter != null)
            {
                Item item = new Item(tbAddItem.Text);
                _selectedCharacter.AddToInventory(item);
                cmbInventory.Items.Add(tbAddItem.Text);
                tbAddItem.Text = "";
            }
        }
    }
}