using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DFWSv1._1
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'upDBDataSet.tblUP' table. You can move, or remove it, as needed.
            this.tblUPTableAdapter.Fill(this.upDBDataSet.tblUP);

        }

        private void Edit(bool value)
        {
            NameTxtBox.Enabled = value;
            AgeTxtBox.Enabled = value;
            SexTxtBox.Enabled = value;
            WeightTxtBox.Enabled = value;
            HeightTxtBox.Enabled = value;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Edit(true);
            NameTxtBox.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                tblUPBindingSource.EndEdit();
                tblUPTableAdapter.Update(upDBDataSet.tblUP);
                MessageBox.Show("Saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                upDBDataSet.tblUP.RejectChanges();
            }
        }
    }
}
