using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmmaindashboard : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmmaindashboard()
        {
            InitializeComponent();
            admininfo();

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

        //admin photo and username
        private void admininfo()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT UserName,Picture FROM LOGIN";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    username.Text = da.GetValue(0).ToString();

                    //image
                    byte[] img = (byte[])(da["Picture"]);
                    MemoryStream mstream = new MemoryStream(img);
                    adminphoto.Image = System.Drawing.Image.FromStream(mstream);
                }


                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
