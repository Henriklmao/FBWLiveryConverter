﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// This is all the backend-code of the application. The gui is just fancy stuff, this here is the real shit.
/// </summary>

namespace LiveryConverter
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class Worker
    {

        public static void Conversion(string seldir)
        {

            string[] lvrarr = Directory.GetFiles(seldir + "\\SimObjects\\Airplanes\\", "aircraft.cfg", SearchOption.AllDirectories); /// Searching for x name in Simobjects/Airplanes/x/
            string lvrdir = lvrarr[0];
            if (File.Exists(lvrdir + @"\..\aircraft.cfg"))
            {
                /// Backup aircraft.cfg
                System.IO.File.Move(lvrdir + @"\..\aircraft.cfg", lvrdir + @"\..\.aircraft.cfg");
                /// Edit aircraft.cfg
                string text1 = File.ReadAllText(lvrdir + @"\..\.aircraft.cfg");
                string replace1 = text1.Replace("Asobo_A320_NEO", "FlyByWire_A320_NEO");
                File.WriteAllText(lvrdir + @"\..\aircraft.cfg", replace1);
            }
            else
            {
                MessageBox.Show("The aircraft.cfg file of the selected livery couldn't be found. Please read the documentations.", "Exception: Livery file missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.RestartProgram();
            }
            if (File.Exists(lvrdir + @"\..\model.main\model.cfg"))
            {
                /// Backup model.cfg
                System.IO.File.Move(lvrdir + @"\..\model.main\model.cfg", lvrdir + @"\..\model.main\.model.cfg");
                /// Edit model.cfg
                string text2 = File.ReadAllText(lvrdir + @"\..\model.main\.model.cfg");
                string replace2 = text2.Replace("exterior=../../Asobo_A320_NEO/model/A320_NEO.xml", "exterior=../../FlyByWire_A320_NEO/model/A320_NEO.xml");
                File.WriteAllText(lvrdir + @"\..\model.main\model.cfg", replace2);

                string text3 = File.ReadAllText(lvrdir + @"\..\model.main\model.cfg");
                string replace3 = text2.Replace("exterior=..\\..\\Asobo_A320_NEO\\model\\A320_NEO.xml", "exterior=../../FlyByWire_A320_NEO/model/A320_NEO.xml");
                File.WriteAllText(lvrdir + @"\..\model.main\model.cfg", replace3);
            }
            else
            {
                MessageBox.Show("The model.cfg file of the selected livery couldn't be found. Please read the documentations.", "Exception: Livery file missing",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.RestartProgram();
            }
            Worker.TextureConfig(lvrdir);
        }

        public static void TextureConfig(string lvrdir)
        {
            string[] txtrarr = Directory.GetFiles(lvrdir + @"\..\", "texture.cfg", SearchOption.AllDirectories); /// Searching for x name in Simobjects/Airplanes/x/
            string txtrcfg = txtrarr[0];

            /// Backup texture.config
            System.IO.File.Move(txtrcfg + @"\..\texture.cfg", txtrcfg + @"\..\.texture.cfg");
            /// Create Standardized texture.cfg
            string[] stdtxtr = new string[1]
        {
                        "[fltsim]" + Environment.NewLine + Environment.NewLine +
                        "fallback.1 = ..\\..\\FlyByWire_A320_NEO\\TEXTURE" + Environment.NewLine +
                        "fallback.2 = ..\\..\\..\\..\\texture\\DetailMap" + Environment.NewLine +
                        "fallback.3 = ..\\..\\..\\..\\texture\\Glass" + Environment.NewLine +
                        "fallback.4 = ..\\..\\..\\..\\texture\\Interiors" + Environment.NewLine +
                        "fallback.5 = ..\\..\\..\\..\\texture" + Environment.NewLine +
                        "fallback.6 = ..\\texture"
        };

            File.WriteAllLines(txtrcfg, stdtxtr);

        MessageBox.Show("Conversion Finished", "Task failed sucessfull.",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Restart.RestartProgram();
            }
         }
     }

public static class Restart
    {
    public static void RestartProgram()
    {
        Application.Restart();
        Environment.Exit(0);
    }
}


/* Notes

for Replacing strings:

string textx = File.ReadAllText("input file");
replacex = textx.Replace("what to replace", "with replace");
File.WriteAllText("output file", replacex);



*/


