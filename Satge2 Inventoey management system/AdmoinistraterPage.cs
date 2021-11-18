using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satge2_Inventoey_management_system
{
    public partial class AdmoinistraterPage : Form
    {
        public AdmoinistraterPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Category home1 = new Category();
            home1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            User1 home2 = new User1();
            home2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            stocklevel home3 = new stocklevel();
            home3.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            sign_in home3 = new sign_in();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AdmoinistraterPage_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            customer home3 = new customer();
            home3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YourOrders home = new YourOrders();
            home.Show();
            this.Hide();
        }
    }
}
