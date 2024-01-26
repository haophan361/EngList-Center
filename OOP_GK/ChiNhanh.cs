using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class ChiNhanh
    {
        private string idChiNhanh;
        private string nameChiNhanh;
        private string diaChi;
        List<NhomNhanVien> nhomnhanvienlist;
        private string idTruongChiNhanh;
        public ChiNhanh(string idChiNhanh, string nameChiNhanh, string diaChi)
        {
            this.idChiNhanh = idChiNhanh;
            this.nameChiNhanh = nameChiNhanh;
            this.diaChi = diaChi;
        }
        public string IdChiNhanh
        {
            get { return idChiNhanh; }
            set { idChiNhanh = value; }
        }
        public string NameChiNhanh
        {
            get { return nameChiNhanh; }
            set { nameChiNhanh = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public List<NhomNhanVien> nhomnhanvienList
        {
            get { return nhomnhanvienlist; }
            set { nhomnhanvienlist = value; }
        }
        public string IdTruongChiNhanh
        {
            get { return idTruongChiNhanh; }
            set { idTruongChiNhanh = value; }
        }
    }
}
