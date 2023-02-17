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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void Edit_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }

        private void goal_edit_Click(object sender, EventArgs e)
        {
            Keyboard kb = new Keyboard();
            kb.Show();
        }

        private void goal_label_Click(object sender, EventArgs e)
        {
            
        }
    }
}
