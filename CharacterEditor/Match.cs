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
    public partial class Match : Form
    {
        private Game match = new Game();
        public Match()
        {
            InitializeComponent();
        }
        private void btnAutoGeneration_Click(object sender, EventArgs e)
        {

        }
        private void Match_Load(object sender, EventArgs e)
        {
            cmbNames1.Items.Clear();
            cmbNames2.Items.Clear();
            List<string> names = Database.OutputListNames();
            foreach (var name in names)
            {
                cmbNames1.Items.Add(name);
                cmbNames2.Items.Add(name);
            }
        }
        private void btnSelect1_Click(object sender, EventArgs e)
        {
            if(cmbNames1.SelectedItem != null && lbFirstTeam.Items.Count <= 6)
            {
                lbFirstTeam.Items.Add(cmbNames1.SelectedItem);
                match.AddCharacterToTeam
                    (Database.FindByName((string) cmbNames1.SelectedItem), 1);
                cmbNames2.Items.Remove(cmbNames1.SelectedItem);
                cmbNames1.Items.Remove(cmbNames1.SelectedItem);
                IsBalansed();
            }
        }
        private void btnSelect2_Click(object sender, EventArgs e)
        {
            if (cmbNames2.SelectedItem != null && lbFirstTeam.Items.Count <= 6)
            {
                lbSecondTeam.Items.Add(cmbNames2.SelectedItem);
                match.AddCharacterToTeam
                    (Database.FindByName((string) cmbNames2.SelectedItem), 2);
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
                    (Database.FindByName((string) lbFirstTeam.SelectedItem), 1);
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
                    (Database.FindByName((string)lbSecondTeam.SelectedItem), 2);
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
    }
}
