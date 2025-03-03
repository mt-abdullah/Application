using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Mars_Tech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            panel1.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnlLogin_Click(object sender, EventArgs e)
        {
            {
                string username = textBox1.Text;
                string password = textBox2.Text;

                if (username == "student" && password == "student")
                {
                    menuStrip1.Visible = true;
                    panel1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Invalid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_Admission na = new New_Admission();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester us = new UpgradeSemester();
            us.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Fees fs = new Fees();
            fs.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudents ss = new SearchStudents();
            ss.Show();
      }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void indiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentlndividualDetail sid = new StudentlndividualDetail();
            sid.Show();
        }

        private void addTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUs us = new AboutUs();
            us.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure ? This will Delete Your UNSAVED Data", "Confirmation Daialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }

           
        }
    }
}
