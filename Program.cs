using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveryConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    static class Worker
    {
        private static void Isliveryvalid()
        {
            string lvrdir = "test"; /// Just for testing
            if (File.Exists(lvrdir + "/manifest.json"))
            {

            }
            else
            {
                MessageBox.Show("The Livery you've selected seems invalid. Please read the documentations.", "Error: Invalid Livery",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                if (File.Exists(lvrdir + "/SimObjects/Airplanes/*/aircraft.cfg"))
                {
                    /// Backup aircraft.cfg
                    System.IO.File.Move("/SimObjects/Airplanes/*/aircraft.cfg", "/SimObjects/Airplanes/*/.aircraft.cfg");
                    /// Edit aircraft.cfg
                    string text0 = File.ReadAllText("/SimObjects/Airplanes/*/.aircraft.cfg");
                    string replace0 = text0.Replace("base_container = \"..\\Asobo_A320_NEO\"", "base_container = \"..\\FlyByWire_A320_NEO\"");
                    File.WriteAllText("/SimObjects/Airplanes/*/aircraft.cfg", replace0);

                    string text1 = File.ReadAllText("/SimObjects/Airplanes/*/aircraft.cfg");
                    string replace1 = text1.Replace("base_container = \"../Asobo_A320_NEO\"", "base_container = \"..\\FlyByWire_A320_NEO\"");
                    File.WriteAllText("/SimObjects/Airplanes/*/aircraft.cfg", replace1);
                }
                else
                {
                    MessageBox.Show("The aircraft.cfg file of the selected livery couldn't be found. Please read the documentations.", "Exception: Livery file missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (File.Exists(lvrdir + "/SimObjects/Airplanes/*/model.main/model.cfg"))
                {
                    /// Backup model.cfg
                    System.IO.File.Move("/SimObjects/Airplanes/*/model.main/model.cfg", "/SimObjects/Airplanes/*/model.main/model.cfg");
                    /// Edit model.cfg
                    string text2 = File.ReadAllText("/SimObjects/Airplanes/*/model.main/.model.cfg");
                    string replace2 = text2.Replace("exterior = .. / .. / Asobo_A320_NEO / model / A320_NEO.xml", "exterior=../../FlyByWire_A320_NEO/model/A320_NEO.xml");
                    File.WriteAllText("output file", replace2);

                    string text3 = File.ReadAllText("/SimObjects/Airplanes/*/model.main/.model.cfg");
                    string replace3 = text2.Replace("exterior = .. / .. / Asobo_A320_NEO / model / A320_NEO.xml", "exterior=../../FlyByWire_A320_NEO/model/A320_NEO.xml");
                    File.WriteAllText("output file", replace3);
                }
                else
                {
                    MessageBox.Show("The aircraft.cfg file of the selected livery couldn't be found. Please read the documentations.", "Exception: Livery file missing",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}



/* Notes

for Replacing strings:

string text = File.ReadAllText("input file");
replace = text.Replace("what to replace", "with replace");
File.WriteAllText("output file", replace);

*/