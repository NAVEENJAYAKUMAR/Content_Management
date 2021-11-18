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
    public partial class Mousebrand : Form
    {
        public Mousebrand()
        {
            InitializeComponent();
        }

        private void Mousebrand_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Categoryhome home3 = new Categoryhome();
            home3.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LogitechMouse home3 = new LogitechMouse();
            home3.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Roccat home3 = new Roccat();
            home3.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Razermouse home3 = new Razermouse();
            home3.Show();
            this.Hide();
        }
    }
}
