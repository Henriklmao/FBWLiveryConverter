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


///  seldir

namespace LiveryConverter
{
    public partial class Form1 : Form
    {
        public string seldir;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            backupbtn.Visible = false;
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
                seldir = (dialog.FileName);
                if (File.Exists(seldir + "\\.LiveryConverter"))
                {
                    backupbtn.Visible = true;
                    button1.Visible = false;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(seldir + "/manifest.json"))
            {
                Worker.Conversion(seldir);
            }
            else
            {
                MessageBox.Show("The Livery you've selected seems invalid. Please read the documentations on how to select the livery the right way.", "Error: Invalid Livery",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Restart.RestartProgram();
            }
        }

        private void Rollback_Click(object sender, EventArgs e)
        {
            Worker.Rollback(seldir);
        }

        private void qmbtn_click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Henriklmao/FBWLiveryConverter/blob/main/DOCS/Docs.md");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}