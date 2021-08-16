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
using LiveCharts.Wpf;

namespace Shromik_Lagbe_v1._00
{
    public partial class frmdashboard : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        double clinetrows = 0;
        double workerrows = 0;
        double paidClient=0;
        double paidWorker=0;
        double costperhour = 500;
        public frmdashboard()
        {
            InitializeComponent();
            clientrowscount();
            workerrowscount();
            livegraph();
            totalearnings();
        }

        //client count

        private void clientrowscount()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM CLIENT";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                clinetrows = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

                lblclientcount.Text ="0" + clinetrows.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        } 
        
        //worker rows count
        private void workerrowscount()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM WORKER";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                workerrows = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

                lblworkercount.Text ="0" + workerrows.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        //total earnings

        private void totalearnings()
        {

            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM CLIENT WHERE PaymentStatus = 'PAID'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                paidClient = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            try
            {
                SqlConnection con = new SqlConnection(db);
                string query = "SELECT COUNT(*) FROM WORKER WHERE PaymentStatus = 'PAID'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                paidWorker = Convert.ToDouble(cmd.ExecuteScalar());
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            double earnings = (0.05 * ((paidClient * costperhour) - (paidWorker * costperhour)));


            label14.Text = earnings.ToString()+" Tk";
        }


        //live graph

        private void livegraph()
        {
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new LiveCharts.ChartValues<double> {clinetrows-3, clinetrows-5, clinetrows-1, clinetrows-2, clinetrows }
            }) ;

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = new LiveCharts.ChartValues<double> {workerrows-3, workerrows-1, workerrows-5, workerrows}
            });
        }

        //export function
        //client report download
        private void btnexportclient_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Files (*.csv)|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //
                }
            }
        }

        //worker report download
        private void btnworkerexport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV Files (*.csv)|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //
                }
            }
        }
    }
}
