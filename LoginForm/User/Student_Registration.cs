using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Macro_Institute_Project;

namespace LoginForm
{

    public partial class Student_Registration : Form
    {

        public Student_Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {

                string MyConnection2 = @"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Initial Catalog=MacroInstitute;Integrated Security=True";
                SqlConnection conn = new SqlConnection(MyConnection2);
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adap = new SqlDataAdapter();
                string Query = "";
                Query = "insert into MacroInstitute.dbo.studentRegistration(f_Name,id_Number,age,address,telephoneNumber,course) values('" + this.f_Name.Text + "','" + this.NIC_Number.Text + "','" + this.age.Text + "','" + this.address.Text + "','" + this.telephone_Number.Text + "','" + this.course.Text + "');";
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

        private void f_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_Registration_Load(object sender, EventArgs e)
        {

        }

        private void Student_Registration_Load_1(object sender, EventArgs e)
        {

        }

        private void std_details_Click(object sender, EventArgs e)
        {
            StudentDetails objForm2 = new StudentDetails();
            this.Hide();
            objForm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NIC_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
