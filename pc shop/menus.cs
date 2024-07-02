using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_shop
{
    public partial class menus : Form
      
    {
        
        
        public menus()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            product product = new product();
            product.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dashboard menu = new dashboard();
            menu.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            employee employee = new employee();
            employee.Show();
            this.Hide();
 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Close();            
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.Show();
            this.Hide();
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }
    }
}
