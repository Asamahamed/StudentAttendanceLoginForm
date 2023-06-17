using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using Macro_Institute_Project;

namespace LoginForm
{
    public partial class frmLogin : Form
    {
        SqlDataAdapter sd;
        DataTable dTable;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QEAACQB\SQLEXPRESS;Integrated Security=True;Initial Catalog=MacroInstitute;");
            String quary = " Select * from loginTable where username = '" + userName.Text.Trim() + "'and password = '" + password.Text.Trim() + "'";
            sd = new SqlDataAdapter(quary, con);
            dTable = new DataTable();
            sd.Fill(dTable);
            if (dTable.Rows.Count == 1)
            {
                MessageBox.Show("You Have Logged in as user");
                userHomePage p = new userHomePage();
                this.Hide();
                p.Show();
            }
            else
            {
                //MessageBox.Show("Please Enter Your UserName and Password");
                String quary2 = " Select * from adminLoginTable where username = '" + userName.Text.Trim() + "'and password = '" + password.Text.Trim() + "'";
                SqlDataAdapter sd1 = new SqlDataAdapter(quary2, con);
                DataTable dTable1 = new DataTable();
                sd1.Fill(dTable1);
                if (dTable1.Rows.Count == 1)
                {
                    MessageBox.Show("You Have Logged in as admin");
                    MainPage p = new MainPage();
                    this.Hide();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Your UserName and Password");
                }
            }




        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            MainPage p = new MainPage();
            this.Hide();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
