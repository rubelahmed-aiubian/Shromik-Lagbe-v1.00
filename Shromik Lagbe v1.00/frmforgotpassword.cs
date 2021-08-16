using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmforgotpassword : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmforgotpassword()
        {
            InitializeComponent();
        }

        private void btnback_clcik(object sender, EventArgs e)
        {
            this.Hide();
            frmsignin first = new frmsignin();
            first.Show();
        }

        private void btn_exit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancel_click(object sender, EventArgs e)
        {
            this.Hide();
            frmsignin first = new frmsignin();
            first.Show();
        }

        private void btn_continue_click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(db);
                string query = "select * from LOGIN where username = @user";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    pnlReselPass.Visible = true;
                }
                else
                {
                    MessageBox.Show("Account Not Found.", "Invalid Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter your username first.", "Invalid Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void resetPassCancel(object sender, EventArgs e)
        {
            pnlReselPass.Visible = false;
        }

        private void resetPassSave(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Enter Password Correctly.", "Invalid Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Password Not Matched!", "Invalid Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "update LOGIN set Password = @pass where UserName = @user";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@pass", textBox2.Text);
                    cmd.Parameters.AddWithValue("@user", textBox1.Text);

                    con.Open();

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected != 0)
                    {
                        MessageBox.Show("Password Changed Successfully", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmsignin x = new frmsignin();
                        this.Hide();
                        x.Show();
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something Is Not Right", "Error Occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
