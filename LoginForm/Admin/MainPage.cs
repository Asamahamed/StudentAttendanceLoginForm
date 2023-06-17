using LoginForm;
using Macro_Institute_Project.Admin;
using System;
using System.Windows.Forms;
//System.InvalidOperationException
namespace Macro_Institute_Project
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            this.Hide();
            sd.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Student_Registration p = new Student_Registration();
            this.Hide();
            p.Show();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            Attendence p1 = new Attendence();
            this.Hide();
            p1.Show();
        }

        private void btnAttendenceDetails_Click(object sender, EventArgs e)
        {
            AttendenceDetails p = new AttendenceDetails();
            this.Hide();
            p.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
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

        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Payment mp = new Payment();
            this.Hide();
            mp.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
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
