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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection Con = Newinventory.NewInventory;
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        private void User_Load(object sender, EventArgs e)
        {
            populate();
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
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Enter The User Phone Number");

            }
            else
            {
                Con.Open();
                string myquery = "delete from UserTbl where Telephone = '" + PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            UnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FullnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            PasswordTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            PhoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Username ='" + UnameTb.Text + "',Fullname = '" + FullnameTb.Text + "', Password ='" + PasswordTb.Text + "' where Telephone ='" + PhoneTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sucessfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            User1 home = new User1();
            home.Show();
            this.Hide();
        }
    }
}
