using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macro_Institute_Project.User
{
    public partial class userAttendenceDetail : Form
    {
        public userAttendenceDetail()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            string quary = "Select dbo.studentRegistration.id ,dbo.studentRegistration.f_Name,dbo.studentRegistration.course,dbo.markAttendence.time from dbo.studentRegistration inner join dbo.markAttendence on dbo.studentRegistration.id = dbo.markAttendence.id";
            SqlCommand cmdDataBase = new SqlCommand(quary, conDb);
            try
            {
                SqlDataAdapter adap = new SqlDataAdapter();
                adap.SelectCommand = cmdDataBase;
                DataTable dataTable = new DataTable();
                adap.Fill(dataTable);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dataTable;

                dataGridView1.DataSource = bSource;
                adap.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            conDb.Open();
            int id = Convert.ToInt32(txtID.Text);
            SqlDataAdapter adap = new SqlDataAdapter("select * from dbo.markAttendence where id like '" + id + "%'", conDb);
            DataTable dataTable = new DataTable();
            adap.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conDb.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userHomePage mp = new userHomePage();
            this.Hide();
            mp.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login as Admin to delete Entries");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmLogin mp = new frmLogin();
            this.Hide();
            mp.Show();
        }
    }
}
