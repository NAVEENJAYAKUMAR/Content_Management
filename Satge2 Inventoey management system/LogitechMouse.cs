using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Satge2_Inventoey_management_system
{
    public partial class LogitechMouse : Form
    {
        public LogitechMouse()
        {
            InitializeComponent();
           
            
        }
        SqlConnection Con = Newinventory.NewInventory;
        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl  ";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        void Orderproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                Con.Close();

            }
            catch
            {

            }
        }
        void updateproducts()
        {

            int id = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
                MessageBox.Show(" Sorry,Operation Faild");
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProductQty=" + newQty + "where ProductId=" + id + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
        }

        int num = 0;
        int uprice, qty, totprice;
        string product;
        int stock;

        private void button1_Click(object sender, EventArgs e)
        {
            updateproducts();
            if (QtyTb.Text == "")
                MessageBox.Show("Enter The Quantity of Products");
            else if (flag == 0)
                MessageBox.Show("Select The Product");
            else if (Convert.ToInt32(QtyTb.Text) > stock)
                MessageBox.Show("No Enough Stock Available");
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                OrderGv.Rows.Add(num, product, qty, uprice, totprice);
                flag = 0;

            }
            sum = sum + totprice;
            TotAmount.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 co = new Form2(OrderGv.SelectedRows[0].Cells[0].Value.ToString(),
                OrderGv.SelectedRows[0].Cells[1].Value.ToString(),
                OrderGv.SelectedRows[0].Cells[2].Value.ToString(),
                OrderGv.SelectedRows[0].Cells[3].Value.ToString(),
                OrderGv.SelectedRows[0].Cells[4].Value.ToString());
            co.Show();
        }
        int flag = 0;

        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ProductName.Text = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            Processor.Text = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            ProductPrice.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
            product = ProductsGV.SelectedRows[0].Cells[2].Value.ToString();
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[4].Value.ToString());
            flag = 1;
        }

        private void LogitechMouse_Load(object sender, EventArgs e)
        {
            populateproducts();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Mousebrand home3 = new Mousebrand();
            home3.Show();
            this.Hide();
        }

        int sum = 0;
        private void button2_Click(object sender, EventArgs e)
        {

            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from UserTbl where Username='" + UsernameTb.Text + "' and Password='" + PasswordTb.Text + "'", Con);
            DataTable dt = new DataTable();
            
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if ( UsernameTb.Text == "" || PasswordTb.Text == "" || TotAmount.Text == "")
                {
                    MessageBox.Show("enter the Order Number");
                }
                else
                {




                    SqlCommand cmd = new SqlCommand("insert into Order1Tbl values('" + OrderIdTb.Text + "','" + UsernameTb.Text + "','" + PasswordTb.Text + "','" + TotAmount.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Sucessfully Added");

                    Orderproducts();
                    try
                    {

                    }

                    catch
                    {

                    }

                }
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }

            Con.Close();


        }

    }



    }

