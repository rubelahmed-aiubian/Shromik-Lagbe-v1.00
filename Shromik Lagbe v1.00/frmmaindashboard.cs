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
    public partial class frmmaindashboard : Form
    {
        public frmmaindashboard()
        {
            InitializeComponent();

            //dashboard initialize
            lbltitle.Text = "Dashboard";
            this.pnlmainform.Controls.Clear();
            frmdashboard dashboard = new frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlmainform.Controls.Add(dashboard);
            dashboard.Show();
            btndashboard.BackColor = Color.FromArgb(43, 53, 79);
            btnclient.BackColor = Color.FromArgb(20, 31, 46);
            btnworker.BackColor = Color.FromArgb(20, 31, 46);
            btnpayment.BackColor = Color.FromArgb(20, 31, 46);
            btnsettings.BackColor = Color.MediumSeaGreen;

        }

        //btn dashboard
        private void btndashboard_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Dashboard";
            this.pnlmainform.Controls.Clear();
            frmdashboard dashboard = new frmdashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlmainform.Controls.Add(dashboard);
            dashboard.Show();
            btndashboard.BackColor = Color.FromArgb(43, 53, 79);
            btnclient.BackColor = Color.FromArgb(20, 31, 46);
            btnworker.BackColor = Color.FromArgb(20, 31, 46);
            btnpayment.BackColor = Color.FromArgb(20, 31, 46);
            btnsettings.BackColor = Color.MediumSeaGreen;
        }

        //btn client
        private void btnclient_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Clients";
            this.pnlmainform.Controls.Clear();

            frmsearchclient searchcl = new frmsearchclient { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            searchcl.FormBorderStyle = FormBorderStyle.None;
            this.pnlmainform.Controls.Add(searchcl);
            searchcl.Show();
            btnclient.BackColor = Color.FromArgb(43, 53, 79);
            btndashboard.BackColor = Color.FromArgb(20, 31, 46);
            btnworker.BackColor = Color.FromArgb(20, 31, 46);
            btnpayment.BackColor = Color.FromArgb(20, 31, 46);
            btnsettings.BackColor = Color.MediumSeaGreen;
        }

        //btn worker
        private void btnworker_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Worker";
            this.pnlmainform.Controls.Clear();
            frmsearchworker worker = new frmsearchworker { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            worker.FormBorderStyle = FormBorderStyle.None;
            this.pnlmainform.Controls.Add(worker);
            worker.Show();
            btnworker.BackColor = Color.FromArgb(43, 53, 79);

            btndashboard.BackColor = Color.FromArgb(20, 31, 46);
            btnclient.BackColor = Color.FromArgb(20, 31, 46);
            btnpayment.BackColor = Color.FromArgb(20, 31, 46);
            btnsettings.BackColor = Color.MediumSeaGreen;
        }

        //btn payment
        private void btnpayment_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Payment";
            this.pnlmainform.Controls.Clear();
            frmpayment pay = new frmpayment { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pay.FormBorderStyle = FormBorderStyle.None;
            this.pnlmainform.Controls.Add(pay);
            pay.Show();
            btnpayment.BackColor = Color.FromArgb(43, 53, 79);

            btndashboard.BackColor = Color.FromArgb(20, 31, 46);
            btnclient.BackColor = Color.FromArgb(20, 31, 46);
            btnworker.BackColor = Color.FromArgb(20, 31, 46);
            btnsettings.BackColor = Color.MediumSeaGreen;
        }
        //btn settings
        private void btnsettings_Click(object sender, EventArgs e)
        {
            lbltitle.Text = "Settings";
            this.pnlmainform.Controls.Clear();
            frmsettings settings = new frmsettings { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settings.FormBorderStyle = FormBorderStyle.None;
            this.pnlmainform.Controls.Add(settings);
            settings.Show();
            btnsettings.BackColor = Color.FromArgb(43, 53, 79);

            btndashboard.BackColor = Color.FromArgb(20, 31, 46);
            btnclient.BackColor = Color.FromArgb(20, 31, 46);
            btnworker.BackColor = Color.FromArgb(20, 31, 46);
            btnpayment.BackColor = Color.FromArgb(20, 31, 46);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmsignin log = new frmsignin();
            log.Show();
            Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
