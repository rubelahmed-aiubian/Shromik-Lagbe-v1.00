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
    public partial class frmsearchworker : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmsearchworker()
        {
            InitializeComponent();
            loadData();
        }


        //load data
        private void loadData()
        {
            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                string query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, Picture from WORKER";
                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewworker.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewworker.Columns[7];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewworker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewworker.RowTemplate.Height = 80;
            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //add clinet button
        private void btnaddworker_Click(object sender, EventArgs e)
        {
            this.pnlsearchmain.Controls.Clear();
            frmaddworker addwork = new frmaddworker { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            addwork.FormBorderStyle = FormBorderStyle.None;
            this.pnlsearchmain.Controls.Add(addwork);
            addwork.Show();
        }

        //button update
        int passid = 0;
        private void dataGridViewworker_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            passid = Int32.Parse(dataGridViewworker.SelectedRows[0].Cells[0].Value.ToString());
        }
        private void btnupdateworker_Click(object sender, EventArgs e)
        {
            if (passid > 0)
            {
                this.pnlsearchmain.Controls.Clear();
                frmupdateworker upw = new frmupdateworker(passid) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                upw.FormBorderStyle = FormBorderStyle.None;
                this.pnlsearchmain.Controls.Add(upw);
                upw.Show();
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Row Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btndeleteworker_Click(object sender, EventArgs e)
        {
            if (passid > 0)
            {
                DialogResult yesno = MessageBox.Show("Do you want to delete this worker?", "Confirmation", MessageBoxButtons.YesNo);

                if (yesno == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(db);
                        string query = "DELETE FROM WORKER WHERE WorkerId = @id";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@id", passid);


                        con.Open();

                        int res = cmd.ExecuteNonQuery();

                        if (res > 0)
                        {
                            MessageBox.Show("Worker Delete Successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();

                        }
                        else
                        {
                            MessageBox.Show("Worker Not Deleted", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        con.Close();
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Something is not right", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("Please select a row first.", "Row Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //search filter query

        string query = "";

        private void querycheck()
        {
            if (comboBox1.Text == "All Area" && comboBox2.Text == "Occupation")
            {
                query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, Picture from WORKER";
            }
            else if (comboBox1.Text != "All Area" && comboBox2.Text == "Occupation")
            {
                query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, Picture from WORKER WHERE ServiceArea LIKE '" + comboBox1.SelectedItem + "%'";
            }
            else if (comboBox1.Text == "All Area" && comboBox2.Text != "Occupation")
            {
                query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, Picture from WORKER WHERE Occupation LIKE '" + comboBox2.SelectedItem + "%'";
            }
            else if(comboBox1.Text != "All Area" && comboBox2.Text != "Occupation")
            {
                query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, Picture from WORKER WHERE ServiceArea LIKE '" + comboBox1.SelectedItem + "%' AND Occupation LIKE '" + comboBox2.SelectedItem + "%'";
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            querycheck();

            try
            {
                SqlConnection con = new SqlConnection(db);

                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewworker.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewworker.Columns[7];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewworker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewworker.RowTemplate.Height = 80;
            }
            catch (Exception)
            {
                MessageBox.Show("Something is Not Right", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
                dataGridViewworker.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewworker.Columns[7];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewworker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewworker.RowTemplate.Height = 80;

            }
            catch (Exception)
            {
                MessageBox.Show("Something is Not Right", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbox_Enter(object sender, EventArgs e)
        {
            if (searchbox.Text == "Enter Worker Name")
            {
                searchbox.Text = "";
            }
        }

        private void searchbox_Leave(object sender, EventArgs e)
        {
            if (searchbox.Text == "")
            {
                searchbox.Text = "Enter Worker Name";
                loadData();
            }
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);

                query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', Gender, Occupation, PhoneNumber, FullAddress, ServiceArea, Picture from WORKER WHERE FirstName LIKE '" + searchbox.Text + "%' OR LastName LIKE '" + searchbox.Text + "%'";

                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridViewworker.DataSource = data;

                //image column
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                img = (DataGridViewImageColumn)dataGridViewworker.Columns[7];
                img.ImageLayout = DataGridViewImageCellLayout.Stretch;
                dataGridViewworker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewworker.RowTemplate.Height = 80;
                dataGridViewworker.Refresh();

            }
            catch (Exception)
            {
                MessageBox.Show("Something is Not Right", "Error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
