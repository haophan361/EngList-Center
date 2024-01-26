using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public enum GenderNV    
    {
        Nam,Nữ,Khác
    }
    public class NhanVien
    {
        private string idNhanVien;
        private string nameNhanVien;
        private string sodienthoai;
        private GenderNV gender;
        private string diaChi;
        private string idNhomNhanVien;
        private NhomNhanVien nhomNhanVien;
        public NhanVien(string idNhanVien, string nameNhanVien, string sodienthoai, GenderNV gender, string diaChi, string idNhomNhanVien)
        {
            this.idNhanVien = idNhanVien;
            this.nameNhanVien = nameNhanVien;
            this.sodienthoai = sodienthoai;
            this.gender = gender;
            this.diaChi = diaChi;
            this.idNhomNhanVien = idNhomNhanVien;
        }
        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }
        public string NameNhanVien
        {
            get { return nameNhanVien; }
            set { nameNhanVien = value; }
        }
        public string Sodienthoai
        {
            get { return sodienthoai;}
            set { sodienthoai = value;}
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public GenderNV Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string IdNhomNhanVien
        {
            get { return idNhomNhanVien; }
            set { idNhomNhanVien = value;}
        }
        public NhomNhanVien NhomNhanVien
        {
            get { return nhomNhanVien; }
            set { nhomNhanVien = value; }
        }
    }
}
