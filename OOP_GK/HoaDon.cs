using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class HoaDon
    {
        private string idHoaDon;
        private double giaTien;
        private DateTime ngaythangnam;
        private string idThuCung;
        private string idChiNhanh;
        private ThuCung thuCung;
        private ChiNhanh chiNhanh;
        public HoaDon(string idHoaDon, double giaTien, DateTime ngaythangnam, string idThuCung, string idChiNhanh)
        {
            this.idHoaDon = idHoaDon;
            this.giaTien = giaTien;
            this.ngaythangnam = ngaythangnam;
            this.idThuCung = idThuCung;
            this.idChiNhanh = idChiNhanh;
        }
        public string IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }
        public double GiaTien
        {
            get { return giaTien;}
            set { giaTien = value; }
        }
        public DateTime Ngaythangnam
        {
            get { return ngaythangnam; }
            set { ngaythangnam = value; }
        }
        public string IdThuCung
        {
            get { return idThuCung; }
            set { idThuCung = value; }
        }
        public ThuCung thucung
        {
            get { return thuCung; }
            set { thuCung = value; }
        }
        public string IdChiNhanh
        {
            get { return idChiNhanh; }
            set { idChiNhanh = value; }
        }
        public ChiNhanh chinhanh
        {
            get { return chiNhanh; }
            set { chiNhanh = value; }
        }
    }
}
