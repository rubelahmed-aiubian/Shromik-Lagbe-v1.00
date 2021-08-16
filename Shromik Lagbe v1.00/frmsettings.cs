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
    public partial class frmsettings : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmsettings()
        {
            InitializeComponent();
            loaddata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/rubelahmed-aiubian");
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            //change password
            panel7.Visible = true;
        }

        private void btndeleteaccount_Click(object sender, EventArgs e)
        {
            //delete account
            DialogResult yesno = MessageBox.Show("Do you want to delete account?", "Confirmation", MessageBoxButtons.YesNo);

            if (yesno == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "DELETE FROM LOGIN WHERE UserName = @un";
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@un", username.Text);


                    con.Open();

                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Your account has been deleted", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Account not deleted", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    con.Close();
                }

                catch (Exception)
                {
                    MessageBox.Show("Client Not Deleted Sucessfully.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //nothing will heappen here;
            }
        }

        private void loaddata()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT UserName, FirstName, LastName, Email, PhoneNumber, FullAddress, CostPerHour, ClientCapacity, WorkerCapacity, Picture FROM LOGIN";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    username.Text = da.GetValue(0).ToString();
                    fname.Text = fname.Text + " " + da.GetValue(1).ToString();
                    lname.Text = lname.Text + " " + da.GetValue(2).ToString();
                    email.Text = email.Text + " " + da.GetValue(3).ToString();
                    phonenumber.Text = phonenumber.Text + " " + da.GetValue(4).ToString();
                    address.Text = address.Text + " " + da.GetValue(5).ToString();
                    lblcph.Text = da.GetValue(6).ToString();
                    lblcc.Text = da.GetValue(7).ToString();
                    lblwc.Text = da.GetValue(8).ToString();

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

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text !="" && textBox2.Text != "")
            {
                if(textBox1.Text == textBox2.Text)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(db);
                        string query = "update LOGIN set Password = @pass where username = @user";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@pass", textBox1.Text);
                        cmd.Parameters.AddWithValue("@user", username.Text);

                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected != 0)
                        {
                            panel7.Visible = false;
                        }
                        con.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something Is Not Right", "Error Occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password Not Matched", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Both Feild Required.", "Feild Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cph
            if(numericUpDown1.Value > 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "UPDATE LOGIN SET CostPerHour = @cph WHERE UserName = @un";
                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@cph", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@un", username.Text);

                    con.Open();
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        lblcph.Text = numericUpDown1.Value.ToString();
                        numericUpDown1.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("CPH Not Updated", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is not right", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Value Must Greater Than Zero","Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //cc
            if (numericUpDown2.Value > 0)
            {
                SqlConnection con = new SqlConnection(db);
                string query = "UPDATE LOGIN SET ClientCapacity = @cc WHERE UserName = @un";
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@cc", numericUpDown2.Value);
                cmd.Parameters.AddWithValue("@un", username.Text);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblcc.Text = numericUpDown2.Value.ToString();
                    numericUpDown2.Value = 0;
                }
                else
                {
                    MessageBox.Show("CC Not Updated", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Value Must Greater Than Zero", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //wc
            if (numericUpDown3.Value > 0)
            {
                SqlConnection con = new SqlConnection(db);
                string query = "UPDATE LOGIN SET WorkerCapacity = @wc WHERE UserName = @un";
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@wc", numericUpDown3.Value);
                cmd.Parameters.AddWithValue("@un", username.Text);

                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    lblwc.Text = numericUpDown3.Value.ToString();
                    numericUpDown3.Value = 0;
                }
                else
                {
                    MessageBox.Show("WC Not Updated", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Value Must Greater Than Zero", "Value Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
