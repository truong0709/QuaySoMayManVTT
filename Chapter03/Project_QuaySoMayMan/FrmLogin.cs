using Project_QuaySoMayMan.Model.DAO;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
          
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtusername.Text))
            //{
            //    lbthongbao.Text = "no empty";
            //}
            //else if (string.IsNullOrEmpty(txtpass.Text))
            //{
            //    lbthongbao.Text = "no empty";
            //}
            if(txtusername.Text == "truong" && txtpass.Text == "123")
            {
                MessageBox.Show("You are now logged in!");
            }
            else if(txtusername.Text ==  "" || txtpass.Text == "")
            {
                MessageBox.Show("Please give Username & Password to proceed!");
            }
                   
            else 
            {
                    FrmQuaySoMayMan fQuaySoMayMan = new FrmQuaySoMayMan();
                    this.Hide();
                    fQuaySoMayMan.ShowDialog();
                    this.Close();
                
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            Form_DangKy f = new Form_DangKy();
            f.Show();
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if(txtusername.Text =="Username")
            {
                txtusername.Text = "";
                txtusername.ForeColor = Color.White;
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text == "")
            {
                txtusername.Text = "Username";
                txtusername.ForeColor = Color.Silver;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.White;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.White;
            }
        }
    }
}
