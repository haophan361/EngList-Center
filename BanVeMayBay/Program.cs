using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HanhKhach hk1= new HanhKhach();
            hk1.NhapThongTinHanhKhach();
            hk1.InThongTinHanhKhach();
            Console.WriteLine("Tong so tien ve khach mua " + hk1.TinhTongGiaVe());
        }
    }
}