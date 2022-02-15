using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace UltimaOnlineMapCreator
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void usersubmittedpluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Hides One Form To Simulate Opening Another
            this.Hide();
            Form Form5 = new UserSubmittedPlugins();
            Form5.Show();
        }

        private void aboutthissoftwareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Hides One Form To Simulate Opening Another
            this.Hide();
            Form Form1 = new AboutThisSoftware();
            Form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("GenerateTerrainTypes.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("GenerateTileTransitions.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button3_Click(object sender, EventArgs e)
        {   
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("ConfigureColorTables.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("GenerateDataIndexLog.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("GenerateMapTemplate.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("EncodeAltitudeBitmap.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("CompileYourNewMap.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void setupAdobePhotoshopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Removed To Accomodate Multiple Paint Programs

            #region Developer Notes
            /*
                This Program Was Designed To Be Used With Adobe Photoshop And
                So I Only Had One Button To Access The Adobe Photoshop Folder.
             
                I Have Since Disabled This Button And Instead Created A Drop
                Down Menu System That Gives Users The Choice Of Opening Up Either
                The Adobe Photoshop Folder Or The Other Paint Programs Folder.
             
                Inside Each Of These Folders Are Tools Map Creators Can Use To
                Design And Create Their Own Game Maps For Ultima Online.
             
                OLD CODE IF YOU WISH TO ONLY ACCOMODATE ONE PAINT PROGRAM:
             
                //This Snippet Launches A Working Directory From A Button
                String path = Path.GetDirectoryName(Application.ExecutablePath.ToString());

                if (File.Exists(Application.ExecutablePath))
                {
                    Process.Start(Path.Combine(path, "Utilities/AdobePhotoshopCC"));
                }
            */
            #endregion

            #endregion
        }

        private void Form01_UOMC_GNUGPLv2_Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //This Snippet Launches A Web Browser And Displays A URL
            this.Form01_UOMC_GNUGPLv2_Label.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.gnu.org/licenses/gpl-2.0.html");
        }

        private void adobePhotoshopCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Launches A Working Directory From A Button
            String path = Path.GetDirectoryName(Application.ExecutablePath.ToString());

            if (File.Exists(Application.ExecutablePath))
            {
                Process.Start(Path.Combine(path, "Utilities/AdobePhotoshopCC"));
            }
        }

        private void otherPaintProgramsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Launches A Working Directory From A Button
            String path = Path.GetDirectoryName(Application.ExecutablePath.ToString());

            if (File.Exists(Application.ExecutablePath))
            {
                Process.Start(Path.Combine(path, "Utilities/OtherPaintPrograms"));
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This Snippet Kills The Application Process Upon Close
            Process.GetCurrentProcess().Kill();
        }      
    }
}
