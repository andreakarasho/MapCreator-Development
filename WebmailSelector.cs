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
    public partial class WebmailSelector : Form
    {
        public WebmailSelector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new UserSubmittedPlugins();
            Form2.Show(); 
        }

        private void button_MicrosoftOutlook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.outlook.com");
        }

        private void button_GoogleMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://accounts.google.com/ServiceLogin?service=mail&continue=https://mail.google.com/mail/#identifier");
        }

        private void button_iCloudMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.icloud.com/#mail");
        }

        private void button_YahooMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://login.yahoo.com/?.src=ym&.intl=us&.lang=en-US&.done=https%3a//mail.yahoo.com");
        }

        private void button_FileMail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.filemail.com/");
        }
    }
}
