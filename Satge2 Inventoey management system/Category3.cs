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
    public partial class Category3 : Form
    {
        public Category3()
        {
            InitializeComponent();
        }
        SqlConnection Con = Newinventory.NewInventory;
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CatIdTb.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
            CatNameTb.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into CategoryTbl values('" + CatIdTb.Text + "','" + CatNameTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Sucessfully Added");
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
                SqlCommand cmd = new SqlCommand("update CategoryTbl set CategoriesName = '" + CatNameTb.Text + "' where CategoriesId='" + CatIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Sucessfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (CatIdTb.Text == "")
            {
                MessageBox.Show("Enter The Category Id");

            }
            else
            {
                Con.Open();
                string myquery = "delete from CategoryTbl where CategoriesId = '" + CatIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Category home = new Category();
            home.Show();
            this.Hide();
        }
    }
}
