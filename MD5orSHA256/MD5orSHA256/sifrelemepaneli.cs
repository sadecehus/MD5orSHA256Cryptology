﻿using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace example
{
    public partial class SifrelemePaneli : Form
    {   
        public SifrelemePaneli()
        {
            InitializeComponent();
            
        }

        private void sifreBox_TextChanged_1(object sender, EventArgs e)
        {
            md5Box.Text = sifreleme.md5sifreleme(sifreBox.Text);
            md5lengthlabel.Text = md5Box.TextLength.ToString();
            //--------------------------------------------------//
            shaBox.Text = sifreleme.shaSifreleme(sifreBox.Text);
            shalengthlabel.Text = shaBox.Text.Length.ToString();

        }
    }
}