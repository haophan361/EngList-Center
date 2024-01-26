using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public enum Gender
    {
        Đực, Cái
    }
    public class ThuCung
    {

        private string idThuCung;
        private string nameThuCung;
        private string loaiThuCung;
        private Gender gender;
        private string idKhachHang;
        private KhachHang khachHang;
        public ThuCung(string idThuCung, string nameThuCung, string loaiThuCung, Gender gender, string idKhachHang)
        {
            this.idThuCung = idThuCung;
            this.nameThuCung= nameThuCung;
            this.loaiThuCung = loaiThuCung;
            this.gender = gender;
            this.idKhachHang = idKhachHang;
        }
        public string IdThuCung
        {
            get { return idThuCung; }
            set { idThuCung = value; }
        }
        public string NameThuCung
        {
            get { return nameThuCung; }
            set { nameThuCung = value; }
        }
        public string LoaiThuCung
        {
            get { return loaiThuCung; }
            set { loaiThuCung = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string IdKhachHang
        {
            get { return idKhachHang; }
            set { idKhachHang = value; }
        }
        public KhachHang KhachHang
        {
            get { return khachHang; }
            set { khachHang = value; }
        }
    }
}

