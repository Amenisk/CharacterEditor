using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharactersData;
using Core;

namespace CharacterEditor
{
    public partial class Game : Form
    {
        private Match match = new Match();
        public Game()
        {
            InitializeComponent();
        }
        private void btnAutoGeneration_Click(object sender, EventArgs e)
        {
            CharacterInfo ch1;
            CharacterInfo ch2;

            while ((ch1 = Database.GetRandomCharacter
                (GetNameList())) != null && lbFirstTeam.Items.Count < 6)
            {
                lbFirstTeam.Items.Add(ch1.Name);
                if ((ch2 = Database.GetCharacterWithParams
                    (GetNameList(), ch1.Level)) == null)
                {
                    lbFirstTeam.Items.Remove(ch1.Name);
                    break;
                }

                lbSecondTeam.Items.Add(ch2.Name);
                match.AddCharacterToTeam(ch1, 1);
                match.AddCharacterToTeam(ch2, 2);
            }

            IsBalansed();
        }
        private void Match_Load(object sender, EventArgs e)
        {
            ClearForm();
            List<string> names = Database.OutputListNames();
            LoadMatches();
            foreach (var name in names)
            {
                cmbNames1.Items.Add(name);
                cmbNames2.Items.Add(name);
            }
        }
        private void ClearForm()
        {
            lbFirstTeam.Items.Clear();
            lbSecondTeam.Items.Clear();
            cmbNames1.Items.Clear();
            cmbNames2.Items.Clear();
            tbIsBalansed.BackColor = Color.LightGray;
            tbIsBalansed.Text = "";
        }
        private void btnSelect1_Click(object sender, EventArgs e)
        {
            if(cmbNames1.SelectedItem != null && lbFirstTeam.Items.Count <= 6)
            {
                Character ch = Database.FindByName((string)cmbNames1.SelectedItem);

                lbFirstTeam.Items.Add(cmbNames1.SelectedItem);
                match.AddCharacterToTeam
                    (new CharacterInfo(ch.Name, ch.Level), 1);
                cmbNames2.Items.Remove(cmbNames1.SelectedItem);
                cmbNames1.Items.Remove(cmbNames1.SelectedItem);
                IsBalansed();
            }
        }
        private void btnSelect2_Click(object sender, EventArgs e)
        {
            if (cmbNames2.SelectedItem != null && lbFirstTeam.Items.Count <= 6)
            {
                Character ch = Database.FindByName((string)cmbNames2.SelectedItem);

                lbSecondTeam.Items.Add(cmbNames2.SelectedItem);
                match.AddCharacterToTeam
                    (new CharacterInfo(ch.Name, ch.Level), 2);
                cmbNames1.Items.Remove(cmbNames2.SelectedItem);
                cmbNames2.Items.Remove(cmbNames2.SelectedItem);
                IsBalansed();
            }
        }
        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if(lbFirstTeam.SelectedItem != null)
            {
                cmbNames1.Items.Add(lbFirstTeam.SelectedItem);
                cmbNames2.Items.Add(lbFirstTeam.SelectedItem);
                match.RemoveCharacterFromTeam
                    ((string) lbFirstTeam.SelectedItem, 1);
                lbFirstTeam.Items.Remove(lbFirstTeam.SelectedItem);
                IsBalansed();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (lbSecondTeam.SelectedItem != null)
            {
                cmbNames1.Items.Add(lbSecondTeam.SelectedItem);
                cmbNames2.Items.Add(lbSecondTeam.SelectedItem);
                match.RemoveCharacterFromTeam
                    ((string) lbSecondTeam.SelectedItem, 2);
                lbSecondTeam.Items.Remove(lbSecondTeam.SelectedItem);
                IsBalansed();
            }
        }

        private void IsBalansed()
        {
            if(match.IsBalansed())
            {
                tbIsBalansed.Text = "Teams are balanced";
                tbIsBalansed.BackColor = Color.Green;
            }
            else
            {
                tbIsBalansed.Text = "Teams are not balanced";
                tbIsBalansed.BackColor = Color.Red;
            }
        }

        private void cmbNames1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            if(lbFirstTeam.Items.Count != 0 && lbSecondTeam.Items.Count != 0 
                && match.IsBalansed())
            {
                match.SaveTime();
                Database.SaveMatch(match);
                Match_Load(sender, e);
                LoadMatches();
                match = new Match();
            }
            else
            {
                MessageBox.Show("Teams are not balansed or dont have characters!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMatches()
        {
            cmbMatches.Items.Clear();
            List<String> matches = Database.OutputListMatches();

            foreach(var match in matches)
            {
                cmbMatches.Items.Add(match);
            }
        }

        private void btnLoadMatch_Click(object sender, EventArgs e)
        {
            if(cmbMatches.SelectedItem != null)
            {
                match = Database.LoadMatch((string)cmbMatches.SelectedItem);
        
                Match_Load(sender, e);
                OpenButtonsAndComboBoxes(false);

                foreach(var ch in match.FirstTeam)
                {
                    lbFirstTeam.Items.Add(ch.Name);
                }

                foreach (var ch in match.SecondTeam)
                {
                    lbSecondTeam.Items.Add(ch.Name);
                }
            }
        }

        private void OpenButtonsAndComboBoxes(bool isOpen)
        {
            cmbNames1.Visible = isOpen;
            cmbNames2.Visible = isOpen;
            btnAutoGeneration.Visible = isOpen;
            btnSelect1.Visible = isOpen;
            btnSelect2.Visible = isOpen;
            btnDelete1.Visible = isOpen;
            btnDelete2.Visible = isOpen;
            btnStartGame.Visible = isOpen;
            tbIsBalansed.Visible = isOpen;
            btnCharacter1.Visible = !isOpen;
            btnCharacter2.Visible = !isOpen;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Match_Load(sender, e);
            OpenButtonsAndComboBoxes(true);
            match = new Match();
        }

        private void btnCharacter1_Click(object sender, EventArgs e)
        {
            if(lbFirstTeam.SelectedItem != null)
            {
                CharacterStats newForm = new CharacterStats
                (Database.FindByName((string)lbFirstTeam.SelectedItem));
                newForm.Show();
            }
        }

        private void btnCharacter2_Click(object sender, EventArgs e)
        {
            if (lbSecondTeam.SelectedItem != null)
            {
                CharacterStats newForm = new CharacterStats
                (Database.FindByName((string)lbSecondTeam.SelectedItem));
                newForm.Show();
            }
        }

        private List<string> GetNameList()
        {
            List<string> names = new List<string>();

            foreach(var name in lbFirstTeam.Items)
            {
                names.Add((string) name);
            }

            foreach (var name in lbSecondTeam.Items)
            {
                names.Add((string) name);
            }

            return names;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
