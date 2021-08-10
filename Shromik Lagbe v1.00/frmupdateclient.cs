using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmupdateclient : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        int xid;
        public frmupdateclient(int id)
        {
            InitializeComponent();
            loadselectedrowsdata(id);
            this.xid = id;

        }

        //load selected rows data

        public void loadselectedrowsdata(int id)
        {
            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                con.Open();
                string query = "SELECT FirstName, LastName, Gender, Email, PhoneNumber, FullAddress, ServiceArea, PaymentStatus,Picture FROM CLIENT WHERE ClientId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    //current preview information
                    prename.Text = prename.Text + " " + da.GetValue(0).ToString() + " " + da.GetValue(1).ToString();
                    pregender.Text = pregender.Text + " " + da.GetValue(2).ToString();
                    preemail.Text = preemail.Text + " " + da.GetValue(3).ToString();
                    prephone.Text = prephone.Text + " " + da.GetValue(4).ToString();
                    preadd.Text = preadd.Text + " " + da.GetValue(5).ToString();
                    preservice.Text = preservice.Text + " " + da.GetValue(6).ToString();
                    prepayment.Text = prepayment.Text + " " + da.GetValue(7).ToString();

                    //image
                    byte[] img = (byte[])(da["Picture"]);
                    MemoryStream mstream = new MemoryStream(img);
                    preclphoto.Image = System.Drawing.Image.FromStream(mstream);

                    //current text fields

                    f_name.Text = da.GetValue(0).ToString();
                    l_name.Text = da.GetValue(1).ToString();
                    gender.Text = da.GetValue(2).ToString();
                    email.Text = da.GetValue(3).ToString();
                    phone.Text = da.GetValue(4).ToString();
                    address.Text = da.GetValue(5).ToString();
                    servicearea.Text = da.GetValue(6).ToString();
                    paymentstatus.Text = da.GetValue(7).ToString();
                }


                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //update cancel
        private void btnclientsave_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmsearchclient backtoclient = new frmsearchclient { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            backtoclient.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(backtoclient);
            backtoclient.Show();
        }

        //reset function
        private void reset()
        {
            prename.Text = "Name:";
            pregender.Text = "Gender:";
            preemail.Text = "Email:";
            prephone.Text = "Phone:";
            preadd.Text = "Address:";
            preservice.Text = "Service Area:";
            prepayment.Text = "Payment Status:";
        }

        //preview changes
        private void btnpreview_Click(object sender, EventArgs e)
        {
            //old preview clear

            reset();

            if (f_name.Text != "" || l_name.Text != "" || email.Text != "" || phone.Text != "" || address.Text != "" || servicearea.Text != "" || paymentstatus.Text != "")
            {

                //name
                if (f_name.Text != "" || l_name.Text != "")
                {
                    prename.Text = prename.Text + " " + f_name.Text + " " + l_name.Text;
                }
                else
                {
                    MessageBox.Show("Please enter first name and last name.", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                //gender
                if (gender.Text != "")
                {
                    pregender.Text = pregender.Text + " " + gender.Text;
                }
                else
                {
                    MessageBox.Show("Please choose a gender.", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                //email
                if (email.Text != "")
                {
                    bool em = email.Text.Contains('@');
                    if (em == true)
                    {
                        preemail.Text = preemail.Text + " " + email.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please enter an valid email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an email address", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //phone
                if (phone.Text != "")
                {
                    prephone.Text = prephone.Text + " " + phone.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a phone number.", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                //address
                if (address.Text != "")
                {
                    preadd.Text = preadd.Text + " " + address.Text;
                }
                else
                {
                    MessageBox.Show("Please enter an local address.", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                //service area
                if (servicearea.Text != "")
                {
                    preservice.Text = preservice.Text + " " + servicearea.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a service area.", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                //payment status
                if (paymentstatus.Text != "")
                {
                    prepayment.Text = prepayment.Text + " " + paymentstatus.Text;
                }
                else
                {
                    MessageBox.Show("Please enter a service area.", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

            }

            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void btnsavechanges_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Do you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo);

            if (yesno == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "UPDATE CLIENT SET FirstName = @fn, LastName = @ln, Gender = @gn, Email = @em, PhoneNumber = @ph, FullAddress = @fa, ServiceArea = @ar, PaymentStatus = @ps WHERE ClientId = @id";
                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@fn", f_name.Text);
                    cmd.Parameters.AddWithValue("@ln", l_name.Text);
                    cmd.Parameters.AddWithValue("@gn", gender.Text);
                    cmd.Parameters.AddWithValue("@em", email.Text);
                    cmd.Parameters.AddWithValue("@ph", phone.Text);
                    cmd.Parameters.AddWithValue("@fa", address.Text);
                    cmd.Parameters.AddWithValue("@ar", servicearea.Text);
                    cmd.Parameters.AddWithValue("@ps", paymentstatus.Text);
                    cmd.Parameters.AddWithValue("@id", xid);


                    con.Open();

                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Client Updated Successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Controls.Clear();
                        frmsearchclient backtoclient = new frmsearchclient { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        backtoclient.FormBorderStyle = FormBorderStyle.None;
                        this.Controls.Add(backtoclient);
                        backtoclient.Show();

                    }
                    else
                    {
                        MessageBox.Show("Client Not Updated Successfully.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Client Not Updated Successfully.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                this.Controls.Clear();
                frmsearchclient backtoclient = new frmsearchclient { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                backtoclient.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(backtoclient);
                backtoclient.Show();
            }
        }
    }
}
