using Characters;
using CharactersData;

namespace CharacterEditor
{
    public partial class CharacterEditor : Form
    {
        private Character _selectedCharacter;
        private bool isSaved;
        public CharacterEditor()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
                isSaved = false;
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
            isSaved = false;
        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            if (!isSaved && tbName.Text != "")
            {
                Database.AddToDataBase(_selectedCharacter);
                isSaved = true;
                Form1_Load(sender, e);
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
                isSaved = true;
            }
        }

        private void cmbNames_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}