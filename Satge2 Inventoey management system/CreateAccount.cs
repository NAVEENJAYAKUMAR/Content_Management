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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {

            InitializeComponent();
        }
        SqlConnection Con = Newinventory.NewInventory;





        private void button2_Click(object sender, EventArgs e)
        {
            sign_in home = new sign_in();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + UnameTb.Text + "','" + FullnameTb.Text + "','" + PasswordTb.Text + "','" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sucessfully Added");
                Con.Close();
                
            }
            catch
            {

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
