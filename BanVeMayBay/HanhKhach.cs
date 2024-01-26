using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    public class HanhKhach
    {
        private string maHanhKhach;
        private string hoTen;
        private string diaChi;
        private int soVeKhachMua;
        private VeMayBay[] thongtinvemaybay;
        public HanhKhach() { }
        public HanhKhach(string maHanhKhach,string hoTen,string diaChi,int soVeKhachMua)
        {
            this.maHanhKhach = maHanhKhach;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.soVeKhachMua = soVeKhachMua;
            VeMayBay[] thongtinvemaybay = new VeMayBay[soVeKhachMua];
            for(int i=0;i<soVeKhachMua;i++)
            {
                thongtinvemaybay[i] = new VeMayBay();
                thongtinvemaybay[i].NhapThongTinVeMayBay();
            }
        }
        public void NhapThongTinHanhKhach()
        {
            Console.Write("Nhap ma hanh khach ");
            this.maHanhKhach = Console.ReadLine();
            Console.Write("Nhap ho ten hanh khach ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap dia chi ");
            this.diaChi = Console.ReadLine();
            Console.Write("So ve may bay khach mua ");
            this.soVeKhachMua=Convert.ToInt32(Console.ReadLine());
            this.thongtinvemaybay = new VeMayBay[this.soVeKhachMua];
            for (int i = 0; i < soVeKhachMua; i++)
            {
                this.thongtinvemaybay[i] = new VeMayBay();
                this.thongtinvemaybay[i].NhapThongTinVeMayBay();
            }
        }
        public double TinhTongGiaVe()
        {
            double sum = 0;
            for(int i=0;i<soVeKhachMua;i++)
            {
                sum += thongtinvemaybay[i].TinhGiaVe();
            }
            return sum;
        }
        public void InThongTinHanhKhach()
        {
            Console.WriteLine("Ma hanh khach " + maHanhKhach);
            Console.WriteLine("Ho ten hanh khach " + hoTen);
            Console.WriteLine("Dia chi " + diaChi);
            Console.WriteLine("So ve khach mua " + soVeKhachMua);
            for (int i = 0; i < soVeKhachMua; i++)
            {
                thongtinvemaybay[i].InThongTinVe();
                Console.WriteLine();
            }
        }
    }

}
