using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmsearchclient : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;

        public frmsearchclient()
        {
            InitializeComponent();
            loadData();
        }


        private void loadData()
        {
            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                string query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT";
                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewClient.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewClient.Columns[8];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewClient.RowTemplate.Height = 80;

            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //button add client

        private void btnaddclient_Click(object sender, EventArgs e)
        {
            this.pnlsearchmain.Controls.Clear();
            frmaddclinet addcl = new frmaddclinet { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            addcl.FormBorderStyle = FormBorderStyle.None;
            this.pnlsearchmain.Controls.Add(addcl);
            addcl.Show();
        }

        //button update

        int passid = 0;
        private void dataGridViewClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            passid = Int32.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void btnupdateclient_Click(object sender, EventArgs e)
        {
            if (passid > 0)
            {
                this.pnlsearchmain.Controls.Clear();
                frmupdateclient upcl = new frmupdateclient(passid) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                upcl.FormBorderStyle = FormBorderStyle.None;
                this.pnlsearchmain.Controls.Add(upcl);
                upcl.Show();
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Row Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        //button delete
        private void btndeleteclient_Click(object sender, EventArgs e)
        {
            if (passid > 0)
            {
                DialogResult yesno = MessageBox.Show("Do you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo);

                if (yesno == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(db);
                        string query = "DELETE FROM CLIENT WHERE ClientId = @id";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@id", passid);


                        con.Open();

                        int res = cmd.ExecuteNonQuery();

                        if (res > 0)
                        {
                            MessageBox.Show("Client Delete Successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();

                        }
                        else
                        {
                            MessageBox.Show("Client Not Deleted", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    this.Controls.Clear();
                    frmsearchclient backtoclient = new frmsearchclient { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    backtoclient.FormBorderStyle = FormBorderStyle.None;
                    this.Controls.Add(backtoclient);
                    backtoclient.Show();
                }


            }
            else
            {
                MessageBox.Show("Please select a row first.", "Row Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //search filter query

        string query = "";

        private void querycheck()
        {
            if(comboBox1.Text == "All Area" && comboBox2.Text == "Worker Hired OR Not")
            {
                query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT";
            }
            else if(comboBox1.Text != "All Area" && comboBox2.Text == "Worker Hired OR Not")
            {
                query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT WHERE ServiceArea LIKE '" + comboBox1.SelectedItem + "%'";
            }
            else if(comboBox1.Text == "All Area" && comboBox2.Text != "Worker Hired OR Not")
            {
                if(comboBox2.Text == "Yes")
                {
                    query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT WHERE WorkerId != '0'";
                }
                else
                {
                    query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT WHERE WorkerId = '0'";
                }
            }
            else
            {
                query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT WHERE ServiceArea LIKE '" + comboBox1.SelectedItem + "%' AND PaymentStatus LIKE '"+comboBox2.Text+"%'";
            }
        }

        // area filter
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //query choose

            querycheck();

            try
            {
                SqlConnection con = new SqlConnection(db);

                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewClient.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewClient.Columns[8];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewClient.RowTemplate.Height = 80;
            }
            catch (Exception)
            {
                MessageBox.Show("Something is Not Right", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //payment status filter

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //query choose

                querycheck();

                SqlConnection con = new SqlConnection(db);

                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewClient.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewClient.Columns[8];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewClient.RowTemplate.Height = 80;

            }
            catch (Exception)
            {
                MessageBox.Show("Something is Not Right", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbox_Enter(object sender, EventArgs e)
        {
            if(searchbox.Text == "Enter Client Name")
            {
                searchbox.Text = "";
            }
        }

        private void searchbox_Leave(object sender, EventArgs e)
        {
            if(searchbox.Text == "")
            {
                searchbox.Text = "Enter Client Name";
                loadData();
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);

                query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Email, PhoneNumber, FullAddress, ServiceArea, WorkerId as 'Assigned W.ID', Picture from CLIENT WHERE FirstName LIKE '" +searchbox.Text+"%' OR LastName LIKE '"+searchbox.Text+"%'";

                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewClient.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewClient.Columns[8];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewClient.RowTemplate.Height = 80;
                dataGridViewClient.Refresh();

            }
            catch (Exception)
            {
                MessageBox.Show("Something is Not Right", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
