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
    public partial class keyboardBrand : Form
    {
        public keyboardBrand()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            logitech home3 = new logitech();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Razer home3 = new Razer();
            home3.Show();
            this.Hide();
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Microsoft home3 = new Microsoft();
            home3.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           Categoryhome home3 = new Categoryhome();
            home3.Show();
            this.Hide();
        }
    }
}
