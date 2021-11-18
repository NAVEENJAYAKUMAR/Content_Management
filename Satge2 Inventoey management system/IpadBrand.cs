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
    public partial class IpadBrand : Form
    {
        public IpadBrand()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AppleIpad home3 = new AppleIpad();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SamsungIpad home3 = new SamsungIpad();
            home3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GoogleIpad home3 = new GoogleIpad();
            home3.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Categoryhome home3 = new Categoryhome();
            home3.Show();
            this.Hide();
        }

        private void IpadBrand_Load(object sender, EventArgs e)
        {

        }
    }
}
