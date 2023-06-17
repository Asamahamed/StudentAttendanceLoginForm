using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using LoginForm;

namespace Macro_Institute_Project
{
    public partial class StudentDetails : Form
    {
        DataTable dataTable;
        SqlDataAdapter adap;
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

        }

        private void showDetails_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand("select * from MacroInstitute.dbo.studentRegistration;", conDb);
            try
            {
                adap = new SqlDataAdapter();
                adap.SelectCommand = cmdDataBase;
                dataTable = new DataTable();
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

        private void srchById_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
            SqlConnection conDb = new SqlConnection(conString);
            conDb.Open();
            int id = Convert.ToInt32(textBox.Text);
            adap = new SqlDataAdapter("select * from dbo.studentRegistration where id like '" + id + "%'", conDb);
            dataTable = new DataTable();
            adap.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            conDb.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String conString = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
                int id = Convert.ToInt32(textBox.Text);
                string Query = "delete from dbo.studentRegistration where id = '" + id + "';";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmLogin mp = new frmLogin();
            this.Hide();
            mp.Show();
        }
    }
}
