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
    public partial class customer : Form
    {
        public customer()
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
        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void customer_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customer3 home = new customer3();
            home.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdmoinistraterPage home = new AdmoinistraterPage();
            home.Show();
            this.Hide();
        }
    }
}
