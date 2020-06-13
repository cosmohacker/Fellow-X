using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FellowX
{
    public partial class AppStartForm : Form
    {

        private DateTime startTime;

        public AppStartForm()
        {
            InitializeComponent();
        }

        private void tmrProgress_Tick(object sender, EventArgs e)
        {
            if (pBarStart.Value != 8)
            {
                pBarStart.Value++;
            }
            else
            {
                tmrProgress.Stop();
                Recorder recorder = new Recorder();
                recorder.Show();
                this.Hide();
            }

        }

        private void AppStartForm_Load(object sender, EventArgs e)
        {
            tmrProgress.Enabled = true;
            tmrProgress.Start();
            startTime = DateTime.Now;
            pBarStart.ForeColor = ColorTranslator.FromHtml("#9c915d");
        }
    }
}
