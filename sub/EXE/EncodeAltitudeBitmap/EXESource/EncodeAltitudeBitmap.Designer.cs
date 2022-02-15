namespace EncodeAltitudeBitmap
{
    partial class EncodeAltitudeBitmap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncodeAltitudeBitmap));
            this.Label3 = new System.Windows.Forms.Label();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenu1 = new System.Windows.Forms.MenuStrip();
            this.MenuPath = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMake = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.AltitudeFile = new System.Windows.Forms.TextBox();
            this.TerrainFile = new System.Windows.Forms.TextBox();
            this.ProjectPath = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(229, 164);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(147, 20);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Altitude.bmp Image";
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar1.Location = new System.Drawing.Point(3, 253);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(786, 25);
            this.ProgressBar1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Project Folder Location:";
            // 
            // MainMenu1
            // 
            this.MainMenu1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuPath,
            this.MenuMake,
            this.mainMenuToolStripMenuItem});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.MainMenu1.Size = new System.Drawing.Size(792, 39);
            this.MainMenu1.TabIndex = 18;
            this.MainMenu1.Text = "MainMenu1";
            // 
            // MenuPath
            // 
            this.MenuPath.Image = ((System.Drawing.Image)(resources.GetObject("MenuPath.Image")));
            this.MenuPath.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.MenuPath.Name = "MenuPath";
            this.MenuPath.Size = new System.Drawing.Size(83, 29);
            this.MenuPath.Text = "Path";
            this.MenuPath.Click += new System.EventHandler(this.MenuPath_Click);
            // 
            // MenuMake
            // 
            this.MenuMake.Image = ((System.Drawing.Image)(resources.GetObject("MenuMake.Image")));
            this.MenuMake.Margin = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.MenuMake.Name = "MenuMake";
            this.MenuMake.Size = new System.Drawing.Size(319, 29);
            this.MenuMake.Text = "Sync Altitude.bmp To Terrain.bmp";
            this.MenuMake.Click += new System.EventHandler(this.MenuMake_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(15, 164);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(142, 20);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Terrain.bmp Image";
            // 
            // AltitudeFile
            // 
            this.AltitudeFile.Location = new System.Drawing.Point(229, 192);
            this.AltitudeFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AltitudeFile.Name = "AltitudeFile";
            this.AltitudeFile.Size = new System.Drawing.Size(154, 26);
            this.AltitudeFile.TabIndex = 11;
            this.AltitudeFile.Text = "Altitude.bmp";
            // 
            // TerrainFile
            // 
            this.TerrainFile.Location = new System.Drawing.Point(16, 192);
            this.TerrainFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TerrainFile.Name = "TerrainFile";
            this.TerrainFile.Size = new System.Drawing.Size(154, 26);
            this.TerrainFile.TabIndex = 10;
            this.TerrainFile.Text = "Terrain.bmp";
            // 
            // ProjectPath
            // 
            this.ProjectPath.Location = new System.Drawing.Point(16, 112);
            this.ProjectPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectPath.Name = "ProjectPath";
            this.ProjectPath.Size = new System.Drawing.Size(367, 26);
            this.ProjectPath.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-3, 53);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(803, 10);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-3, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(803, 10);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(407, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 214);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mainMenuToolStripMenuItem.Image")));
            this.mainMenuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(114, 4, 0, 0);
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(137, 29);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 120);
            this.label4.TabIndex = 28;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(434, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "* Failure Is Due To Pixels Being Drawn Wrong *";
            // 
            // EncodeAltitudeBitmap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 281);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ProjectPath);
            this.Controls.Add(this.TerrainFile);
            this.Controls.Add(this.AltitudeFile);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.MainMenu1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncodeAltitudeBitmap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultima Online™ Map Creator:  Encode Altitude Bitmap";
            this.Load += new System.EventHandler(this.AltImagePrep_Load);
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip MainMenu1;
        private System.Windows.Forms.ToolStripMenuItem MenuPath;
        private System.Windows.Forms.ToolStripMenuItem MenuMake;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox AltitudeFile;
        private System.Windows.Forms.TextBox TerrainFile;
        private System.Windows.Forms.TextBox ProjectPath;
        public System.Windows.Forms.ProgressBar ProgressBar1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

