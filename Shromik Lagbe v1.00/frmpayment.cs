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
    public partial class frmpayment : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;

        double costperhour;
        public frmpayment()
        {
            InitializeComponent();
            getcostperhour();
        }

        //cost per hour
        private void getcostperhour()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT CostPerHour FROM LOGIN";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader da = cmd.ExecuteReader();

                while (da.Read())
                {
                    costperhour = Convert.ToDouble(da.GetValue(0));
                }


                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmpayment_Load(object sender, EventArgs e)
        {
            //client data load
            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                string query = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from CLIENT";
                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridView1.DataSource = data;
                
                //column size
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView1.ColumnHeadersHeight = 30;
            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //worker data load

            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                string query = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from WORKER";
                SqlDataAdapter readData = new SqlDataAdapter(query, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridView2.DataSource = data;

                //column size
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                dataGridView2.ColumnHeadersHeight = 30;
            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--------------------client calculation------------------>

            //paid client + received money
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM CLIENT WHERE PaymentStatus = 'PAID'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                double paidClient = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

                label10.Text = "0" + paidClient.ToString();

                label11.Text = (paidClient * costperhour).ToString()+" Tk";
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            //unpaid client + due money
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM CLIENT WHERE PaymentStatus = 'UNPAID'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                double unpaidClient = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

                label12.Text = "0" + unpaidClient.ToString();

                label14.Text = (unpaidClient * costperhour).ToString()+" Tk";
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            //--------------------worker calculation------------------>

            //paid worker + received money

            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM WORKER WHERE PaymentStatus = 'PAID'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                double paidWorker = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

                label9.Text = "0" + paidWorker.ToString();

                label8.Text = (paidWorker * costperhour).ToString() + " Tk";
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            //unpaid worker + due money
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM WORKER WHERE PaymentStatus = 'UNPAID'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                double unpaidWorker = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

                label7.Text = "0" + unpaidWorker.ToString();

                label6.Text = (unpaidWorker * costperhour).ToString() + " Tk";
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //search filter query

        string clientquery = "";
        string workerquery = "";

        //client query check

        private void clientquerycheck()
        {
            if(comboBox2.Text == "PAID")
            {
                clientquery = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from CLIENT WHERE PaymentStatus = 'PAID'";
            }
            else if(comboBox2.Text == "UNPAID")
            {
                clientquery = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from CLIENT WHERE PaymentStatus = 'UNPAID'";
            }
            else
            {
                clientquery = "select ClientId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from CLIENT";
            }
        }

        //worker query check
        private void workerquerycheck()
        {
            if (comboBox1.Text == "PAID")
            {
                workerquery = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from WORKER WHERE PaymentStatus = 'PAID'";
            }
            else if (comboBox1.Text == "UNPAID")
            {
                workerquery = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from WORKER WHERE PaymentStatus = 'UNPAID'";
            }
            else
            {
                workerquery = "select WorkerId As ID, FirstName +' '+ Lastname as 'Full Name', PaymentStatus as 'Payment Status' from WORKER";
            }
        }

        //client filter
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            //query selection

            clientquerycheck();

            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                SqlDataAdapter readData = new SqlDataAdapter(clientquery, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridView1.DataSource = data;

                //column size
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //worker filter
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //query selection

            workerquerycheck();

            try
            {
                //connect database
                SqlConnection con = new SqlConnection(db);
                SqlDataAdapter readData = new SqlDataAdapter(workerquery, con);

                //load data

                DataTable data = new DataTable();
                readData.Fill(data);
                dataGridView2.DataSource = data;

                //column size
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception)
            {
                MessageBox.Show("Data is not loaded sucessfully.", "Conncetion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
