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
    public partial class PcBrand : Form
    {
        public PcBrand()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ApplePc home3 = new ApplePc();
            home3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HpPc home3 = new HpPc();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Categoryhome home3 = new Categoryhome();
            home3.Show();
            this.Hide();
        }
    }
}
