using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class PhieuThu
    {
        private string idPhieuThu;
        private DateTime ngaythangnam;
        private double soTienthu;
        private string idHoaDon;
        private HoaDon hoaDon;
        public PhieuThu(string idPhieuThu, DateTime ngaythangnam, double soTienthu, string idHoaDon)
        {
            this.idPhieuThu = idPhieuThu;
            this.ngaythangnam = ngaythangnam;
            this.soTienthu = soTienthu;
            this.idHoaDon = idHoaDon;
        }
        public string IdPhieuThu
        {
            get { return idPhieuThu; }
            set { idPhieuThu=value; }
        }
        public DateTime NgayThangNam
        {
            get { return ngaythangnam; }
            set { ngaythangnam = value; }
        }
        public double SoTienthu
        {
            get { return soTienthu; }
            set { soTienthu = value; }
        }
        public string IdHoaDon
        {
            get { return idHoaDon;}
            set { idHoaDon=value; }
        }
        public HoaDon HoaDon
        { 
            get { return hoaDon; }
            set { hoaDon=value; } 
        }
    }
}
