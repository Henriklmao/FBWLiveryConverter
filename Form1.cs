using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add("folder");

            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            if (file != null)
            {
                // Application now has read/write access to the picked file
                this.textBlock.Text = "Picked folder: " + file.Name;
            }
            else
            {
                this.textBlock.Text = "Operation cancelled.";
            }
            string lvrdir = (file);
            MessageBox.Show(lvrdir, "Exception: Livery file missing",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Worker.Conversion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
