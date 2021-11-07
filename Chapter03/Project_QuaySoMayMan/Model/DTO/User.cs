using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_QuaySoMayMan.Model.DTO
{
    public class User
    {
        int iD;
        string hoTen;
        string tenDangNhap;
        string matKhau;
        string phongBan;
        bool remember;
        public User() { }
        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public bool Remember { get => remember; set => remember = value; }

        public User(int iD, string hoTen, string tenDangNhap, string matKhau, string phongBan, bool remember)
        {
            this.ID = iD;
            this.HoTen = hoTen;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.PhongBan = phongBan;
            this.Remember = remember;
        }

        public string GetString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5}", ID, HoTen, TenDangNhap
                , MatKhau, PhongBan, Remember.ToString());
        }
    }
}
