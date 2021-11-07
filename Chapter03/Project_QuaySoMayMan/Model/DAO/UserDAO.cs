using Microsoft.Office.Interop.Excel;
using Project_QuaySoMayMan.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QuaySoMayMan.Model.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }
        private UserDAO() { }

        public List<User> Listuser;
        public void GetUser()
        {
            string[] userArray = string.Empty.Split(',');

            User user = new User();
            user.ID = Convert.ToInt32(userArray[0]);
            user.HoTen = userArray[1];
            user.TenDangNhap = userArray[2].ToString();
            user.MatKhau = userArray[3];
            user.PhongBan = userArray[4];
            user.Remember = Convert.ToBoolean(userArray[5].ToString());

            //Thêm User vào danh sách listUser
            Listuser.Add(user);
        }
        public bool Kiemtradangnhap(string tenDangNhap, string matKhau)
        {
            foreach (User item in Listuser)
            {
                if (item.TenDangNhap.Equals(tenDangNhap) && item.MatKhau.Equals(matKhau))
                {
                    //item.Remember = chkbRemember.Checked;
                    //Cls_Main._staticUser = item;
                    return true;
                }

            }
            return false;

        }
    }
}
