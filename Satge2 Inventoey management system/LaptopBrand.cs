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
    public partial class LaptopBrand : Form
    {
        public LaptopBrand()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 home1 = new Form1();
            home1.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Apple home2 = new Apple();
            home2.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Acer home3 = new Acer();
            home3.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MSI home4 = new MSI();
            home4.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Categoryhome home7= new Categoryhome();
            home7.Show();
            this.Hide();
        }
    }
}
