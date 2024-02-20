using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuongThucHanh
{
    internal class SinhVienUD : SinhVien
    {
        private int kiHoc { get; set; }
        public SinhVienUD()
        {
            
        }
        public SinhVienUD(string ma, string ten, int nam, double diem,int kihoc) : base(ma,ten,nam,diem)
        {
            kiHoc = kihoc;
        }
        public override void inThongTin()
        {
            base.inThongTin();
            Console.WriteLine($"Kì Học: {kiHoc}");
        }
    }
}
