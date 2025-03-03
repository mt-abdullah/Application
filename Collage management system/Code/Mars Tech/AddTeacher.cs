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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";
            bool isChecked = radioMale.Checked;
            if (isChecked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,yer,adr) values ('" + txtFName.Text + "','" + gender + "','" + dateTimePickerDOB.Text + "',"+txtMobile.Text+","+txtEmail.Text+"','"+txtSemester.Text+"','"+txtProgramming.Text+"','"+txtDuration.Text+"','"+txtAddress.Text+"')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
