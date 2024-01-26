using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class NhomNhanVien
    {
        private string idNhomNhanVien;
        private string nameNhomNhanVien;
        private int soNhanVien;
        private string idTruongNhom;
        private string idChiNhanh;
        private ChiNhanh ChiNhanh;
        List<NhanVien> nhanVienList;
        public NhomNhanVien(string idNhomNhanVien, string nameNhomNhanVien,string idChiNhanh)
        {
            this.idNhomNhanVien = idNhomNhanVien;
            this.nameNhomNhanVien = nameNhomNhanVien;
            this.idChiNhanh = idChiNhanh;
        }
        public string IdNhomNhanVien
        {
            get { return idNhomNhanVien; }
            set {  idNhomNhanVien = value;}
        }
        public string NameNhomNhanVien
        {
            get { return nameNhomNhanVien; }
            set { nameNhomNhanVien = value; }
        }
        public int SoNhanVien
        {
            get { return soNhanVien; }
            set { soNhanVien = value; }
        }
        public string IdTruongNhom
        {
            get { return idTruongNhom; }
            set { idTruongNhom = value; }
        }
        public List<NhanVien> NhanVienList
        {
            get { return nhanVienList; }
            set { nhanVienList = value; }
        }
        public string IdChiNhhanh
        {
            get { return idChiNhanh; }
            set { idChiNhanh = value; }
        }
        public ChiNhanh chiNhanh
        {
            get { return chiNhanh; }
            set { chiNhanh = value; }
        }
    }
}
