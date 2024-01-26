using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class CongViec
    {
        private string idCongViec;
        private string nameCongViec;
        private string idLoaiCongViec;
        private LoaiCongViec LoaiCongViec;
        public CongViec(string idCongViec, string nameCongViec, string idLoaiCongViec)
        {
            this.idCongViec = idCongViec;
            this.nameCongViec = nameCongViec;
            this.idLoaiCongViec = idLoaiCongViec;
        }
        public string IdCongViec
        {
            get { return this.idCongViec;}
            set {  this.idCongViec = value;}
        }
        public string NameCongViec
        {
            get { return nameCongViec; }
            set { nameCongViec = value; }
        }
        public string IdLoaiCongViec
        {
            get { return idLoaiCongViec; }
            set { idLoaiCongViec = value; }
        }
        public LoaiCongViec loaiCongViec
        {
            get { return this.LoaiCongViec; }
            set { LoaiCongViec = value; }
        }
    }
}
