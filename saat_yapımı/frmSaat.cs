using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saat_yapimi
{
    public partial class frmSaat : Form
    {
        public frmSaat()
        {
            InitializeComponent();
        }

        private void lblsaat_Click(object sender, EventArgs e)
        {

        }

        private void frmSaat_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            //this.Opacity = 1.0;
            lblsaat.Text = DateTime.Now.ToLongTimeString();
            tmrSaat.Interval = 1000;
            tmrSaat.Start();
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmSaat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.G)
            { this.Close(); }
        }
    }
}
