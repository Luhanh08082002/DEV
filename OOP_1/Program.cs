using OOP_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("nhap phan so thu nhat:");
        PhanSo ps1 = new PhanSo(0, 1);
        ps1.NhapPhanSo();

        Console.WriteLine("nhap phan so thu hai:");
        PhanSo ps2 = new PhanSo(0, 1);
        ps2.NhapPhanSo();

        PhanSo tong = ps1.Cong(ps2);
        PhanSo hieu = ps1.Tru(ps2);
        PhanSo tich = ps1.Nhan(ps2);
        PhanSo thuong = ps1.Chia(ps2);

        Console.WriteLine("Tong: ");
        tong.HienThiPhanSo();

        Console.WriteLine("Hieu: ");
        hieu.HienThiPhanSo();

        Console.WriteLine("Tich: ");
        tich.HienThiPhanSo();

        Console.WriteLine("Thuong: ");
        thuong.HienThiPhanSo();

        Console.WriteLine("dang  so thap phan cua phan so thu nhat:");
        ps1.HienThiThapPhan();

        Console.WriteLine("dang  so thap phan cua phan so thu nhat:");
        ps2.HienThiThapPhan();
    }
}