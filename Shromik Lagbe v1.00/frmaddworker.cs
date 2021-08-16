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
    public partial class frmaddworker : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        double workercapacity;
        double existingworker;
        public frmaddworker()
        {
            InitializeComponent();
        }

        //check worker count
        private void workernumbercheck()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT WorkerCapacity FROM LOGIN";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    workercapacity = Convert.ToDouble(da.GetValue(0));
                }


                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //existing worker number

        private void existingworkercheck()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM WORKER";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                existingworker = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //reset function
        private void reset()
        {
            //feild empty
            f_name.Text = "";
            l_name.Text = "";
            gender.Text = "";
            occupation.Text = "";
            phone.Text = "";
            address.Text = "";
            servicearea.Text = "";
            paymentstatus.Text = "";

            //preview label empty
            prename.Text = "Name: ";
            pregender.Text = "Gender: ";
            preocc.Text = "Occupation: ";
            prephone.Text = "Phone: ";
            preadd.Text = "Address: ";
            preservice.Text = "Service Area: ";
            prepayment.Text = "Payment Status: ";
            pnlpreview.Visible = false;
            btnsave.Visible = false;
        }

        //worker reset
        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        //add worker preview

        private void btnpreview_Click(object sender, EventArgs e)
        {
            if (f_name.Text != "" && l_name.Text != "" && gender.Text != "" && occupation.Text != "" && phone.Text != "" && address.Text != "" && servicearea.Text != "" && paymentstatus.Text != "")
            {
                prename.Text = prename.Text + " " + f_name.Text + " " + l_name.Text;
                pregender.Text = pregender.Text + " " + gender.Text;
                preocc.Text = preocc.Text + " " + occupation.Text;
                prephone.Text = prephone.Text + " " + phone.Text;
                preadd.Text = preadd.Text + " " + address.Text;
                preservice.Text = preservice.Text + " " + servicearea.Text;
                prepayment.Text = prepayment.Text + " " + paymentstatus.Text;

                pnlpreview.Visible = true;
                btnsave.Visible = true;
                label12.Visible = false;

            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
                    preworkerphoto.Image = new Bitmap(uploadPhoto.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Photo Selected", "Error Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //back button

        private void btnworkerback_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            frmsearchworker backtoworker = new frmsearchworker { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            backtoworker.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(backtoworker);
            backtoworker.Show();
        }

        //save button
        private void btnsave_Click(object sender, EventArgs e)
        {
            if(workercapacity > existingworker)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "INSERT INTO WORKER VALUES (@fn,@ln,@gn,@oc,@ph,@fa,@ar,@ps,@pic)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@fn", f_name.Text);
                    cmd.Parameters.AddWithValue("@ln", l_name.Text);
                    cmd.Parameters.AddWithValue("@gn", gender.Text);
                    cmd.Parameters.AddWithValue("@oc", occupation.Text);
                    cmd.Parameters.AddWithValue("@ph", phone.Text);
                    cmd.Parameters.AddWithValue("@fa", address.Text);
                    cmd.Parameters.AddWithValue("@ar", servicearea.Text);
                    cmd.Parameters.AddWithValue("@ps", paymentstatus.Text);
                    cmd.Parameters.AddWithValue("@pic", workerphoto());

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
                MessageBox.Show("You dont have worker capacity", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //image conver to byte
        private byte[] workerphoto()
        {
            MemoryStream pic = new MemoryStream();
            preworkerphoto.Image.Save(pic, preworkerphoto.Image.RawFormat);
            return pic.GetBuffer();
        }
    }
}
