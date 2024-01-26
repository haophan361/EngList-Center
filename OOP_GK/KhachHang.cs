using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class KhachHang
    {
        private string idKhachHang;
        private string nameKhachHang;
        private string diaChi;
        private string sodienthoai;
        public KhachHang(string idKhachHang, string nameKhachHang, string diaChi, string sodienthoai)
        {
            this.idKhachHang = idKhachHang;
            this.nameKhachHang = nameKhachHang;
            this.diaChi = diaChi;
            this.sodienthoai = sodienthoai;
        }
        public string IdKhachHang
        {
            get { return idKhachHang; }
            set { idKhachHang = value; }
        }
        public string NameKhachHang
        {
            get { return nameKhachHang; }
            set { nameKhachHang = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string Sodienthoai
        {
            get { return sodienthoai; } 
            set {  sodienthoai = value; } 
        }
    }
}
