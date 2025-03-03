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
    public partial class StudentlndividualDetail : Form
    {
        public StudentlndividualDetail()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS; database = newmarstech;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission where NAID = " + textBox1.Text + "";


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {



                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelMName.Text = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelStandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelMedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelSName.Text = ds.Tables[0].Rows[0][9].ToString();
                labelYear.Text = ds.Tables[0].Rows[0][10].ToString();
                labelAddress.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelFullName.Text = "________";
                labelMName.Text = "________";
                labelGender.Text = "________";
                labelDOB.Text = "________";
                labelMobile.Text = "________";
                labelEmail.Text = "________";
                labelStandard.Text = "________";
                labelMedium.Text = "________";
                labelSName.Text = "________";
                labelYear.Text = "________";
                labelAddress.Text = "________";
            }
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void StudentlndividualDetail_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "________";
            labelMName.Text = "________";
            labelGender.Text = "________";
            labelDOB.Text = "________";
            labelMobile.Text = "________";
            labelEmail.Text = "________";
            labelStandard.Text = "________";
            labelMedium.Text = "________";
            labelSName.Text = "________";
            labelYear.Text = "________";
            labelAddress.Text = "________";

            textBox1.Text = "";

        }
    }
}
