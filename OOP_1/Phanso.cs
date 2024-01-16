
using System;
namespace OOP_1
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

        public void NhapPhanSo()
        {
            Console.WriteLine("Nhap tu  so:");
            tuSo = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap mau  so:");
            mauSo = int.Parse(Console.ReadLine());
        }

        public PhanSo Cong(PhanSo ps)
        {
            int tuSoMoi = (this.tuSo * ps.mauSo) + (ps.tuSo * this.mauSo);
            int mauSoMoi = this.mauSo * ps.mauSo;

            return BinhThuongHoa(new PhanSo(tuSoMoi, mauSoMoi));
        }

        public PhanSo Tru(PhanSo ps)
        {
            int tuSoMoi = (this.tuSo * ps.mauSo) - (ps.tuSo * this.mauSo);
            int mauSoMoi = this.mauSo * ps.mauSo;

            return BinhThuongHoa(new PhanSo(tuSoMoi, mauSoMoi));
        }

        public PhanSo Nhan(PhanSo ps)
        {
            int tuSoMoi = this.tuSo * ps.tuSo;
            int mauSoMoi = this.mauSo * ps.mauSo;

            return BinhThuongHoa(new PhanSo(tuSoMoi, mauSoMoi));
        }

        public PhanSo Chia(PhanSo ps)
        {
            int tuSoMoi = this.tuSo * ps.mauSo;
            int mauSoMoi = this.mauSo * ps.tuSo;

            return BinhThuongHoa(new PhanSo(tuSoMoi, mauSoMoi));
        }

        public void HienThiPhanSo()
        {
            Console.WriteLine("(" + tuSo + "/" + mauSo + ")");
        }

        public void HienThiThapPhan()
        {
            double thapPhan = (double)tuSo / mauSo;
            Console.WriteLine(thapPhan);
        }

        private int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        private PhanSo BinhThuongHoa(PhanSo ps)
        {
            int ucln = UCLN(ps.tuSo, ps.mauSo);
            ps.tuSo /= ucln;
            ps.mauSo /= ucln;

            if (ps.mauSo < 0)
            {
                ps.tuSo *= -1;
                ps.mauSo *= -1;
            }

            return ps;
        }
    }
}
   
