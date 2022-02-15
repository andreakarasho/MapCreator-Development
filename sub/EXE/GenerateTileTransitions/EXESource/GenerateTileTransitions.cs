using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateTileTransitions
{
    public partial class GenerateTileTransitions : Form
    {
        public GenerateTileTransitions()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Hides One Form To Simulate Opening Another
            this.Hide();

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"../");
            Process.Start("UltimaOnlineMapCreator.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This Snippet Hides One Form To Simulate Opening Another
            this.Hide();
            Form Create2WayTransitions = new Create2WayTransitions();
            Create2WayTransitions.Show();
        }
    }
}
