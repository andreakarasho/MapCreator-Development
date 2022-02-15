namespace Logger
{
    partial class LoggerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggerForm));
            this.TextLog = new System.Windows.Forms.TextBox();
            this.MainMenu1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem2 = new System.Windows.Forms.ToolStripButton();
            this.MenuItem3 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Form01_UOMC_Version_Label = new System.Windows.Forms.Label();
            this.MainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TextLog
            // 
            this.TextLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLog.Location = new System.Drawing.Point(6, 65);
            this.TextLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextLog.Multiline = true;
            this.TextLog.Name = "TextLog";
            this.TextLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextLog.Size = new System.Drawing.Size(779, 174);
            this.TextLog.TabIndex = 0;
            // 
            // MainMenu1
            // 
            this.MainMenu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainMenu1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainMenu1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.MenuItem2,
            this.MenuItem3,
            this.toolStripButton1});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.MainMenu1.Size = new System.Drawing.Size(792, 37);
            this.MainMenu1.Stretch = true;
            this.MainMenu1.TabIndex = 2;
            this.MainMenu1.Text = "MainMenu1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Image = global::Logger.Properties.Resources.uomc30;
            this.MenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuItem2.Margin = new System.Windows.Forms.Padding(6, 4, 0, 0);
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(118, 29);
            this.MenuItem2.Text = " Save As...";
            this.MenuItem2.Click += new System.EventHandler(this.MenuItem2_Click);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Image = global::Logger.Properties.Resources.uomc31;
            this.MenuItem3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuItem3.Margin = new System.Windows.Forms.Padding(15, 4, 0, 0);
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.Size = new System.Drawing.Size(80, 29);
            this.MenuItem3.Text = " Print";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
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
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(313, 4, 0, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(27, 27);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Form01_UOMC_Version_Label
            // 
            this.Form01_UOMC_Version_Label.AutoSize = true;
            this.Form01_UOMC_Version_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form01_UOMC_Version_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Form01_UOMC_Version_Label.Location = new System.Drawing.Point(504, 255);
            this.Form01_UOMC_Version_Label.Margin = new System.Windows.Forms.Padding(6, 0, 4, 0);
            this.Form01_UOMC_Version_Label.Name = "Form01_UOMC_Version_Label";
            this.Form01_UOMC_Version_Label.Size = new System.Drawing.Size(278, 20);
            this.Form01_UOMC_Version_Label.TabIndex = 27;
            this.Form01_UOMC_Version_Label.Text = "Ultima Online™ Map Creator Logger.dll\r\n";
            // 
            // LoggerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 281);
            this.Controls.Add(this.Form01_UOMC_Version_Label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.MainMenu1);
            this.Controls.Add(this.TextLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoggerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ultima Online™ Map Creator: Log";
            this.MainMenu1.ResumeLayout(false);
            this.MainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextLog;
        private System.Windows.Forms.ToolStrip MainMenu1;
        private System.Windows.Forms.ToolStripButton MenuItem3;
        private System.Windows.Forms.ToolStripButton MenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label Form01_UOMC_Version_Label;
    }
}