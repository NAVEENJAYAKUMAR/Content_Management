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
    public partial class stocklevel : Form
    {
        public stocklevel()
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


        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void stocklevel_Load(object sender, EventArgs e)
        {
            fillcategory();
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product3 home = new Product3();
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdmoinistraterPage home1 = new AdmoinistraterPage();
            home1.Show();
            this.Hide();
        }
    }
}
