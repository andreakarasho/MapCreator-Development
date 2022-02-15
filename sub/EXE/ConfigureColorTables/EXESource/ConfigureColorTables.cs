using Altitude;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Terrain;
using Ultima;
using UltimaOnlineMapCreator;

namespace ConfigureColorTables
{
    public partial class ConfigureColorTables : Form
    {
        private int i_Menu;
        private Art i_UOArt;
        private ClsAltitudeTable i_Altitude;
        private ClsTerrainTable i_Terrain;

        public ConfigureColorTables()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            ConfigureColorTables viewer = this;
            base.Load += new EventHandler(viewer.Viewer_Load);
            this.i_Menu = 0;
            this.i_Altitude = new ClsAltitudeTable();
            this.i_Terrain = new ClsTerrainTable();            
            InitializeComponent();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBox1.SelectedItem != null)
            {
                switch (this.i_Menu)
                {
                    case 0:
                        {
                            ClsTerrain selectedItem = (ClsTerrain)this.ListBox1.SelectedItem;
                            this.PropertyGrid1.SelectedObject = selectedItem;
                            this.PictureBox1.Image = Art.GetLand(selectedItem.TileID);
                            break;
                        }
                    case 1:
                        {
                            ClsAltitude clsAltitude = (ClsAltitude)this.ListBox1.SelectedItem;
                            this.PropertyGrid1.SelectedObject = clsAltitude;
                            break;
                        }
                }
            }
        }

        private void MenuItem12_Click(object sender, EventArgs e)
        {
            this.i_Altitude.SaveACT();
        }

        private void MenuItem13_Click(object sender, EventArgs e)
        {
            this.i_Terrain.SaveACO();
        }

        private void MenuItem14_Click(object sender, EventArgs e)
        {
            this.i_Altitude.SaveACO();
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            this.i_Menu = 0;
            this.Label1.Text = "Terrain Color Table";
            this.i_Terrain.Load();
            this.i_Terrain.Display(this.ListBox1);
            this.pictureBox5.Visible = false;
            this.PictureBox1.Visible = true;
            this.label4.Hide();
            this.label5.Hide();
            this.Label3.Show();
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            //this.i_Terrain.Save();

            this.i_Terrain.SaveACT();
            this.i_Terrain.SaveACO();
        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {
            this.i_Menu = 1;
            this.Label1.Text = "Altitude Color Table";
            this.i_Altitude.Load();
            this.i_Altitude.Display(this.ListBox1);
            this.PictureBox1.Visible = false;
            this.pictureBox5.Visible = true;
            this.Label3.Hide();
            this.label5.Hide();
            this.label4.Show();
        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {
            //this.i_Altitude.Save();

            this.i_Altitude.SaveACT();
            this.i_Altitude.SaveACO();
        }

        private void MenuItem9_Click(object sender, EventArgs e)
        {
            this.i_Terrain.SaveACT();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            this.i_Menu = 0;
            this.Label1.Text = "Please Select A Color Table To Load";
            //this.i_Terrain.Load();
            //this.i_Terrain.Display(this.ListBox1);
            this.pictureBox5.Visible = false;
            this.PictureBox1.Visible = false;
            this.label5.Show();
            this.label4.Hide();
            this.Label3.Hide();   
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