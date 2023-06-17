using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macro_Institute_Project
{

    public partial class AttendenceDetails : Form
    {
        SqlDataAdapter adap;
        DataTable dataTable;
        public AttendenceDetails()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            String quary = "Select dbo.studentRegistration.id ,dbo.studentRegistration.f_Name,dbo.studentRegistration.course,dbo.markAttendence.time from dbo.studentRegistration inner join dbo.markAttendence on dbo.studentRegistration.id = dbo.markAttendence.id";
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
            adap = new SqlDataAdapter("select * from dbo.studentRegistration where id like '" + id + "%'", conDb);
            dataTable = new DataTable();
            adap.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conDb.Close();
        }

        private void AttendenceDetails_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Show();
            mp.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
                int id = Convert.ToInt32(txtID.Text);
                string Query = "delete from dbo.markAttendence where id = '" + id + "';";
                SqlConnection MyConn = new SqlConnection(conString);
                SqlCommand MyCommand = new SqlCommand(Query, MyConn);
                SqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {



        }

        private void txtID_TextChanged(object sender, EventArgs e)
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
