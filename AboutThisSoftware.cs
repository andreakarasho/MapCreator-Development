using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltimaOnlineMapCreator
{
    public partial class AboutThisSoftware : Form
    {
        public AboutThisSoftware()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new MainMenu();
            Form2.Show();     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form Form4 = new Credits();
            Form4.Show();
        }
    }
}
