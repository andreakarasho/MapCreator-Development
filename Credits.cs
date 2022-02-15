using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaOnlineMapCreator
{
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new AboutThisSoftware();
            Form1.Show();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //This Snippet Launches A Working Directory From A Button
            String path = Path.GetDirectoryName(Application.ExecutablePath.ToString());

            if (File.Exists(Application.ExecutablePath))
            {
                Process.Start(Path.Combine(path, "Plugins/Data/Source"));
            }
        }
    }
}
