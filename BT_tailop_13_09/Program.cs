using System;
using System.Collections.Generic;

class NhaKhoaHoc
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string BangCap { get; set; }
    public string ChucVu { get; set; }
    public int SoBaiBaoCongBo { get; set; }
    public int SoNgayCongTrongThang { get; set; }
    public int BacLuong { get; set; }

    public double TinhLuong()
    {
        return SoNgayCongTrongThang * BacLuong;
    }
}

class NhaQuanLy
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string BangCap { get; set; }
    public string ChucVu { get; set; }
    public int SoNgayCongTrongThang { get; set; }
    public int BacLuong { get; set; }

    public double TinhLuong()
    {
        return SoNgayCongTrongThang * BacLuong;
    }
}

class NhanVienPhongThiNghiem
{
    public string HoTen { get; set; }
    public int NamSinh { get; set; }
    public string BangCap { get; set; }
    public double LuongTrongThang { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<NhaKhoaHoc> danhSachNhaKhoaHoc = NhapDanhSachNhaKhoaHoc();
        List<NhaQuanLy> danhSachNhaQuanLy = NhapDanhSachNhaQuanLy();
        List<NhanVienPhongThiNghiem> danhSachNhanVienPhongThiNghiem = NhapDanhSachNhanVienPhongThiNghiem();

        Console.WriteLine("Danh sách nhà khoa học:");
        XuatDanhSachNhaKhoaHoc(danhSachNhaKhoaHoc);

        Console.WriteLine("\nDanh sách nhà quản lý:");
        XuatDanhSachNhaQuanLy(danhSachNhaQuanLy);

        Console.WriteLine("\nDanh sách nhân viên phòng thí nghiệm:");
        XuatDanhSachNhanVienPhongThiNghiem(danhSachNhanVienPhongThiNghiem);

        double tongLuongNhaKhoaHoc = TinhTongLuongNhaKhoaHoc(danhSachNhaKhoaHoc);
        double tongLuongNhaQuanLy = TinhTongLuongNhaQuanLy(danhSachNhaQuanLy);
        double tongLuongNhanVienPhongThiNghiem = TinhTongLuongNhanVienPhongThiNghiem(danhSachNhanVienPhongThiNghiem);

        Console.WriteLine("\nTổng lương đã chi trả cho nhà khoa học: " + tongLuongNhaKhoaHoc);
        Console.WriteLine("Tổng lương đã chi trả cho nhà quản lý: " + tongLuongNhaQuanLy);
        Console.WriteLine("Tổng lương đã chi trả cho nhân viên phòng thí nghiệm: " + tongLuongNhanVienPhongThiNghiem);
    }

    static List<NhaKhoaHoc> NhapDanhSachNhaKhoaHoc()
    {
        List<NhaKhoaHoc> danhSachNhaKhoaHoc = new List<NhaKhoaHoc>();

        Console.Write("Nhập số lượng nhà khoa học: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            NhaKhoaHoc nhaKhoaHoc = new NhaKhoaHoc();

            Console.WriteLine("\nNhập thông tin nhà khoa học thứ " + (i + 1) + ":");
            Console.Write("Họ tên: ");
            nhaKhoaHoc.HoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            nhaKhoaHoc.NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Bằng cấp: ");
            nhaKhoaHoc.BangCap = Console.ReadLine();

            Console.Write("Chức vụ: ");
            nhaKhoaHoc.ChucVu = Console.ReadLine();

            Console.Write("Số bài báo đã công bố: ");
            nhaKhoaHoc.SoBaiBaoCongBo = int.Parse(Console.ReadLine());

            Console.Write("Số ngày công trong tháng: ");
            nhaKhoaHoc.SoNgayCongTrongThang = int.Parse(Console.ReadLine());

            Console.Write("Bậc lương: ");
            nhaKhoaHoc.BacLuong = int.Parse(Console.ReadLine());

            danhSachNhaKhoaHoc.Add(nhaKhoaHoc);
        }

        return danhSachNhaKhoaHoc;
    }

