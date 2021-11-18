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

namespace Satge2_Inventoey_management_system
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }
        SqlConnection Con = Newinventory.NewInventory;

        private void button2_Click(object sender, EventArgs e)
        {
            string UserName = UsernameTb.Text;
            string Password = PasswordTb.Text;
            if ((this.UsernameTb.Text == "Harry") && (this.PasswordTb.Text == "12345"))
            {


                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from UserTbl where Username='" + UsernameTb.Text + "' and  Password='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome Administrator");
                    AdmoinistraterPage home = new AdmoinistraterPage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password");
                }

                Con.Close();
            }
            else if ((this.UsernameTb.Text == "John") && (this.PasswordTb.Text == "12345"))
            {

                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from UserTbl where Username='" + UsernameTb.Text + "' and Password='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome Shipping Clerk");
                    Categoryhome home = new Categoryhome();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password");
                }

                Con.Close();
            }
            else if ((this.UsernameTb.Text == "Mike") && (this.PasswordTb.Text == "12345"))
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from UserTbl where Username='" + UsernameTb.Text + "' and Password='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welocme Stock Clerk");
                    stocklevel1 home = new stocklevel1();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password");
                }

                Con.Close();
            }
            else if ((this.UsernameTb.Text == "Parker") && (this.PasswordTb.Text == "12345"))
            {

                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from UserTbl where Username='" + UsernameTb.Text + "' and Password='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome Parker(customer)");
                    CustomerHomepage home = new CustomerHomepage();
                    home.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password");
                }

                Con.Close();
            }
            else if ((this.UsernameTb.Text == ""))
            {

                MessageBox.Show("Enter Your Username");
            }
            else if ((this.PasswordTb.Text == ""))
            {

                MessageBox.Show("Enter Your Password");
            }
            else
            {
                Con.Open();

                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from UserTbl where Username='" + UsernameTb.Text + "' and Password='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Welcome New Customer");
                    CustomerHomepage home = new CustomerHomepage();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username Or Password");
                }

                Con.Close();
            }

        }

        
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            CreateAccount home = new CreateAccount();
            home.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
                PasswordTb.isPassword = true;
            else
                PasswordTb.isPassword = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsernameTb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void sign_in_Load(object sender, EventArgs e)
        {

        }
    }
}
