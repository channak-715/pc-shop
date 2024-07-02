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
using pc_shop.Singleton;

namespace pc_shop
{
    public partial class FormLogin : Form
    {
        SqlConnection _conn;
        SqlCommand cmd;

        public FormLogin()
        {
            InitializeComponent();
            connect();

        }

        private void connect()
        {
            try
            {
               Connector connector = Connector.GetConnector();
                if (connector != null)
                {
                    _conn = connector.Connection();
                    _conn.Open();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        /*SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LNQF7KP;Initial Catalog=PCShopManagementSystem;Integrated Security=True"); */


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclose_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
           
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            String username, password;

            username = txtUser.Text;
            password = txtPass.Text;

            try
            {
                String querry = "SELECT * FROM tbl_login WHERE username = '" + txtUser.Text + "' AND password = '" + txtPass.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(querry, _conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = txtUser.Text;
                    password = txtPass.Text;

                    //page next

                    dashboard dashboard = new dashboard();
                    dashboard.Show();
                    this.Hide();




                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtPass.Clear();
                    txtUser.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                _conn.Close();
            }

        }
    }
}
