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
    public partial class frmadmin : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmadmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnresetclient_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && fname.Text != "" && lname.Text !="" && email.Text!="" && phonenumber.Text !="" && costperhour.Value !=0 && clientcapacity.Value != 0 && workercapacity.Value !=0)
            {
                bool em = email.Text.Contains('@');
                if (em == true)
                {
                    DialogResult yesno = MessageBox.Show("Do you want to go in next step?", "Confirmation", MessageBoxButtons.YesNo);
                    if (yesno == DialogResult.Yes)
                    {
                        pnlsetpass.Visible = true;
                        btnnextstep.Visible = false;
                    }
                    else
                    {
                        //nothing will happen here
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

        private void btnphoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog uploadPhoto = new OpenFileDialog();
                uploadPhoto.Title = "Select Photo";
                uploadPhoto.Filter = "Image Files(*.BMP;*.JPG;*.PNG;*.GIF)|*.BMP;*.JPG;*.PNG;*.GIF|All files (*.*)|*.*";
                if (uploadPhoto.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image = new Bitmap(uploadPhoto.FileName);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No Photo Selected", "Error Upload", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text !="" && textBox3.Text !="")
            {
                if(textBox2.Text == textBox3.Text)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(db);
                        string query = "INSERT INTO LOGIN VALUES (@US,@PS,@FN,@LN,@EM,@PN,@FA,@CH,@CC,@WC,@PIC)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@US",username.Text);
                        cmd.Parameters.AddWithValue("@PS",textBox2.Text);
                        cmd.Parameters.AddWithValue("@FN",fname.Text);
                        cmd.Parameters.AddWithValue("@ln",lname.Text);
                        cmd.Parameters.AddWithValue("@EM",email.Text);
                        cmd.Parameters.AddWithValue("@PN",phonenumber.Text);
                        cmd.Parameters.AddWithValue("@FA",fulladdress.Text);
                        cmd.Parameters.AddWithValue("@CH",costperhour.Value);
                        cmd.Parameters.AddWithValue("@CC",clientcapacity.Text);
                        cmd.Parameters.AddWithValue("@WC",workercapacity.Text);
                        cmd.Parameters.AddWithValue("@PIC",getphoto());

                        con.Open();

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Admin setup was successfull. You can sign in now", "Setup Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            frmsignin sign = new frmsignin();
                            sign.Show();

                        }
                        else
                        {
                            MessageBox.Show("Admin setup was not successfull.", "Setup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Password Not Matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //image conver to byte
        private byte[] getphoto()
        {
            MemoryStream pic = new MemoryStream();
            pictureBox2.Image.Save(pic, pictureBox2.Image.RawFormat);
            return pic.GetBuffer();
        }
    }
}
