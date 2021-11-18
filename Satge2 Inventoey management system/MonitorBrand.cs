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
    public partial class MonitorBrand : Form
    {
        public MonitorBrand()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HpMonitor home3 = new HpMonitor();
            home3.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AppleMonitor home3 = new AppleMonitor();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AcerMonitor home3 = new AcerMonitor();
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
