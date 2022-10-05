using CharactersData;
using Characters;

namespace ItemsCreator
{
    public partial class ItemsCreator : Form
    {
        public ItemsCreator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbName.Text != "" && cmbType.SelectedItem != null 
                && cmbClass.SelectedItem != null && tbLvl.Text != "" 
                && tbHP.Text != "" && tbMP.Text != "" && tbDamage.Text != "" 
                && tbPhysDef.Text != "" && tbMagDamage.Text != "")
            {
                Database.AddItemToDatabase(new Item(tbName.Text, cmbClass.SelectedItem.ToString(), 
                    cmbType.SelectedItem.ToString(), int.Parse(tbLvl.Text), int.Parse(tbHP.Text), 
                    int.Parse(tbMP.Text), int.Parse(tbDamage.Text), 
                    int.Parse(tbPhysDef.Text), int.Parse(tbMagDamage.Text)));

                tbName.Text = "";
                cmbType.SelectedItem = null;
                cmbClass.SelectedItem = null;
                tbLvl.Text = ""; tbHP.Text = "";
                tbMP.Text = "";
                tbDamage.Text = "";
                tbPhysDef.Text = "";
                tbMagDamage.Text = "";
            }
            else
            {
                MessageBox.Show("Fill in all fields!", "Error!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}