using pc_shop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace pc_shop
{
    public partial class employee : menus
    {
        private readonly Login login;
        private readonly SqlConnection _conn;
        private SqlCommand cmd; 
        public employee()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using(OpenFileDialog openfile = new OpenFileDialog()
                {
                    Filter = "Image Files |*.jpg;*.jpeg;*.png;...",
                    Multiselect = false,
            })
              {
                if(openfile.ShowDialog() == DialogResult.OK)
                    {

                        pictureBox1.Image = Image.FromFile(openfile.FileName);
                    }    
              }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        private void insertStaff()
        {
            Employee employee = new staff(txtID,txtname,txtemail,txtpass,txtphone,Convertimage.ConvertImageToBytes(pictureBox1.Image));
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = _conn;
                cmd.CommandText = "tbl_employer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = employee.Id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.Name;
                cmd.Parameters.Add("@position", SqlDbType.NVarChar).Value = employee.Position;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = employee.Email;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = employee.Password;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = employee.phone;
                cmd.Parameters.Add("@image", SqlDbType.VarBinary).Value = employee.img;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
