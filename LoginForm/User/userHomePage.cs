using LoginForm;
using Macro_Institute_Project.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Macro_Institute_Project
{
    public partial class userHomePage : Form
    {
        public userHomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
             Student_Registration sr = new Student_Registration();
            this.Hide();
            sr.Show();
        }

        private void btnStudentDetails_Click(object sender, EventArgs e)
        {
            userStudentDetails sd = new userStudentDetails();
            this.Hide();
            sd.Show();
        }

        private void btnAttendenceDetails_Click(object sender, EventArgs e)
        {
            userAttendenceDetail p = new userAttendenceDetail();
            this.Hide();
            p.Show();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            Attendence p = new Attendence();
            this.Hide();
            p.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmLogin mp = new frmLogin();
            this.Hide();
            mp.Show();
        }
    }
}
