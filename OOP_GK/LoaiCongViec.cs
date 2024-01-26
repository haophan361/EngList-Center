using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class LoaiCongViec
    {
        private string idLoaiCongViec;
        private string nameLoaiCongViec;
        private List<CongViec> congviecList;
        public LoaiCongViec(string idLoaiCongViec, string nameLoaiCongViec)
        {
            this.idLoaiCongViec = idLoaiCongViec;
            this.nameLoaiCongViec = nameLoaiCongViec;
        }
        public string IdLoaiCongViec
        {
            get { return this.idLoaiCongViec; }
            set { idLoaiCongViec = value; }
        }
        public string NameLoaiCongViec
        {
            get { return nameLoaiCongViec; }
            set { nameLoaiCongViec = value; }
        }
        public List<CongViec> CongViecList
        {
            get { return congviecList; }
            set { congviecList = value; }
        }
    }
}
