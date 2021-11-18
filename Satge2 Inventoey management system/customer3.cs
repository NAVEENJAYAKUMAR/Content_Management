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
    public partial class customer3 : Form
    {
        public customer3()
        {
            InitializeComponent();
        }
        SqlConnection Con = Newinventory.NewInventory;
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        private void customer3_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CustomerTbl values('" + CustomerIdTb.Text + "','" + CustomerNameTb.Text + "','" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Sucessfully Added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CustomerTbl set CustomerName = '" + CustomerNameTb.Text + "' ,CustomerPhone ='" + CustomerPhoneTb.Text + "' Where Customerid ='" + CustomerIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Sucessfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIdTb.Text == "")
            {
                MessageBox.Show("Enter The Customer Id");

            }
            else
            {
                Con.Open();
                string myquery = "delete from CustomerTbl where Customerid = '" + CustomerIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer successfully Deleted");
                Con.Close();
                populate();
            }
            
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustomerNameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneTb.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            customer home = new customer();
            home.Show();
            this.Hide();
        }
    }
}
