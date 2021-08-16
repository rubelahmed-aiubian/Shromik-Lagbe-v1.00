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
    public partial class frmloading : Form
    {
        string db = ConfigurationManager.ConnectionStrings["shromik"].ConnectionString;
        public frmloading()
        {
            InitializeComponent();
        }

        //timer
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 1;
            progressBar1.Value = startPoint;
            if (progressBar1.Value == 100)
            {
                try
                {
                    SqlConnection con = new SqlConnection(db);
                    string query = "SELECT COUNT(*) FROM LOGIN";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();

                    double result = Convert.ToDouble(cmd.ExecuteScalar());

                    if (result > 0)
                    {
                        progressBar1.Value = 0;
                        timer1.Stop();

                        frmsignin signin = new frmsignin();
                        this.Hide();
                        signin.Show();
                    }
                    else
                    {
                        progressBar1.Value = 0;
                        timer1.Stop();
                        this.Hide();
                        frmadmin admin = new frmadmin();
                        admin.Show();
                    }
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something is not right.", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmloading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
