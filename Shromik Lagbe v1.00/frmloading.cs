using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmloading : Form
    {
        public frmloading()
        {
            InitializeComponent();
        }

        //timer
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 50)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                frmsignin signin = new frmsignin();
                this.Hide();
                signin.Show();
            }
        }

        private void frmloading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