    static List<NhaQuanLy> NhapDanhSachNhaQuanLy()
    {
        List<NhaQuanLy> danhSachNhaQuanLy = new List<NhaQuanLy>();

        Console.Write("Nhập số lượng nhà quản lý: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            NhaQuanLy nhaQuanLy = new NhaQuanLy();

            Console.WriteLine("\nNhập thông tin nhà quản lý thứ " + (i + 1) + ":");
            Console.Write("Họ tên: ");
            nhaQuanLy.HoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            nhaQuanLy.NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Bằng cấp: ");
            nhaQuanLy.BangCap = Console.ReadLine();

            Console.Write("Chức vụ: ");
            nhaQuanLy.ChucVu = Console.ReadLine();

            Console.Write("Số ngày công trong tháng: ");
            nhaQuanLy.SoNgayCongTrongThang = int.Parse(Console.ReadLine());

            Console.Write("Bậc lương: ");
            nhaQuanLy.BacLuong = int.Parse(Console.ReadLine());

            danhSachNhaQuanLy.Add(nhaQuanLy);
        }

        return danhSachNhaQuanLy;
    }

    static List<NhanVienPhongThiNghiem> NhapDanhSachNhanVienPhongThiNghiem()
    {
        List<NhanVienPhongThiNghiem> danhSachNhanVienPhongThiNghiem = new List<NhanVienPhongThiNghiem>();

        Console.Write("Nhập số lượng nhân viên phòng thí nghiệm: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            NhanVienPhongThiNghiem nhanVienPhongThiNghiem = new NhanVienPhongThiNghiem();

            Console.WriteLine("\nNhập thông tin nhân viên phòng thí nghiệm thứ " + (i + 1) + ":");
            Console.Write("Họ tên: ");
            nhanVienPhongThiNghiem.HoTen = Console.ReadLine();

            Console.Write("Năm sinh: ");
            nhanVienPhongThiNghiem.NamSinh = int.Parse(Console.ReadLine());

            Console.Write("Bằng cấp: ");
            nhanVienPhongThiNghiem.BangCap = Console.ReadLine();

            Console.Write("Lương trong tháng: ");
            nhanVienPhongThiNghiem.LuongTrongThang = double.Parse(Console.ReadLine());

            danhSachNhanVienPhongThiNghiem.Add(nhanVienPhongThiNghiem);
        }

        return danhSachNhanVienPhongThiNghiem;
    }

    static void XuatDanhSachNhaKhoaHoc(List<NhaKhoaHoc> danhSachNhaKhoaHoc)
    {
        foreach (NhaKhoaHoc nhaKhoaHoc in danhSachNhaKhoaHoc)
        {
            Console.WriteLine("\nHọ tên: " + nhaKhoaHoc.HoTen);
            Console.WriteLine("Năm sinh: " + nhaKhoaHoc.NamSinh);
            Console.WriteLine("Bằng cấp: " + nhaKhoaHoc.BangCap);
            Console.WriteLine("Số bài báo đã công bố: " + nhaKhoaHoc.SoBaiBaoCongBo);
            Console.WriteLine("Số ngày công trong tháng: " + nhaKhoaHoc.SoNgayCongTrongThang);
            Console.WriteLine("Bậc lương: " + nhaKhoaHoc.BacLuong);
            Console.WriteLine("Lương: " + nhaKhoaHoc.TinhLuong());
        }
    }

    static void XuatDanhSachNhaQuanLy(List<NhaQuanLy> danhSachNhaQuanLy)
    {
        foreach (NhaQuanLy nhaQuanLy in danhSachNhaQuanLy)
        {
            Console.WriteLine("\nHọ tên: " + nhaQuanLy.HoTen);
            Console.WriteLine("Năm sinh: " + nhaQuanLy.NamSinh);
            Console.WriteLine("Bằng cấp: " + nhaQuanLy.BangCap);
            Console.WriteLine("Chức vụ: " + nhaQuanLy.ChucVu);
            Console.WriteLine("Số ngày công trong tháng: " + nhaQuanLy.SoNgayCongTrongThang);
            Console.WriteLine("Bậc lương: " + nhaQuanLy.BacLuong);
            Console.WriteLine("Lương: " + nhaQuanLy.TinhLuong());
        }