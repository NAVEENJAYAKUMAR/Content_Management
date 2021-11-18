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
    public partial class Form2 : Form
    {
        public Form2(string number, string product, string quantity, string uprice, string totamount)
        {
            InitializeComponent();
            Gv.Rows.Add();
            Gv.Rows[0].Cells[0].Value = number;
            Gv.Rows[0].Cells[1].Value = product;
            Gv.Rows[0].Cells[2].Value = quantity;
            Gv.Rows[0].Cells[3].Value = uprice;
            Gv.Rows[0].Cells[4].Value = totamount;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
