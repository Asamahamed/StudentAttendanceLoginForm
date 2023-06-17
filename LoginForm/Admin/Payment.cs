using LoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macro_Institute_Project.Admin
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                string MyConnection2 = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
                SqlConnection conn = new SqlConnection(MyConnection2);
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adap = new SqlDataAdapter();
                string Query = "";
                Query = "insert into MacroInstitute.dbo.paymentTable(stdID,stdName,course,courseFee) values('" + this.stdID.Text + "','" + this.stdName.Text + "','" + this.course.Text + "','" + this.courseFee.Text + "');";
                cmd = new SqlCommand(Query, conn);
                adap.InsertCommand = new SqlCommand(Query, conn);
                adap.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Data Updated");

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void stdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void courseFee_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
