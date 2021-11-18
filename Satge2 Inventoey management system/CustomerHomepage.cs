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
    public partial class CustomerHomepage : Form
    {
        public CustomerHomepage()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        { 
            if(imageNumber==4)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"images\{0}.JPG", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sign_in home = new sign_in();
            home.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categoryhome home = new Categoryhome();
            home.Show();
            this.Hide();
        }

        private void CustomerHomepage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YourOrders home = new YourOrders();
            home.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customer3 home = new customer3();
            home.Show();
            this.Hide();

        }
    }
}
