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
    public partial class Category : Form
    {
        public Category()
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
        private void CategoriesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Category3 home = new Category3();
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
