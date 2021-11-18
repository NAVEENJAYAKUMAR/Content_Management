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
    public partial class User1 : Form
    {
        public User1()
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
        private void User1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User home = new User();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdmoinistraterPage home1 = new AdmoinistraterPage();
            home1.Show();
            this.Hide();
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
