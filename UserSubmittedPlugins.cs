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
using Microsoft.Win32;

namespace UltimaOnlineMapCreator
{
    public partial class UserSubmittedPlugins : Form
    {
        public UserSubmittedPlugins()
        {
            InitializeComponent();
            this.pictureBox2.Show();
            this.label2.Hide();
            this.label3.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
        }

        private void browsePluginFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Launches A Working Directory From A Button
            String path = Path.GetDirectoryName(Application.ExecutablePath.ToString());

            if (File.Exists(Application.ExecutablePath))
            {
                Process.Start(Path.Combine(path, "Plugins"));
            }
        }

        private void submitYourPluginHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form3 = new WebmailSelector();
            Form3.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new MainMenu();
            Form2.Show(); 
        }

        #region Random Land Generator

        private void button1_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("RandomLandGenerator.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.Label_RandomLandGenerator.Show();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {  
            this.label2.Hide();
            this.label3.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.pictureBox2.Show();
        }

        #endregion

        #region Convert MapToUOP

        private void button2_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("ConvertTheMapToUOP.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.Label_MapToUOP.Show();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.label2.Hide();
            this.label3.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.pictureBox2.Show();
        }

        #endregion

        #region Convert MapToMUL

        private void button3_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("ConvertTheMapToMUL");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.Label_MapToMUL.Show();
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.label2.Hide();
            this.label3.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.pictureBox2.Show();
        }

        #endregion

        #region Convert MapToBMP

        private void button4_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("ConvertTheMapToBMP");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.Label_MapToBMP.Show();
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            this.label2.Hide();
            this.label3.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.pictureBox2.Show();
        }

        #endregion

        #region Random Cave Generator

        private void button5_Click(object sender, EventArgs e)
        {
            //This Snippet Launches An Application From The Same Folder
            //Process pr = new Process();
            //System.Diagnostics.Process.Start("CreateStatics.exe");

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"Plugins");
            Process.Start("RandomCaveGenerator.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Show();
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.Hide();
            this.Label_MapToUOP.Hide();
            this.Label_MapToMUL.Hide();
            this.Label_MapToBMP.Hide();
            this.Label_RandomLandGenerator.Hide();
            this.Label_RandomCaveGenerator.Hide();
            this.pictureBox2.Show();
        }

        #endregion
    }
}
