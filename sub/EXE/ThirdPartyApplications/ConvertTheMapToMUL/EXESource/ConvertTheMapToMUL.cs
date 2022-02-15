using LegacyMUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UltimaOnlineMapCreator;

namespace ConvertTheMapToMUL
{
    public partial class ConvertTheMapToMUL : Form
    {
        LegacyMULConverter conv;

        public ConvertTheMapToMUL()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            conv = new LegacyMULConverter();
            InitializeComponent();
        }

        private int m_Total, m_Success;

        private void CreateMUL_ProjectPath_MenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.CreateMUL_ProjectPath.Text
            };
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.CreateMUL_ProjectPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void CreateMUL_ProjectPath_MenuItem_Load(object sender, EventArgs e)
        {
            this.CreateMUL_ProjectPath.Text = Directory.GetCurrentDirectory();
        }

        private string FixPath(string file)
        {
            return (file == null) ? null : Path.Combine(CreateMUL_ProjectPath.Text, file);
        }

        private void Extract(string inFile, string outFile, string outIdx, FileType type, int typeIndex)
        {
            try
            {
                statustext.Text = inFile;
                Refresh();
                inFile = FixPath(inFile);

                if (!File.Exists(inFile))
                    return;

                outFile = FixPath(outFile);

                if (File.Exists(outFile))
                {
                    return;
                }

                outIdx = FixPath(outIdx);
                ++m_Total;

                conv.FromUOP(inFile, outFile, outIdx, type, typeIndex);
                ++m_Success;
            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured while performing the action");
            }
        }

        private void CreateMUL_Button_Click(object sender, EventArgs e)
        {
            if (CreateMUL_ProjectPath.Text == string.Empty || CreateMUL_ProjectPath.Text == null)
            {
                MessageBox.Show(" ERROR: You Must Specify The Location Path\n Of The [.uop] Files You Want Converted!");
                return;
            }
        
            Extract( "artLegacyMUL.uop", "art.mul", "artidx.mul", FileType.ArtLegacyMUL, 0 );
		    Extract( "gumpartLegacyMUL.uop", "gumpart.mul", "gumpidx.mul", FileType.GumpartLegacyMUL, 0 );
		    Extract( "soundLegacyMUL.uop", "sound.mul", "soundidx.mul", FileType.SoundLegacyMUL, 0 );

            if (UltimaLiveFacetAllowance.Checked)
            {
                for (int i = 0; i <= 250; ++i)
                {
                    string map = String.Format("map{0}", i);

                    Extract(map + "LegacyMUL.uop", map + ".mul", null, FileType.MapLegacyMUL, i);
                    Extract(map + "xLegacyMUL.uop", map + "x.mul", null, FileType.MapLegacyMUL, i);
                }

                statustext.Text = string.Format("Done ({0}/{1} files extracted)", m_Success, m_Total);
            }
            else if (BroadswordsFacetAllowance.Checked)
            {
                for (int i = 0; i <= 5; ++i)
                {
                    string map = String.Format("map{0}", i);

                    Extract(map + "LegacyMUL.uop", map + ".mul", null, FileType.MapLegacyMUL, i);
                    Extract(map + "xLegacyMUL.uop", map + "x.mul", null, FileType.MapLegacyMUL, i);
                }

                statustext.Text = string.Format("Done ({0}/{1} files extracted)", m_Success, m_Total);
            }
            else if (UltimaLiveFacetAllowance.Checked == false || BroadswordsFacetAllowance.Checked == false)
            {
                MessageBox.Show("   ERROR: Please Select A Facet Allowance Type Before This Program Can Proceed!\n");
                return;
            }
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
    }
}

 