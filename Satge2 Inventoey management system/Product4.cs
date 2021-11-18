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
    public partial class Product4 : Form
    {
        public Product4()
        {
            InitializeComponent();
        }
        SqlConnection Con = Newinventory.NewInventory;

        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoriesName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CategoriesName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CategoriesName";
                SearchCombo.DataSource = dt;
                Con.Close();

            }
            catch
            {

            }



        }





        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where CategoryId=1";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        void filterbycategory()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where ProductCat='" + CatCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }

        private void Product4_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
            CategoryIdTb.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdNameTb.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            QtyTb.Text = ProductsGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            DescriptionTb.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            CatCombo.SelectedValue = ProductsGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProdIdTb.Text + "','" + CategoryIdTb.Text + "','" + ProdNameTb.Text + "','" + QtyTb.Text + "','" + PriceTb.Text + "','" + DescriptionTb.Text + "','" + CatCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Sucessfully Added");
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
                SqlCommand cmd = new SqlCommand("update ProductTbl set CategoryId ='" + CategoryIdTb.Text + "', ProductName = '" + ProdNameTb.Text + "' ,ProductQty='" + QtyTb.Text + "', ProductPrice = '" + PriceTb.Text + "',ProductDec='" + DescriptionTb.Text + "',ProductCat='" + CatCombo.SelectedValue.ToString() + "' Where ProductId ='" + ProdIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Sucessfully Updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter The Product Id");

            }
            else
            {
                Con.Open();
                string myquery = "delete from ProductTbl where ProductId = '" + ProdIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myquery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully Deleted");
                Con.Close();
                populate();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            stocklevel1 home = new stocklevel1();
            home.Show();
            this.Hide();
        }
    }
}
