﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class Parent : Form
    {
        

        public Parent(string role)
        {
            InitializeComponent();
            label1.Text = role;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FileDialog 
        }

        private void biodataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ss = new Form1();
            ss.MdiParent = this;
            ss.Show();
        }
    }
}
