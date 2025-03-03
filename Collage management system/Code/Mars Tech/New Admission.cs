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
    public partial class New_Admission : Form
    {
        public New_Admission()
        {
            InitializeComponent();
        }

        private void New_Admission_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text;
            string mname = txtMotherName.Text;
            string gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            string dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string email = txtEmail.Text;
            string semester = txtSemester.Text;
            string program = txtProgramming.Text;
            string sname = txtSchoolName.Text;
            string duration = txtDuration.Text;
            string add = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS; data source = newmarstech;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission (fname, mname, gender, dob, mobile, email, semester, prog, sname, duration, addres) values ('" + name + "','" + mname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + semester + "','" + program + "','" + sname + "','" + duration + "','" + add + "')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved, Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();




            SqlConnection con = new SqlConnection();
            con.ConnectionString = "date soure = DESKTOP-ERO6VJJ\\SQLEXPRESS; datebase = newmarstech; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(NAID) from NewAdmission";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();


            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label13.Text = (abc + 1).ToString();




        }
    }
}
