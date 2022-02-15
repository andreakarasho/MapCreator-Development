using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConvertTheMapToBMP
{
    public partial class ConvertTheMapToBMP : Form
    {
        public ConvertTheMapToBMP()
        {
            InitializeComponent();
        }

        private void btnBrowseMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "map files (map?.mul)|map?.mul";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtMap.Text = dialog.FileName;
            }
        }

        private void btnBrowseRadar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "radarcol.mul|radarcol.mul";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRadar.Text = dialog.FileName;
            }
        }

        private unsafe void btnDoIt_Click(object sender, EventArgs e)
        {
            if (txtMap.Text.Length == 0 || txtRadar.Text.Length == 0 || txtMapWidth.Text.Length == 0 || txtMapHeight.Text.Length == 0)
            {
                MessageBox.Show("Please Locate Your Map.mul And Radarcol.mul Before Proceeding...");
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "*.bmp|*.bmp";
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string output = dialog.FileName;
                    try
                    {
                        int mapWidth = Int32.Parse(txtMapWidth.Text);
                        int mapHeight = Int32.Parse(txtMapHeight.Text);
                        Bitmap bitmap = new Bitmap(mapWidth, mapHeight);
                        BitmapData bd = bitmap.LockBits(new Rectangle(0, 0, mapWidth, mapHeight), ImageLockMode.WriteOnly, PixelFormat.Format16bppRgb555);

                        ushort[] colors = new RadarColReader(txtRadar.Text).Colors;
                        ushort[] tiles = new MapReader(txtMap.Text, mapWidth, mapHeight).Tiles;

                        // TODO: Load and make use of MapDif, Statics and StaticsDif

                        ushort* bdPtr = (ushort*)bd.Scan0;

                        for (int i = 0; i < tiles.Length; i++)
                            bdPtr[i] = colors[tiles[i]];

                        bitmap.UnlockBits(bd);
                        bitmap.Save(output);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.ToString());
                    }
                }
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