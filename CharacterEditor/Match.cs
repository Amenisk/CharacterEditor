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

namespace CharacterEditor
{
    public partial class Match : Form
    {
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

        private void cmbNames1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
