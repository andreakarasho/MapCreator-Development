namespace ConvertTheMapToBMP
{
    partial class ConvertTheMapToBMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertTheMapToBMP));
            this.txtMap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMapWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMapHeight = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBrowseMap = new System.Windows.Forms.Button();
            this.btnBrowseRadar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateUOP_MachineSpeedWarning_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(10, 71);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(159, 20);
            this.txtMap.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Map.mul File Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radarcol.mul Location:";
            // 
            // txtRadar
            // 
            this.txtRadar.Location = new System.Drawing.Point(10, 123);
            this.txtRadar.Name = "txtRadar";
            this.txtRadar.Size = new System.Drawing.Size(159, 20);
            this.txtRadar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Map Dimensions:";
            // 
            // txtMapWidth
            // 
            this.txtMapWidth.Location = new System.Drawing.Point(380, 52);
            this.txtMapWidth.Name = "txtMapWidth";
            this.txtMapWidth.Size = new System.Drawing.Size(58, 20);
            this.txtMapWidth.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(444, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "x";
            // 
            // txtMapHeight
            // 
            this.txtMapHeight.Location = new System.Drawing.Point(461, 52);
            this.txtMapHeight.Name = "txtMapHeight";
            this.txtMapHeight.Size = new System.Drawing.Size(58, 20);
            this.txtMapHeight.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(289, 87);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(230, 56);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Convert Maps To .bmp";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // btnBrowseMap
            // 
            this.btnBrowseMap.Location = new System.Drawing.Point(185, 70);
            this.btnBrowseMap.Name = "btnBrowseMap";
            this.btnBrowseMap.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseMap.TabIndex = 11;
            this.btnBrowseMap.Text = "Browse...";
            this.btnBrowseMap.UseVisualStyleBackColor = true;
            this.btnBrowseMap.Click += new System.EventHandler(this.btnBrowseMap_Click);
            // 
            // btnBrowseRadar
            // 
            this.btnBrowseRadar.Location = new System.Drawing.Point(185, 122);
            this.btnBrowseRadar.Name = "btnBrowseRadar";
            this.btnBrowseRadar.Size = new System.Drawing.Size(75, 21);
            this.btnBrowseRadar.TabIndex = 12;
            this.btnBrowseRadar.Text = "Browse...";
            this.btnBrowseRadar.UseVisualStyleBackColor = true;
            this.btnBrowseRadar.Click += new System.EventHandler(this.btnBrowseRadar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 156);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(535, 6);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-2, 34);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(535, 6);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(271, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(7, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 36);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mainMenuToolStripMenuItem.Image")));
            this.mainMenuToolStripMenuItem.Margin = new System.Windows.Forms.Padding(417, 4, 0, 0);
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // CreateUOP_MachineSpeedWarning_Label
            // 
            this.CreateUOP_MachineSpeedWarning_Label.AutoSize = true;
            this.CreateUOP_MachineSpeedWarning_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CreateUOP_MachineSpeedWarning_Label.Location = new System.Drawing.Point(285, 166);
            this.CreateUOP_MachineSpeedWarning_Label.Name = "CreateUOP_MachineSpeedWarning_Label";
            this.CreateUOP_MachineSpeedWarning_Label.Size = new System.Drawing.Size(233, 13);
            this.CreateUOP_MachineSpeedWarning_Label.TabIndex = 42;
            this.CreateUOP_MachineSpeedWarning_Label.Text = "The Process Speed Depends On Your Machine";
            // 
            // ConvertTheMapToBMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 183);
            this.Controls.Add(this.CreateUOP_MachineSpeedWarning_Label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnBrowseRadar);
            this.Controls.Add(this.btnBrowseMap);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtMapHeight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMapWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRadar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMap);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConvertTheMapToBMP";
            this.Text = "Ultima Online™ Map Creator:  Convert The Map To BMP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMapWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMapHeight;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBrowseMap;
        private System.Windows.Forms.Button btnBrowseRadar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Label CreateUOP_MachineSpeedWarning_Label;

    }
}

