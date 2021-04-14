using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        [STAThread]
        public void button2_Click(object sender, EventArgs e)
        {
            //test
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {

                textBox1.Text = dialog.FileName;
                lvrdir = (dialog.FileName);
                MessageBox.Show(lvrdir+" _|_", "Your comupter has virus",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ///Worker.Conversion();

                ///textBox1.Text = dialog.FileName; 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Arbeiter.Conversion(lvrdir);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void qmbtn_click(object sender, EventArgs e)
        {

        }
    }
}