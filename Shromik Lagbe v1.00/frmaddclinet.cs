using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmaddclinet : Form
    {

        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        double clientcount;
        double existingclient;
        public frmaddclinet()
        {
            InitializeComponent();
            clientnumbercheck();
            existingclientcheck();
        }

        private void pnlclientinformation_Paint(object sender, PaintEventArgs e)
        {

        }


        //check client count
        private void clientnumbercheck()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT ClientCapacity FROM LOGIN";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    clientcount = Convert.ToDouble(da.GetValue(0));
                }


                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //existing client number

        private void existingclientcheck()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM CLIENT";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                existingclient = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        //information preview
        private void btnpreview_Click(object sender, EventArgs e)
        {
            previewreset();

            if (f_name.Text != "" && l_name.Text != "" && gender.Text !="" && email.Text != "" && phone.Text != "" && address.Text != "" && servicearea.Text != "" && paymentstatus.Text != "")
            {
                prename.Text = prename.Text + " " + f_name.Text + " " + l_name.Text;
                pregender.Text = pregender.Text + " " + gender.Text;
                prephone.Text = prephone.Text + " " + phone.Text;
                preadd.Text = preadd.Text + " " + address.Text;
                preservice.Text = preservice.Text + " " + servicearea.Text;
                prepayment.Text = prepayment.Text + " " + paymentstatus.Text;

                //assigned worker id
                if (numericUpDown1.Value != 0)
                {
                    preassignedworkerid.Text = preassignedworkerid.Text + " " + numericUpDown1.Value.ToString();
                }
                else
                {
                    preassignedworkerid.Text = preassignedworkerid.Text + "0";
                }

                //email
                if (email.Text != "")
                {
                    bool em = email.Text.Contains('@');
                    if (em == true)
                    {
                        preemail.Text = preemail.Text + " " + email.Text;
                        pnlpreview.Visible = true;
                        btnclientsave.Visible = true;
                        label12.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Please enter an vaild email address", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an email address", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //reset function

        private void previewreset()
        {
            //preview label empty
            prename.Text = "Name: ";
            pregender.Text = "Gender: ";
            preemail.Text = "Email: ";
            prephone.Text = "Phone: ";
            preadd.Text = "Address: ";
            preservice.Text = "Service Area: ";
            prepayment.Text = "Payment Status: ";
            preassignedworkerid.Text = "Assigned Worker Id: ";
        }
        private void reset()
        {
            //feild empty
            f_name.Text = "";
            l_name.Text = "";
            gender.Text = "";
            email.Text = "";
            phone.Text = "";
            address.Text = "";
            servicearea.Text = "";
            paymentstatus.Text = "";

            previewreset();

            numericUpDown1.Value = 0;
            pnlpreview.Visible = false;
            btnclientsave.Visible = false;
        }

        private void btnresetclient_Click(object sender, EventArgs e)
        {
            reset();

        }

        //upload photo

        private void btnphoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog uploadPhoto = new OpenFileDialog();
                uploadPhoto.Title = "Select Photo";
                uploadPhoto.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
                if (uploadPhoto.ShowDialog() == DialogResult.OK)
                {
                    preclphoto.Image = new Bitmap(uploadPhoto.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Photo Selected", "Error Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //insert to database
        private void btnclientsave_Click(object sender, EventArgs e)
        {
            if (clientcount > existingclient)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "INSERT INTO CLIENT VALUES (@fn,@ln,@gn,@em,@ph,@fa,@ar,@ps,@WID,@pic)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", f_name.Text);
                    cmd.Parameters.AddWithValue("@ln", l_name.Text);
                    cmd.Parameters.AddWithValue("@gn", gender.Text);
                    cmd.Parameters.AddWithValue("@em", email.Text);
                    cmd.Parameters.AddWithValue("@ph", phone.Text);
                    cmd.Parameters.AddWithValue("@fa", address.Text);
                    cmd.Parameters.AddWithValue("@ar", servicearea.Text);
                    cmd.Parameters.AddWithValue("@ps", paymentstatus.Text);
                    cmd.Parameters.AddWithValue("@wid", numericUpDown1.Value);
                    cmd.Parameters.AddWithValue("@pic", clientphoto());

                    con.Open();

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Client Added Successfully.", "Insert Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();

                    }
                    else
                    {
                        MessageBox.Show("Client Not Added Successfully.", "Insert Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("You don't have calient capacity.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //image conver to byte
        private byte[] clientphoto()
        {
            MemoryStream pic = new MemoryStream();
            preclphoto.Image.Save(pic, preclphoto.Image.RawFormat);
            return pic.GetBuffer();
        }


        //Back option
        private void btncancelclient_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmsearchclient backtoclient = new frmsearchclient { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            backtoclient.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(backtoclient);
            backtoclient.Show();
        }
    }
}
