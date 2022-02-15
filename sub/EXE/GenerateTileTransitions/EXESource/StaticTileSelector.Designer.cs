namespace GenerateTileTransitions
{
    partial class StaticTileSelector
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
            this.Panel2 = new System.Windows.Forms.Panel();
            this.TileID = new System.Windows.Forms.VScrollBar();
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
            this.Panel2.TabIndex = 0;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            this.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel2_MouseDown);
            // 
            // TileID
            // 
            this.TileID.LargeChange = 16;
            this.TileID.Location = new System.Drawing.Point(463, 5);
            this.TileID.Maximum = 16384;
            this.TileID.Name = "TileID";
            this.TileID.Size = new System.Drawing.Size(27, 549);
            this.TileID.TabIndex = 0;
            this.TileID.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TileID_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(491, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close Static Tile Selector Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StaticTileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 614);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TileID);
            this.Controls.Add(this.Panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StaticTileSelector";
            this.Text = "Static Tile Selector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.VScrollBar TileID;
        private System.Windows.Forms.Button button1;
    }
}