using Project_QuaySoMayMan.Model.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_QuaySoMayMan
{
    public partial class Form_DangKy : Form
    {
        public Form_DangKy()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangKyTK_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string username = txtName.Text;
            string pass = txtpass.Text;

            if (string.IsNullOrEmpty(username))
            {
                lbnote.Text = "Không được để trống";
            }
            else if (string.IsNullOrEmpty(pass))
            {
                lbnote.Text = "Không được để trống";
            }
            else
            {
                User user = new User();
                user.ID = int.Parse(id);
                user.HoTen = name.ToString();
                user.TenDangNhap = username.ToString();
                user.MatKhau = pass.ToString();

                List<User> listuser = new List<User>();
                listuser.Add(user);

                lbnote.Text = "Success";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
