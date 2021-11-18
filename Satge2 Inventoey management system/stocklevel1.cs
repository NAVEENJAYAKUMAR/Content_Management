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
    public partial class stocklevel1 : Form
    {
        public stocklevel1()
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
                string Myquery = "select * from ProductTbl ";
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
                string Myquery = "select * from ProductTbl where ProductCat='" + SearchCombo.SelectedValue.ToString() + "'";
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

        private void stocklevel1_Load(object sender, EventArgs e)
        {
            populate();
            fillcategory();
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
            sign_in home = new sign_in();
            home.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product4 home = new Product4();
            home.Show();
            this.Hide();
        }

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
