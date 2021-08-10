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
    public partial class frmdashboard : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmdashboard()
        {
            InitializeComponent();
            clientrowscount();
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
                var rowscount = cmd.ExecuteScalar();
                con.Close();

                lblclientcount.Text ="0" + rowscount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Something is not right.", "Error occured", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
