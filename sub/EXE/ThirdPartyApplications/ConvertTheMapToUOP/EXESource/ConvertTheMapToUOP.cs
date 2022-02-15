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

namespace ConvertTheMapToUOP
{
    public partial class ConvertTheMapToUOP : Form
    {
        LegacyMULConverter conv;

        public ConvertTheMapToUOP()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            conv = new LegacyMULConverter();
            InitializeComponent();
        }

        private int m_Total, m_Success;

        private void CreateUOP_ProjectPath_MenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog()
            {
                SelectedPath = this.CreateUOP_ProjectPath.Text
            };
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.CreateUOP_ProjectPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void CreateUOP_ProjectPath_MenuItem_Load(object sender, EventArgs e)
        {
            this.CreateUOP_ProjectPath.Text = Directory.GetCurrentDirectory();
        }

        private string FixPath(string file)
        {
            return (file == null) ? null : Path.Combine(CreateUOP_ProjectPath.Text, file);
        }

        private void Pack(string inFile, string inIdx, string outFile, FileType type, int typeIndex)
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

                inIdx = FixPath(inIdx);
                ++m_Total;

                conv.ToUOP(inFile, inIdx, outFile, type, typeIndex);
                ++m_Success;

            }
            catch (Exception e)
            {
                MessageBox.Show("An error occured while performing the action");
            }
        }

        private void CreateUOP_Button_Click(object sender, EventArgs e)
        {
            if (CreateUOP_ProjectPath.Text == string.Empty || CreateUOP_ProjectPath.Text == null)
            {
                MessageBox.Show(" ERROR: You Must Specify The Location Path\n Of The [.mul] Files You Want Converted!");
                return;
            }

            Pack("art.mul", "artidx.mul", "artLegacyMUL.uop", FileType.ArtLegacyMUL, 0);
            Pack("gumpart.mul", "gumpidx.mul", "gumpartLegacyMUL.uop", FileType.GumpartLegacyMUL, 0);
            Pack("sound.mul", "soundidx.mul", "soundLegacyMUL.uop", FileType.SoundLegacyMUL, 0);

            if (UltimaLiveFacetAllowance.Checked)
            {
                for (int i = 0; i <= 250; ++i)
                {
                    string map = String.Format("map{0}", i);

                    Pack(map + ".mul", null, map + "LegacyMUL.uop", FileType.MapLegacyMUL, i);
                    Pack(map + "x.mul", null, map + "xLegacyMUL.uop", FileType.MapLegacyMUL, i);
                }

                statustext.Text = string.Format("Done ({0}/{1} files extracted)", m_Success, m_Total);
            }
            else if (BroadswordsFacetAllowance.Checked)
            {
                for (int i = 0; i <= 5; ++i)
                {
                    string map = String.Format("map{0}", i);

                    Pack(map + ".mul", null, map + "LegacyMUL.uop", FileType.MapLegacyMUL, i);
                    Pack(map + "x.mul", null, map + "xLegacyMUL.uop", FileType.MapLegacyMUL, i);
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
