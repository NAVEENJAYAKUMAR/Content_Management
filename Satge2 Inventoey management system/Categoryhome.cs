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
    public partial class Categoryhome : Form
    {
        public Categoryhome()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LaptopBrand home3 = new LaptopBrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mobilebrand home3 = new Mobilebrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            keyboardBrand home3 = new keyboardBrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            speakersbrand home3 = new speakersbrand();
            home3.Show();
            this.Hide();
        }

        private void Categoryhome_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Mousebrand home3 = new Mousebrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MonitorBrand home3 = new MonitorBrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            IpadBrand home3 = new IpadBrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PcBrand home3 = new PcBrand();
            home3.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            CustomerHomepage home3 = new CustomerHomepage();
            home3.Show();
            this.Hide();
        }
    }
}
