using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanVeMayBay
{
    public class VeMayBay
    {
        private int doDaiHanhTrinh;
        private static double mucGiaTran=1500000;
        private string soHieuChuyenBay;
        private string tenSanBayDen;
        private string tenSanBayDi;
        public VeMayBay()
        {

        }
        public VeMayBay(int doDaiHanhTrinh, string soHieuChuyenBay, string tenSanBayDen, string tenSanBayDi)
        {
            this.doDaiHanhTrinh = doDaiHanhTrinh;
            this.soHieuChuyenBay = soHieuChuyenBay;
            this.tenSanBayDen = tenSanBayDen;
            this.tenSanBayDi = tenSanBayDi;
        }

        public void NhapThongTinVeMayBay()
        {
            Console.Write("Nhap do dai hanh trinh ");
            this.doDaiHanhTrinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so hieu chuyen bay ");
            this.soHieuChuyenBay = Console.ReadLine();
            Console.Write("Nhap ten san bay di ");
            this.tenSanBayDi = Console.ReadLine();
            Console.Write("Nhap ten san bay den ");
            this.tenSanBayDen = Console.ReadLine();
        }
        public double TinhGiaVe()
        {
            if(doDaiHanhTrinh>1200)
            {
                return mucGiaTran * 1.5;
            }
            else if(doDaiHanhTrinh>500 && doDaiHanhTrinh<=1200)
            {
                return mucGiaTran * 1.2;
            }
            else
            {
                return mucGiaTran;
            }
        }
        public void InThongTinVe()
        {
            Console.WriteLine("Do dai hanh trinh " + doDaiHanhTrinh);
            Console.WriteLine("So hieu chuyen bay " + soHieuChuyenBay);
            Console.WriteLine("Ten san bay di " + tenSanBayDi);
            Console.WriteLine("Ten san bay den " + tenSanBayDen);
        }
    }
}
