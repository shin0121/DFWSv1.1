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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void FruitsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fruits fruits = new Fruits();
            fruits.Show();
        }

        private void VegButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vegetables vegetables = new Vegetables();
            vegetables.Show();
        }

        private void GrainsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grains grains = new Grains();
            grains.Show();
        }

        private void ProteinButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Protein protein = new Protein();
            protein.Show();
        }

        private void DairyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dairy dairy = new Dairy();
            dairy.Show();
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            More more=new More();
            more.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit edit = new Edit();
            edit.Show();
        }
    }
}
