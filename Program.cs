using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/// Flynas
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
            string lvrdir = lvrarr[0]; /// The Livery Directory is always saved with the \aircraft.cfg at the end, so we have to always go back down there.
            if (File.Exists(lvrdir + @"\..\aircraft.cfg"))
            {
                File.WriteAllText(seldir+"\\.LiveryConverter", "This livery got converted by the FBWLiveryConverter."+ Environment.NewLine + "If you experience any issues, please select the Livery and press the Rollback button.");
                /// Backup aircraft.cfg
                System.IO.File.Move(lvrdir + @"\..\aircraft.cfg", lvrdir + @"\..\.aircraft.cfg");
                /// Edit aircraft.cfg

                string text0 = File.ReadAllText(lvrdir + @"\..\.aircraft.cfg");
                string replace0 = text0.Replace("base_container = \"..\\Asobo_A320_NEO\"", "base_container = \"..\\FlyByWire_A320_NEO\"");
                File.WriteAllText(lvrdir, replace0);

                string text1 = File.ReadAllText(lvrdir);
                string replace1 = text1.Replace("base_container = \"../Asobo_A320_NEO\"", "base_container = \"..\\FlyByWire_A320_NEO\"");
                File.WriteAllText(lvrdir, replace1);
            }
            else
            {
                MessageBox.Show("The aircraft.cfg file of the selected livery couldn't be found. Please read the documentations.", "Exception: Livery file missing or corrupted",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Restart.RestartProgram();
            }

            string[] mdlarr = Directory.GetFiles(lvrdir + @"\..\", "model.cfg", SearchOption.AllDirectories);
            foreach (string mdlcfg in mdlarr)
            {
                System.IO.File.Move(mdlcfg, mdlcfg+@"\..\.model.cfg");

                string text2 = File.ReadAllText(mdlcfg+@"\..\.model.cfg");
                string replace2 = text2.Replace("Asobo_A320_NEO", "FlyByWire_A320_NEO");
                File.WriteAllText(mdlcfg, replace2);
            }
            Worker.TextureConfig(lvrdir);
        }

        public static void TextureConfig(string lvrdir)
        {
            string[] txtrarr = Directory.GetFiles(lvrdir + @"\..\", "texture.cfg", SearchOption.AllDirectories); /// Searching for x name in \texture.x\texture.cfg

            foreach (string txtrcfg in txtrarr)
            {
                /// Backup texture.config
                System.IO.File.Move(txtrcfg, txtrcfg + @"\..\.texture.cfg");
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
            }
        MessageBox.Show("Conversion finished, if it didn't work, please reselect the livery and press rollback", "LiveryConverter: Conversion complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Restart.RestartProgram();
            }

        public static void Rollback(string seldir)
        {
            string[] lvrarr = Directory.GetFiles(seldir + "\\SimObjects\\Airplanes\\", "aircraft.cfg", SearchOption.AllDirectories); /// Searching for x name in Simobjects/Airplanes/x/
            string lvrdir = lvrarr[0]; /// The Livery Directory is always saved with the \aircraft.cfg at the end, so we have to always go back down there.
            
            /// Rolling back aircraft.cfg
            File.Delete(lvrdir+@"\..\aircraft.cfg");
            System.IO.File.Move(lvrdir + @"\..\.aircraft.cfg", lvrdir + @"\..\aircraft.cfg");

            /// Rolling back model.cfg
            string[] mdlarr = Directory.GetFiles(lvrdir + @"\..\", "model.cfg", SearchOption.AllDirectories);
            foreach (string mdlcfg in mdlarr)
            {
                File.Delete(mdlcfg);
                System.IO.File.Move(mdlcfg+@"\..\.model.cfg", mdlcfg);
            }
            /// Rolling back texture.cfg
            string[] txtrarr = Directory.GetFiles(lvrdir + @"\..\", "texture.cfg", SearchOption.AllDirectories); /// Searching for x name in \texture.x\texture.cfg
            foreach (string txtrcfg in txtrarr)
            {
                File.Delete(txtrcfg);
                System.IO.File.Move(txtrcfg + @"\..\.texture.cfg", txtrcfg);
            }

            /// Final Step: Deleting .LiveryConverter
            File.Delete(seldir + "\\.LiveryConverter");

            MessageBox.Show("Rollback completed, livery can now be used in the default aircraft again", "Rollback sucessfull",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
            Environment.Exit(0);

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


