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
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAdmission";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridViewDStudent.DataSource = ds.Tables[0];

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE Your Data.","warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-ERO6VJJ\\SQLEXPRESS;database = newmarstech;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewAdmission where NAID =" + txtRegID.Text + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                MessageBox.Show("Deletion Succcessful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            
        }
    }
}
