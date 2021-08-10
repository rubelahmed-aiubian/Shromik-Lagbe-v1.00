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
    public partial class frmupdateworker : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        int xid;
        public frmupdateworker(int id)
        {
            InitializeComponent();
            this.xid = id;
            loadselectedrowsdata(id);
        }

        //load data
        private void loadselectedrowsdata(int id)
        {
            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                con.Open();
                string query = "SELECT FirstName, LastName, Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, PaymentStatus,Picture FROM WORKER WHERE WorkerId = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    //current preview information
                    prename.Text = prename.Text + " " + da.GetValue(0).ToString() + " " + da.GetValue(1).ToString();
                    pregender.Text = pregender.Text + " " + da.GetValue(2).ToString();
                    preoccupation.Text = preoccupation.Text + " " + da.GetValue(3).ToString();
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
                    occupation.Text = da.GetValue(3).ToString();
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

        private void btnupdatecancel_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmsearchworker backtoworker = new frmsearchworker { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            backtoworker.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(backtoworker);
            backtoworker.Show();
        }

        //reset function
        private void reset()
        {
            prename.Text = "Name: ";
            pregender.Text = "Gender: ";
            preoccupation.Text = "Occupation: ";
            prephone.Text = "Phone: ";
            preadd.Text = "Address: ";
            preservice.Text = "Service Area: ";
            prepayment.Text = "Payment Status: ";
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            //old preview clear

            reset();

            if (f_name.Text != "" || l_name.Text != "" || occupation.Text != "" || phone.Text != "" || address.Text != "" || servicearea.Text != "" || paymentstatus.Text != "")
            {

                //name
                if (f_name.Text != "" || l_name.Text != "")
                {
                    prename.Text = prename.Text + " " + f_name.Text + " " + l_name.Text;
                }

                //gender
                if (gender.Text != "")
                {
                    pregender.Text = pregender.Text + " " + gender.Text;
                }

                //occupation

                if(occupation.Text != "")
                {
                    preoccupation.Text = preoccupation.Text + "" + occupation.Text;
                }

                //phone
                if (phone.Text != "")
                {
                    prephone.Text = prephone.Text + " " + phone.Text;
                }

                //address
                if (address.Text != "")
                {
                    preadd.Text = preadd.Text + " " + address.Text;
                }

                //service area
                if (servicearea.Text != "")
                {
                    preservice.Text = preservice.Text + " " + servicearea.Text;
                }

                //payment status
                if (paymentstatus.Text != "")
                {
                    prepayment.Text = prepayment.Text + " " + paymentstatus.Text;
                }
            }

            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsavechanges_Click(object sender, EventArgs e)
        {
            DialogResult yesno = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);

            if (yesno == DialogResult.Yes)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "UPDATE WORKER SET FirstName = @fn, LastName = @ln, Gender = @gn, Occupation = @oc, PhoneNumber = @ph, FullAddress = @fa, ServiceArea = @ar, PaymentStatus = @ps WHERE WorkerId = @id";
                    SqlCommand cmd = new SqlCommand(query, con);


                    cmd.Parameters.AddWithValue("@fn", f_name.Text);
                    cmd.Parameters.AddWithValue("@ln", l_name.Text);
                    cmd.Parameters.AddWithValue("@gn", gender.Text);
                    cmd.Parameters.AddWithValue("@oc", occupation.Text);
                    cmd.Parameters.AddWithValue("@ph", phone.Text);
                    cmd.Parameters.AddWithValue("@fa", address.Text);
                    cmd.Parameters.AddWithValue("@ar", servicearea.Text);
                    cmd.Parameters.AddWithValue("@ps", paymentstatus.Text);
                    cmd.Parameters.AddWithValue("@id", xid);


                    con.Open();

                    int res = cmd.ExecuteNonQuery();

                    if (res > 0)
                    {
                        MessageBox.Show("Worker Updated Successfully.", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Controls.Clear();
                        frmsearchworker backtoworker = new frmsearchworker { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        backtoworker.FormBorderStyle = FormBorderStyle.None;
                        this.Controls.Add(backtoworker);
                        backtoworker.Show();

                    }
                    else
                    {
                        MessageBox.Show("Worker Not Updated Successfully.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is not right.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                this.Controls.Clear();
                frmsearchworker backtoworker = new frmsearchworker { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                backtoworker.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(backtoworker);
                backtoworker.Show();
            }
        }
    }
}
