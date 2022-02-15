using Altitude;
using Logger;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Terrain;
using UltimaOnlineMapCreator;

namespace EncodeAltitudeBitmap
{
    public partial class EncodeAltitudeBitmap : Form
    {
        private ClsTerrainTable iTerrain;
        private ClsAltitudeTable iAltitude;
        private LoggerForm iLogger;

        public EncodeAltitudeBitmap()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            EncodeAltitudeBitmap altImagePrep = this;
            base.Load += new EventHandler(altImagePrep.AltImagePrep_Load);
            this.iTerrain = new ClsTerrainTable();
            this.iAltitude = new ClsAltitudeTable();
            this.iLogger = new LoggerForm();
            InitializeComponent();
        }

        private void MenuPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.ProjectPath.Text
            };
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.ProjectPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private async void MenuMake_Click(object sender, EventArgs e)
        {
            Progress<int> progress = new Progress<int> ( i => { ProgressBar1.Value = i; } );
            Progress<string> logger = new Progress<string>(i => { iLogger.LogMessage(i); });
            Task resetProgress = new Task(() => {Thread.Sleep(1000); ((IProgress<int>)progress).Report(0);});
            await Task.Run(() => EncodeAltitudeBitmapHelper.MakeAltitudeImage(ProjectPath.Text, TerrainFile.Text, AltitudeFile.Text, iAltitude, iTerrain, progress, logger)).ContinueWith(c => resetProgress.Start());         
        }

        private void AltImagePrep_Load(object sender, EventArgs e)
        {
            this.iLogger.Show();
            int x = checked(this.iLogger.Location.X + 100);
            Point location = this.iLogger.Location;
            Point point = new Point(x, checked(location.Y + 100));
            this.Location = point;
            this.ProjectPath.Text = Directory.GetCurrentDirectory();
            this.iTerrain.Load();
            this.iAltitude.Load();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This Snippet Hides One Form To Simulate Opening Another
            this.Hide();
            iLogger.Hide();

            //This Snippet Launches An Application In Another Folder
            Directory.SetCurrentDirectory(@"../");
            Process.Start("UltimaOnlineMapCreator.exe");

            //This Snippet Exits The Application And Kills The Thread
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
