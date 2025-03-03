using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Mars_Tech
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
            


            if (txtRegNumber.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select fname,mname,duration from NewAdmission where NAID = " + txtRegNumber.Text + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                if (DS.Tables[0].Rows.Count != 0)
                {
                    fnameLabel.Text = DS.Tables[0].Rows[0][0].ToString();
                    MnameLabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    durationLabel.Text = DS.Tables[0].Rows[0][2].ToString();
                }
                else
                {
                    fnameLabel.Text = "---------------";
                    MnameLabel.Text = "---------------";
                    durationLabel.Text = "---------------";
                }

            }
            else
            {
                txtRegNumber.Text = "";
                txtRegNumber.Text = "";
                fnameLabel.Text = "---------------";
                MnameLabel.Text = "---------------";
                durationLabel.Text = "---------------";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID = " + txtRegNumber + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if(DS.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection();
                con1.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
                SqlCommand cmd1 = new SqlCommand();
                cmd.Connection = con1;

                cmd.CommandText = "insert into fees (NAID,fees) values (" + txtRegNumber.Text + "," + txtFees.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Fees Sumition Successfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnameLabel.Text = "---------------";
                    MnameLabel.Text = "---------------";
                    durationLabel.Text = "---------------";

                }
            }
            else
            {
                MessageBox.Show("Fees is AllReady Sumitted.");

                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "---------------";
                MnameLabel.Text = "---------------";
                durationLabel.Text = "---------------";
            }

            
                    
        }
    }
}
