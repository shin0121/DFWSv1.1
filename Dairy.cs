﻿using System;
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
    public partial class Dairy : Form
    {
        public Dairy()
        {
            InitializeComponent();
        }

        private void Dairy_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage home = new Homepage();
            home.Show();
        }
    }
}
