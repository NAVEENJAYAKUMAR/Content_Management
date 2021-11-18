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
    public partial class YourOrders : Form
    {
        public YourOrders()
        {
            InitializeComponent();
        }
         SqlConnection Con = Newinventory.NewInventory;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ViewGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void YourOrders_Load(object sender, EventArgs e)
        {
            populateproducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerHomepage home = new CustomerHomepage();
            home.Show();
            this.Hide();
        }
    }
}
