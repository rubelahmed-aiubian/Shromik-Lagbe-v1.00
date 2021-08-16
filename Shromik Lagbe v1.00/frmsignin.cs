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

namespace Shromik_Lagbe_v1._00
{
    public partial class frmsignin : Form
    {
        public frmsignin()
        {
            InitializeComponent();
        }

        //database string
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkBox1.Checked;
            switch (status)
            {
                case true:
                    textBox2.UseSystemPasswordChar = false;
                    break;
                case false:
                    textBox2.UseSystemPasswordChar = true;
                    break;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Username Or Email" || textBox2.Text != "Enter Password")
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "select * from LOGIN where username = @user and password = @pass";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        frmmaindashboard dash = new frmmaindashboard();
                        this.Hide();
                        dash.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username Or Password Not Matched", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Username Or Password Missing", "Login Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmforgotpassword forgot = new frmforgotpassword();
            forgot.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmaboutus aboutUs = new frmaboutus();
            this.Hide();
            aboutUs.Show();
        }
    }
}
