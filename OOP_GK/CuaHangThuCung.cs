using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GK
{
    public class CuaHangThuCung
    {
        public static List<KhachHang> dskhachhang;
        public static List<ThuCung> dsthucung;
        public static List<ChiNhanh> dschinhanh;
        public static List<NhomNhanVien> dsnhomnhanvien;
        public static List<NhanVien> dsnhanvien;
        public static List<LoaiCongViec> dsloaicongviec;
        public static List<CongViec> dscongviec;
        public static List<HoaDon> dshoadon;
        public static List<ChiTietHoaDon> dschitiethoadon;
        public static List<PhieuThu> dsphieuthu;
        public static void Main(string[] args)
        {
            dskhachhang = new List<KhachHang>();
            taodanhsachKhachHang();

            dsthucung = new List<ThuCung>();
            taodanhsachThuCung();

            dschinhanh = new List<ChiNhanh>();
            taodanhsachChiNhanh();

            dsnhomnhanvien = new List<NhomNhanVien>();
            taodanhsachNhomNhanVien();

            dsnhanvien = new List<NhanVien>();
            taodanhsachNhanVien();

            dsnhomnhanvien[0].IdTruongNhom = ("NV01");
            dsnhomnhanvien[1].IdTruongNhom = ("NV07");
            dsnhomnhanvien[2].IdTruongNhom = ("NV09");
            dsnhomnhanvien[3].IdTruongNhom = ("NV13");
            dsnhomnhanvien[4].IdTruongNhom = ("NV16");
            dsnhomnhanvien[5].IdTruongNhom = ("NV20");

            dschinhanh[0].IdTruongChiNhanh = dsnhomnhanvien[1].IdTruongNhom;
            dschinhanh[1].IdTruongChiNhanh = dsnhomnhanvien[5].IdTruongNhom;

            dsloaicongviec = new List<LoaiCongViec>();
            taodanhsachLoaiCongViec();

            dscongviec = new List<CongViec>();
            taodanhsachCongViec();

            dshoadon = new List<HoaDon>();
            taodanhsachHoaDon();

            dschitiethoadon = new List<ChiTietHoaDon>();
            taodanhsachChiTietHoaDon();

            dsphieuthu = new List<PhieuThu>();
            taodanhsachPhieuThu();

            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("-----Câu 1------");
            Cau1();
            Console.WriteLine();
            Console.WriteLine("-----Câu 2------");
            Cau2();
            Console.WriteLine();
            Console.WriteLine("-----Câu 3------");
            Cau3();
            Console.WriteLine();
            Console.WriteLine("-----Câu 4------");
            Cau4();
            Console.WriteLine();
            Console.WriteLine("-----Câu 5------");
            Cau5();
            Console.WriteLine();
            Console.WriteLine("-----Câu 6------");
            Cau6();
            Console.WriteLine();
            Console.WriteLine("-----Câu 7------");
            Cau7();
            Console.WriteLine();
            Console.WriteLine("-----Câu 8------");
            Cau8();
            Console.WriteLine();
            Console.WriteLine("-----Câu 9------");
            Cau9();
            Console.WriteLine();
            Console.WriteLine("-----Câu 10------");
            Cau10();
            Console.WriteLine();
            Console.WriteLine("-----Câu 11------");
            Cau11();
            Console.WriteLine();
        }
        public static void taodanhsachKhachHang()
        {
            dskhachhang.Add(new KhachHang("KH01", "Huỳnh Trung Sơn", "Đà Lạt", "089xxxxxxx"));
            dskhachhang.Add(new KhachHang("KH02", "Nguyễn Hữu Lượng", "Long An", "036xxxxxxx"));
            dskhachhang.Add(new KhachHang("KH03", "Phạm Ngọc Anh Hào", "Đồng Tháp", "037xxxxxxx"));
            dskhachhang.Add(new KhachHang("KH04", "Nguyễn Thành Lâm", "Bình Dương", "087xxxxxxx"));
            dskhachhang.Add(new KhachHang("KH05", "Phan Phúc Hảo", "Long An", "085xxxxxxx"));
        }
        public static void taodanhsachThuCung()
        {
            dsthucung.Add(new ThuCung("TC01", "Chuki", "Chó", Gender.Cái, "KH02"));
            dsthucung.Add(new ThuCung("TC02", "Chó", "Mèo", Gender.Cái, "KH04"));
            dsthucung.Add(new ThuCung("TC03", "Dịt", "Vịt", Gender.Cái, "KH04"));
            dsthucung.Add(new ThuCung("TC04", "Mia", "Mèo", Gender.Cái, "KH01"));
            dsthucung.Add(new ThuCung("TC05", "Boiz", "Mèo", Gender.Đực, "KH02"));
            dsthucung.Add(new ThuCung("TC06", "Bun", "Chó", Gender.Đực, "KH02"));
            dsthucung.Add(new ThuCung("TC07", "Java", "Mèo", Gender.Đực, "KH05"));
            dsthucung.Add(new ThuCung("TC08", "Mỹ Diệu","Mèo", Gender.Cái, "KH01"));
            dsthucung.Add(new ThuCung("TC09", "Lu", "Chó", Gender.Đực, "KH03"));
            dsthucung.Add(new ThuCung("TC10", "Python", "Vẹt", Gender.Cái, "KH05"));
        }
        public static void taodanhsachChiNhanh()
        {
            dschinhanh.Add(new ChiNhanh("CN01", "Thú Cưng Méo Méo cơ sở chính", "Thủ đức"));
            dschinhanh.Add(new ChiNhanh("CN02", "Thú Cưng Méo Méo cơ sở 1", "Quận 5"));
        }
        public static void taodanhsachNhomNhanVien()
        {
            dsnhomnhanvien.Add(new NhomNhanVien("N01", "Nhóm chăm sóc sức khỏe thú cưng cơ sở chính", "CN01"));
            dsnhomnhanvien.Add(new NhomNhanVien("N02", "Nhóm dịch vụ thú cưng cơ sở chính", "CN01"));
            dsnhomnhanvien.Add(new NhomNhanVien("N03", "Nhóm bán hàng cơ sở chính", "CN01"));

            dsnhomnhanvien.Add(new NhomNhanVien("N04", "Nhóm chăm sóc sức khỏe thú cưng cơ sở CS1", "CN02"));
            dsnhomnhanvien.Add(new NhomNhanVien("N05", "Nhóm dịch vụ thú cưng CS1","CN02"));
            dsnhomnhanvien.Add(new NhomNhanVien("N06", "Nhóm bán hàng CS1", "CN02"));
        }
        public static void taodanhsachNhanVien()
        {
            dsnhanvien.Add(new NhanVien("NV01", "Nguyễn Văn A", "036xxxxxxx", GenderNV.Nam, "Linh Trung", "N01"));
            dsnhanvien.Add(new NhanVien("NV02", "Trần Thị B", "052xxxxxxx", GenderNV.Nữ, "Dĩ An", "N01"));
            dsnhanvien.Add(new NhanVien("NV03", "Lê Hồng C", "089xxxxxxx", GenderNV.Nữ, "Bình Dương", "N01"));
            dsnhanvien.Add(new NhanVien("NV04", "Phạm Minh D", "086xxxxxxx", GenderNV.Nam, "Bình Thạnh", "N01"));
            dsnhanvien.Add(new NhanVien("NV05", "Hoàng Thị E", "036xxxxxxx", GenderNV.Nữ, "Quận 1", "N02"));
            dsnhanvien.Add(new NhanVien("NV06", "Vũ Nam F", "012xxxxxx", GenderNV.Khác, "Quận 5", "N02"));
            dsnhanvien.Add(new NhanVien("NV07", "Phan Phúc H", "039xxxxxxx", GenderNV.Nữ, "Quận 10", "N02"));
            dsnhanvien.Add(new NhanVien("NV08", "Đặng Hải G", "087xxxxxxx", GenderNV.Nam, "Quận 10", "N02"));
            dsnhanvien.Add(new NhanVien("NV09", "Ngô Mai K", "092xxxxxxx", GenderNV.Nữ, "Quận 8", "N03"));
            dsnhanvien.Add(new NhanVien("NV10", "Lý Khánh L", "012xxxxxxx", GenderNV.Nữ, "Quận 8", "N03"));
            dsnhanvien.Add(new NhanVien("NV11", "Đỗ Quang I", "034xxxxxxx", GenderNV.Nam, "Quận 6", "N03"));
            dsnhanvien.Add(new NhanVien("NV12", "Đinh Trung M", "065xxxxxxx", GenderNV.Nam, "Bình Tân", "N03"));
            dsnhanvien.Add(new NhanVien("NV13", "Trương Gia N", "033xxxxxxx", GenderNV.Nam, "Gò Vấp", "N04"));
            dsnhanvien.Add(new NhanVien("NV14", "Mai Thị O", "056xxxxxxx", GenderNV.Nữ, "Bình Thạnh", "N04"));
            dsnhanvien.Add(new NhanVien("NV15", "Hoàng Hữu P", "078xxxxxxx", GenderNV.Khác, "Bình Tân", "N04"));
            dsnhanvien.Add(new NhanVien("NV16", "Nguyễn Đăng Q", "069xxxxxxx", GenderNV.Nam, "Quận 7", "N05"));
            dsnhanvien.Add(new NhanVien("NV17", "Phăn Văn R", "052xxxxxxx", GenderNV.Nam, "Quận 6", "N05"));
            dsnhanvien.Add(new NhanVien("NV18", "Huỳnh Trung S", "023xxxxxxx", GenderNV.Nam, "Quận 12", "N05"));
            dsnhanvien.Add(new NhanVien("NV19", "Nguyễn Minh T", "046xxxxxxx", GenderNV.Nữ, "Gò Vấp", "N06"));
            dsnhanvien.Add(new NhanVien("NV20", "Nguyễn Thị Thảo U", "089xxxxxxx", GenderNV.Nữ, "Quận 5", "N06"));
            dsnhanvien.Add(new NhanVien("NV21", "Nguyễn Thị Thảo V", "062xxxxxxx", GenderNV.Nữ, "Quận 5", "N06")); 
        }
        public static void taodanhsachLoaiCongViec()
        {
            dsloaicongviec.Add(new LoaiCongViec("L01", "Khám sức khỏe"));
            dsloaicongviec.Add(new LoaiCongViec("L02", "Dịch vụ và giải trí"));
            dsloaicongviec.Add(new LoaiCongViec("L03", "Huấn luyện"));
            dsloaicongviec.Add(new LoaiCongViec("L04", "Bán và tư vấn"));
        }
        public static void taodanhsachCongViec()
        {
            dscongviec.Add(new CongViec("CV01", "Kiểm tra nội tiết", "L01"));
            dscongviec.Add(new CongViec("CV02", "Kiểm tra chất lượng phân tích máu", "L01"));
            dscongviec.Add(new CongViec("CV03", "Kiểm tra nội khoa và ngoại khoa", "L01"));
            dscongviec.Add(new CongViec("CV04", "Tiêm phòng", "L01"));
            dscongviec.Add(new CongViec("CV05", "Kiểm tra răng miệng", "L01"));
            dscongviec.Add(new CongViec("CV06", "Chơi với thú cưng", "L02"));
            dscongviec.Add(new CongViec("CV07", "Cho thú cưng ăn", "L02"));
            dscongviec.Add(new CongViec("CV08", "Dẫn thú cưng đi dạo", "L02"));
            dscongviec.Add(new CongViec("CV09", "Cắt tỉa tạo kiểu cho thú cưng", "L02"));
            dscongviec.Add(new CongViec("CV10", "Làm đẹp cho thú cưng", "L02"));
            dscongviec.Add(new CongViec("CV11", "Huấn luyện đi vệ sinh", "L03"));
            dscongviec.Add(new CongViec("CV12", "Huấn luyện cơ bản", "L03"));
            dscongviec.Add(new CongViec("CV13", "Huấn luyện nghe lệnh", "L03"));
            dscongviec.Add(new CongViec("CV14", "Huấn luyện agility", "L03"));
            dscongviec.Add(new CongViec("CV15", "Tư vấn sản phẩm và dịch vụ", "L04"));
            dscongviec.Add(new CongViec("CV16", "Bán thú cưng", "L04"));
            dscongviec.Add(new CongViec("CV17", "Bán thức ăn cho thú cưng", "L04"));
        }
        public static void taodanhsachHoaDon()
        {
            dshoadon.Add(new HoaDon("HD01", 600000, new DateTime(2021,5,17), "TC01", "CN02"));
            dshoadon.Add(new HoaDon("HD02", 150000, new DateTime(2021, 5, 23), "TC02", "CN01"));
            dshoadon.Add(new HoaDon("HD03", 1000000, new DateTime(2021, 5, 25), "TC05", "CN01"));
            dshoadon.Add(new HoaDon("HD04", 600000, new DateTime(2021, 5, 25), "TC06", "CN01"));
            dshoadon.Add(new HoaDon("HD05", 1200000, new DateTime(2021, 5, 30), "TC03", "CN02"));
            dshoadon.Add(new HoaDon("HD06", 650000, new DateTime(2021, 6, 6), "TC04", "CN02"));
            dshoadon.Add(new HoaDon("HD07", 500000, new DateTime(2021, 6, 18), "TC02", "CN01"));
            dshoadon.Add(new HoaDon("HD08", 200000, new DateTime(2021, 6, 25), "TC05", "CN01"));
            dshoadon.Add(new HoaDon("HD09", 300000, new DateTime(2021, 6, 25), "TC01", "CN02"));
            dshoadon.Add(new HoaDon("HD10", 550000, new DateTime(2021, 6, 30), "TC09", "CN01"));
            dshoadon.Add(new HoaDon("HD11", 750000, new DateTime(2021, 7, 10), "TC10", "CN01"));
        }
        public static void taodanhsachChiTietHoaDon()
        {
            dschitiethoadon.Add(new ChiTietHoaDon("HD01", "CV15", "NV11", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD01", "CV16", "NV07", 200000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD01", "CV17", "NV11", 10000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD02", "CV17", "NV21", 30000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD03", "CV09", "NV06", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD03", "CV10", "NV05", 30000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD03", "CV02", "NV01", 60000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD03", "CV03", "NV02", 75000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD03", "CV17", "NV10", 12000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD04", "CV13", "NV09", 50000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD04", "CV14", "NV12", 100000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD04", "CV17", "NV11", 40000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV06", "NV16", 10000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV07", "NV17", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV08", "NV18", 10000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV09", "NV18", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV10", "NV17", 30000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV17", "NV20", 5000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD05", "CV18", "NV20", 100000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD06", "CV01", "NV14", 25000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD06", "CV03", "NV15", 30000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD06", "CV04", "NV15", 42000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD06", "CV17", "NV21", 20000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD07", "CV16", "NV12", 50000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD07", "CV17", "NV08", 20000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD08", "CV04", "NV04", 15000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD08", "CV17", "NV09", 20000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD09", "CV06", "NV18", 10000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD09", "CV07", "NV18", 10000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD09", "CV17", "NV20", 20000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD10", "CV05", "NV02", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD10", "CV15", "NV11", 10000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD10", "CV13", "NV05", 30000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD10", "CV14", "NV05", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD10", "CV17", "NV12", 50000));

            dschitiethoadon.Add(new ChiTietHoaDon("HD11", "CV06", "NV06", 10000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD11", "CV07", "NV07", 15000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD11", "CV08", "NV07", 20000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD11", "CV09", "NV08", 24000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD11", "CV10", "NV06", 30000));
            dschitiethoadon.Add(new ChiTietHoaDon("HD11", "CV17", "NV12", 20000));
        }
        public static void taodanhsachPhieuThu()
        {
            dsphieuthu.Add(new PhieuThu("PT01", new DateTime(2021, 5, 17), 1500000, "HD01"));
            dsphieuthu.Add(new PhieuThu("PT02", new DateTime(2021, 5, 20), 500000, "HD01"));

            dsphieuthu.Add(new PhieuThu("PT03", new DateTime(2021, 5, 23), 150000, "HD02"));

            dsphieuthu.Add(new PhieuThu("PT04", new DateTime(2021, 5, 25), 500000, "HD03"));
            dsphieuthu.Add(new PhieuThu("PT05", new DateTime(2021, 6, 1), 300000, "HD03"));

            dsphieuthu.Add(new PhieuThu("PT06", new DateTime(2021, 5, 25), 300000, "HD04"));
            dsphieuthu.Add(new PhieuThu("PT07", new DateTime(2021, 6, 20), 300000, "HD04"));

            dsphieuthu.Add(new PhieuThu("PT08", new DateTime(2021, 5, 30), 600000, "HD05"));
            dsphieuthu.Add(new PhieuThu("PT09", new DateTime(2021, 6, 12), 400000, "HD05"));

            dsphieuthu.Add(new PhieuThu("PT10", new DateTime(2021, 6, 6), 650000, "HD06"));

            dsphieuthu.Add(new PhieuThu("PT11", new DateTime(2021, 6, 18), 400000, "HD07"));

            dsphieuthu.Add(new PhieuThu("PT12", new DateTime(2021, 6, 25), 200000, "HD09"));

            dsphieuthu.Add(new PhieuThu("PT13", new DateTime(2021, 6, 30), 200000, "HD10"));
            dsphieuthu.Add(new PhieuThu("PT14", new DateTime(2021, 7, 7), 200000, "HD10"));
            dsphieuthu.Add(new PhieuThu("PT15", new DateTime(2021, 7, 14), 150000, "HD10"));

            dsphieuthu.Add(new PhieuThu("PT16", new DateTime(2021, 7, 10), 250000, "HD11"));
            dsphieuthu.Add(new PhieuThu("PT17", new DateTime(2021, 7, 15), 250000, "HD11"));
            dsphieuthu.Add(new PhieuThu("PT18", new DateTime(2021, 7, 20), 250000, "HD11"));
        }
        public static void Cau1()
        {
            var thucungtheoloai = dsthucung.GroupBy(c => c.LoaiThuCung).Select(grp => new
            {
                Loai = grp.Key,
                ThuCung = grp.ToList()
            });
            foreach(var loai in thucungtheoloai)
            {
                Console.WriteLine("Loại "+loai.Loai + " có "+loai.ThuCung.Count +" con:");
                foreach (var thu in loai.ThuCung)
                {
                    Console.WriteLine("Mã thú cưng " + thu.IdThuCung + " Tên thú cưng " + 
                        thu.NameThuCung + " Giới tính " + thu.Gender);
                }
            }
        }
        public static void Cau2()
        {
            foreach(var khachhang in dskhachhang)
            {
                Console.WriteLine("Tên khách hàng " + khachhang.NameKhachHang + " có các thú cưng là: ");
                var thucungtheokhach=dsthucung.Where(thucung =>thucung.IdKhachHang.Equals(khachhang.IdKhachHang));
                foreach (var thu in thucungtheokhach)
                {
                    Console.WriteLine("_ Tên thú cưng " + thu.NameThuCung);
                }
            }
        }
        public static void Cau3()
        {
            int i = 0;
            int j = 0;
            int tongsonhanvien = 0;
            foreach(var chinhanh in dschinhanh)
            {
                i++;
                var truongchinhanh=dsnhanvien.FirstOrDefault(nhanvien =>nhanvien.IdNhanVien.Equals(chinhanh.IdTruongChiNhanh));
                if(truongchinhanh != null)
                {
                    Console.WriteLine("Chi nhánh trưởng của chi nhánh " + i + " là " + truongchinhanh.NameNhanVien);
                }
                var nhanvientheonhom = dsnhanvien.GroupBy(c => c.IdNhomNhanVien).Select(grp => new
                {
                    Nhom = grp.Key,
                    NhanVien = grp.ToList()
                });
                foreach(var nhomnhanvien in dsnhomnhanvien)
                {
                    var truongnhom = dsnhanvien.FirstOrDefault(nhanvien => nhanvien.IdNhanVien.Equals(nhomnhanvien.IdTruongNhom));
                    if(nhomnhanvien!=null)
                    {
                        Console.WriteLine("Nhóm trưởng của nhóm " +  nhomnhanvien.IdNhomNhanVien+ " là " + truongnhom.NameNhanVien);
                    }
                    foreach(var nhanvien in nhanvientheonhom)
                    {
                        nhomnhanvien.SoNhanVien=nhanvien.NhanVien.Count();
                        Console.WriteLine("Có số nhân viên là " + nhomnhanvien.SoNhanVien);
                    }
                    tongsonhanvien += nhomnhanvien.SoNhanVien;
                }
            }
            Console.WriteLine("Tổng số nhân viên là: " + tongsonhanvien); 
        }
        public static void Cau4()
        {
            double max = double.MinValue;
            double min = double.MaxValue;
            string namecvmax="";
            string namecvmin="";
            foreach(var congviec in dscongviec)
            {
                double sum = 0;
                foreach(var hoadon in dschitiethoadon)
                {
                    if(congviec.IdCongViec.Equals(hoadon.IdCongViec))
                    {
                        sum += hoadon.Tiencongnhanvien;
                    }
                }
                if(sum >max)
                {
                   max = sum;
                   namecvmax = congviec.NameCongViec;
                }
                if(sum<min)
                {
                    min = sum;
                    namecvmin=congviec.NameCongViec;
                }
            }
            Console.WriteLine("Công việc có tiền công nhân viên cao nhất là "+ namecvmax +"Có số tiền công là "+max);
            Console.WriteLine("Công việc có tiền công nhân viên thấp nhất là " + namecvmin + "Có tiền là " + min);
        }
        public static void Cau5()
        {
            var hoadon = dshoadon.OrderBy(c => c.GiaTien);
            var minhoadon=hoadon.First(); 
            var maxhoadon=hoadon.Last();
            List<string> idcvmax= new List<string>();
            List<string> idcvmin=new List<string>();
            Console.WriteLine("Hóa đơn có giá tiền lớn nhất là " + maxhoadon.IdHoaDon +" giá tiền "+maxhoadon.GiaTien);
            foreach(var cthoadon in dschitiethoadon)
            {
                if(cthoadon.IdHoaDon.Equals(maxhoadon.IdHoaDon))
                {
                    idcvmax.Add(cthoadon.IdCongViec);
                }
                if(cthoadon.IdHoaDon.Equals(minhoadon.IdHoaDon))
                {
                    idcvmin.Add(cthoadon.IdCongViec);
                }
            }
            Console.WriteLine("Các công việc gồm:");
            var cvmax=dscongviec.Where(cv=>idcvmax.Contains(cv.IdCongViec)).ToList();
            foreach(var cv in cvmax)
            {
                Console.WriteLine(cv.NameCongViec);
            }

            Console.WriteLine("Hóa đơn có giá trị bé nhất là " + minhoadon.IdHoaDon+ " giá tiền "+minhoadon.GiaTien);
            var cvmin = dscongviec.Where(cv => idcvmin.Contains(cv.IdCongViec)).ToList();
            Console.WriteLine("Các công việc gồm:");
            foreach (var cv in cvmin)
            {
                Console.WriteLine(cv.NameCongViec);
            }
        }
        public static void Cau6()
        {
            DateTime today=DateTime.Today;
            int max = int.MinValue;
            int min = int.MaxValue;
            HoaDon maxhoadon=null;
            HoaDon minhoadon=null;
            foreach(HoaDon hoadon in dshoadon)
            {
                TimeSpan daypassed = today - hoadon.Ngaythangnam;
                int totalDays=(int) daypassed.TotalDays;
                if(max<totalDays)
                {
                    max= totalDays;
                    maxhoadon = hoadon;
                }
                if(min>totalDays)
                {
                    min= totalDays;
                    minhoadon = hoadon;
                }
            }
            Console.WriteLine("Hóa đơn mới nhất so với hiện tại là: ");
            Console.WriteLine("Mã hóa đơn " + maxhoadon.IdHoaDon + " Giá tiền " +maxhoadon.GiaTien + " " + maxhoadon.Ngaythangnam.Date.ToString("yyyy-MM-dd")
                + " Mã thú cưng " + maxhoadon.IdThuCung + " Mã chi nhánh " + maxhoadon.IdChiNhanh);
            Console.WriteLine("Hóa đơn cũ nhất so với hiện tại là: ");
            Console.WriteLine("Mã hóa đơn " + minhoadon.IdHoaDon + " Giá tiền " + minhoadon.GiaTien + " " + minhoadon.Ngaythangnam.Date.ToString("yyyy-MM-dd")
                + " Mã thú cưng " + minhoadon.IdThuCung + " Mã chi nhánh " + minhoadon.IdChiNhanh);
        }
        public static void Cau7()
        {
            foreach(var hoadon in dshoadon)
            {
                Console.WriteLine("Hóa đơn " + hoadon.IdHoaDon);
                var hoadontheoma=dschitiethoadon.Where(c=>c.IdHoaDon.Equals(hoadon.IdHoaDon)).
                    Select(ct=>ct.IdCongViec).ToList();
                Console.WriteLine("Số lượng công việc: " + hoadontheoma.Count);
                var congviectheohoadon=dscongviec.Where(c=>hoadontheoma.Contains(c.IdCongViec)).ToList();
                foreach(var congviec in congviectheohoadon)
                {
                    Console.WriteLine(congviec.NameCongViec);
                }
                Console.WriteLine();
            }
        }

        public static void Cau8()
        {
            Dictionary<string, double> tiencongtheokhachhang = new Dictionary<string, double>();
            foreach (var thucung in dsthucung)
            {
                var hoadontheothucung = dshoadon.Where(c => c.IdThuCung.Equals(thucung.IdThuCung));
                if(hoadontheothucung.Any() )
                {
                    double tiencong = hoadontheothucung.Sum(c => c.GiaTien);
                    if(tiencongtheokhachhang.ContainsKey(thucung.IdKhachHang))
                    {
                        tiencongtheokhachhang[thucung.IdKhachHang] += tiencong;
                    }
                    else
                    {
                        tiencongtheokhachhang.Add(thucung.IdKhachHang, tiencong);
                    }
                }
            }
            double max = double.MinValue;
            double min=double.MaxValue;
            string idkhmax = "";
            string idkhmin = "";
            foreach(var tiencong in tiencongtheokhachhang)
            {
                if(max<tiencong.Value)
                {
                    max = tiencong.Value;
                    idkhmax=tiencong.Key;
                }
                if(min>tiencong.Value)
                {
                    min = tiencong.Value;
                    idkhmin=tiencong.Key;
                }
            }
            string namekhmax = dskhachhang.FirstOrDefault(c => c.IdKhachHang.Equals(idkhmax)).NameKhachHang;
            Console.WriteLine("Khách hàng: " + namekhmax + " có tổng số tiền đã trả lớn nhất là " + max);
            string namekhmin = dskhachhang.FirstOrDefault(c => c.IdKhachHang.Equals(idkhmin)).NameKhachHang;
            Console.WriteLine("Khách hàng: " + namekhmin + " có tổng số tiền đã trả thấp nhất là " + min);
        }
        public static void Cau9()
        {
            var hoadonChuaTraHet = dshoadon.GroupJoin(
                dsphieuthu,
                hoadon => hoadon.IdHoaDon,
                phieuthu => phieuthu.IdHoaDon,
                (hoadon, phieuthu) => new
                {
                    HoaDon = hoadon,
                    TongSoTienThu = phieuthu.Sum(phieuthu => phieuthu.SoTienthu)
                }
            ).Where(result => result.HoaDon.GiaTien != result.TongSoTienThu);
            foreach (var item in hoadonChuaTraHet)
            {
                double sum = item.HoaDon.GiaTien - item.TongSoTienThu;
                Console.WriteLine("Hóa đơn chưa được trả hết là " + item.HoaDon.IdHoaDon + " số tiền còn lại là " + sum);
            }
        }
        public static void Cau10()
        {
            var hoadonDaTraXong = dshoadon.GroupJoin(
                dsphieuthu,
                hoadon => hoadon.IdHoaDon,
                phieuthu => phieuthu.IdHoaDon,
                (hoadon, phieuthu) => new
                {
                    HoaDon = hoadon,
                    Tongsotienthu = phieuthu.Sum(phieuthu => phieuthu.SoTienthu)
                }
                ).Where(tongtien => tongtien.HoaDon.GiaTien == tongtien.Tongsotienthu);
            foreach (var hoadon in hoadonDaTraXong)
            {
                Console.WriteLine("Hóa đơn đã trả xong là " + hoadon.HoaDon.IdHoaDon +" tổng số tiền là "+hoadon.HoaDon.GiaTien);
                Console.WriteLine("Các lần trả là:");
                var phieuthucuahoadon=dsphieuthu.Where(c=>c.IdHoaDon.Equals(hoadon.HoaDon.IdHoaDon)).ToList();
                foreach(var phieuthu in phieuthucuahoadon)
                {
                    Console.WriteLine("Mã phiếu thu " + phieuthu.IdPhieuThu + " số tiền trả là " + phieuthu.SoTienthu);
                }
                Console.WriteLine();
            }
        }
        public static void Cau11()
        {
            List<String> thucungtheoloai=dsthucung.Select(c=>c.LoaiThuCung).Distinct().ToList();
            string idCongViecBan = "";
            var foundCongViec = dscongviec.FirstOrDefault(c => c.NameCongViec == "Bán thú cưng");
            if (foundCongViec != null)
            {
                idCongViecBan = foundCongViec.IdCongViec;
            }
            List<string> petbuy = new List<string>();
            foreach (var hoadon in dshoadon)
            {
                List<ChiTietHoaDon> chiTiethoadon = dschitiethoadon.Where(c => c.IdHoaDon == hoadon.IdHoaDon).ToList();
                foreach(var chitiethoadon in chiTiethoadon)
                {
                    petbuy.Add(hoadon.IdThuCung);
                }
            }
            Dictionary<string, int> tansuatmua = new Dictionary<string, int>();
            int max = int.MinValue;
            foreach (string idpet in petbuy)
            {
                var type = dsthucung.FirstOrDefault(c => c.IdThuCung == idpet);
                if (type != null)
                {
                    if (tansuatmua.ContainsKey(type.LoaiThuCung))
                    {
                        tansuatmua[type.LoaiThuCung]++;
                    }
                    else
                    {
                        tansuatmua[type.LoaiThuCung] = 1;
                    }
                    int cnt = tansuatmua[type.LoaiThuCung];
                    if (cnt > max)
                    {
                        max = cnt;
                    }
                }
            }
            List<string> typeofpet = new List<string>();
            foreach(var pair in tansuatmua)
            {
                if(pair.Value==max)
                {
                    typeofpet.Add(pair.Key);
                }
            }
            foreach(string type in typeofpet)
            {
                Console.WriteLine("Loại thú cưng được mua nhiều nhất là " + type);
            }
        }
    }
}