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
    public partial class Keyboard : Form
    {
        public Keyboard()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }

        private void Keyboard_Load(object sender, EventArgs e)
        {

        }

        private void txtGoal_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b1.Text;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b2.Text;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b3.Text;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b4.Text;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b5.Text;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b6.Text;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b7.Text;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b8.Text;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtGoal.Text = txtGoal.Text + b9.Text;
        }
    }
}
