using CheckBoxList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1T4
{
    public abstract class Sach
    {
        private string loaisach;
        private int namXuatBan;
        private int SoTrang;
        private TacGia tacGia;
        private string tenBiaSach;
        public Sach(string loaisach, int namXuatBan, int soTrang, TacGia tacGia, string tenBiaSach)
        {
            this.loaisach = loaisach;
            this.namXuatBan = namXuatBan;
            SoTrang = soTrang;
            this.tacGia = tacGia;
            this.tenBiaSach = tenBiaSach;
        }
        public void InThongTinSach()
        {
            Console.WriteLine("Loai sach " + loaisach);
            Console.WriteLine("Nam xuat ban " + namXuatBan);
            Console.WriteLine("So trang " + SoTrang);
            Console.WriteLine("Ten bia sach " + tenBiaSach);
            tacGia.InThongTinTG();
        }
    }
}
