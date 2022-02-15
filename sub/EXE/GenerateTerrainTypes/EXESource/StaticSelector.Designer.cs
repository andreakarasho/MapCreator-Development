namespace GenerateTerrainTypes
{
    partial class StaticSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaticSelector));
            this.Panel2 = new System.Windows.Forms.Panel();
            this.VScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel2
            // 
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Location = new System.Drawing.Point(5, 5);
            this.Panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Name = "Panel2";
            this.Panel2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel2.Size = new System.Drawing.Size(452, 549);
            this.Panel2.TabIndex = 3;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // VScrollBar1
            // 
            this.VScrollBar1.LargeChange = 16;
            this.VScrollBar1.Location = new System.Drawing.Point(463, 5);
            this.VScrollBar1.Maximum = 16384;
            this.VScrollBar1.Name = "VScrollBar1";
            this.VScrollBar1.Size = new System.Drawing.Size(27, 549);
            this.VScrollBar1.TabIndex = 0;
            this.VScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VScrollBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(491, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close Static Selector Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaticSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 614);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VScrollBar1);
            this.Controls.Add(this.Panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaticSelector";
            this.Text = "Static Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.VScrollBar VScrollBar1;
        private System.Windows.Forms.Button button1;
    }
}