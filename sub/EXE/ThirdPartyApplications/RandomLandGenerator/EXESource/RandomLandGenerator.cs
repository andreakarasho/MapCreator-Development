using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator;

namespace RandomLandGenerator
{
    public partial class RandomLandGenerator : Form
    {
        private float[,] _ResultGrid = null;
        private PerlinNoise _perlinNoise;
        private KochLikeNoise _kochLikeNoise;
        private INoiseGenerator _noiseGen;

        public RandomLandGenerator()
        {
            InitializeComponent();
            this._perlinNoise = new PerlinNoise();
            this._kochLikeNoise = new KochLikeNoise();
        }

        #region Form Field Code Snippets

        private void buttonRender_Click(object sender, EventArgs e)
        {
            this.Render();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = this.saveFileDialog1.FileName;
                this.pictureBox1.Image.Save(fileName);
            }
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateDisplay();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            this.Generate();
            this.Render();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.pictureBox1.SizeMode != PictureBoxSizeMode.CenterImage)
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        #endregion

        private void RandomLandGenerator_Load(object sender, EventArgs e)
        {
            this.cbType.SelectedIndex = 0;
            this.cbRenderStyle.SelectedIndex = 0;
        }

        private void Generate()
        {
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            this._ResultGrid = this._noiseGen.Generate();
            System.Windows.Forms.Cursor.Current = Cursors.Default;
        }

        private void Render()
        {
            if (this._ResultGrid == null)
            {
                MessageBox.Show("No previously generated map grid!");
            }
            else
            {
                float[,] singleArray = (new Normalize(30000f, 0f)).Process(this._ResultGrid);
                Render2D render2D = new Render2D()
                {
                    BoundsMax = 30000f,
                    BoundsMin = 0f
                };
                if (this.cbRenderStyle.SelectedIndex == 0)
                {
                    this.pictureBox1.Image = render2D.RenderTerran(singleArray);
                }
                else
                {
                    MessageBox.Show("Unknown Render selected");
                }
                render2D.Free();
                render2D = null;
            }
        }

        private void UpdateDisplay()
        {
            switch (this.cbType.SelectedIndex)
            {
                case 0:
                    {
                        this._noiseGen = this._perlinNoise;
                        break;
                    }
                case 1:
                    {
                        this._noiseGen = this._kochLikeNoise;
                        break;
                    }
                default:
                    {
                        this._noiseGen = null;
                        break;
                    }
            }
            if (this._noiseGen == null)
            {
                this.propertyGrid1.SelectedObject = null;
            }
            else
            {
                this.propertyGrid1.SelectedObject = this._noiseGen.Settings;
            }
        }
    }
}
