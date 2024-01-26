using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class ChiTietHoaDon
    {
        private string idHoaDon;
        private string idCongViec;
        private string idNhanVien;
        private double tiencongNhanVien;
        public ChiTietHoaDon(string idHoaDon, string idCongViec, string idNhanVien, double tiencongNhanVien)
        {
            this.idHoaDon = idHoaDon;
            this.idCongViec = idCongViec;
            this.idNhanVien = idNhanVien;
            this.tiencongNhanVien = tiencongNhanVien;
        }
        public string IdHoaDon
        {
            get { return idHoaDon; }
            set { idHoaDon = value; }
        }
        public string IdCongViec
        {
            get { return idCongViec; }
            set { idCongViec = value; }
        }
        public string IdNhanVien
        {
            get { return idNhanVien; }
            set { idNhanVien = value; }
        }
        public double Tiencongnhanvien
        {
            get { return tiencongNhanVien; }
            set { tiencongNhanVien = value; }
        }
    }
}
