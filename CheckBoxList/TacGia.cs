using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxList
{
    public class TacGia
    {
        private string hoTenTacGia;
        private string maTacGia;
        public TacGia(string hoTenTacGia, string maTacGia)
        {
            this.maTacGia = maTacGia;
            this.hoTenTacGia = hoTenTacGia;
        }
        public void InThongTinTG()
        {
            Console.WriteLine("Ma tac gia " + maTacGia);
            Console.WriteLine("Ten tac gia " + hoTenTacGia);
        }
    }
}
