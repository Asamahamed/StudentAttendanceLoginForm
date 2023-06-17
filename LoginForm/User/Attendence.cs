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
    public partial class Attendence : Form
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            try
            {
                time.Text = dateTimePicker2.Value.ToString();

                string MyConnection2 = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
                SqlConnection conn = new SqlConnection(MyConnection2);
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adap = new SqlDataAdapter();
                string Query = "";
                Query = "insert into MacroInstitute.dbo.markAttendence(id,time) values('" + this.stdID.Text + "','" + this.time.Text + "');";
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

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            userHomePage mp = new userHomePage();
            this.Hide();
            mp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmLogin mp = new frmLogin();
            this.Hide();
            mp.Show();
        }

        private void stdID_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
