﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;


///  lvrdir

namespace LiveryConverter
{
    public partial class Form1 : Form
    {
        public string lvrdir;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///.
        }

        public void button2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {


                lvrdir = (dialog.FileName);
                MessageBox.Show(lvrdir+" _|_", "Your comupter has virus",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                ///Worker.Conversion();

                ///textBox1.Text = dialog.FileName; 
            }
        }
    }
}