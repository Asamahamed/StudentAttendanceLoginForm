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
    public partial class userStudentDetails : Form
    {
        public userStudentDetails()
        {
            InitializeComponent();
        }

        private void showDetails_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("select * from MacroInstitute.dbo.studentRegistration;", conDb);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userHomePage mp = new userHomePage();
            this.Hide();
            mp.Show();
        }

        private void srchById_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            conDb.Open();
            int id = Convert.ToInt32(textBox.Text);
            SqlDataAdapter adap = new SqlDataAdapter("select * from dbo.studentRegistration where id like '" + id + "%'", conDb);
            DataTable dataTable = new DataTable();
            adap.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conDb.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login as Admin to Delete Entries");
        }

        private void userStudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmLogin mp = new frmLogin();
            this.Hide();
            mp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
