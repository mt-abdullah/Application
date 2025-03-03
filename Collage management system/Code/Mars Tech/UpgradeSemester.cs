using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Mars_Tech
{
    public partial class UpgradeSemester : Form
    {
        public UpgradeSemester()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Semester Update Warning !", "Confirm?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                {
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "update NewAdmission set semester = '" + comboBoxTo.Text + "' where semester='" + comboBoxFrom.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    MessageBox.Show("Upgrade Successful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                {
                    MessageBox.Show("Upgrde Cancelled", "Cancle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
