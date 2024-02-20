using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuongThucHanh
{
    internal class SinhVienService
    {
        List<SinhVien> DSSV = new List<SinhVien>();
        public void themSV()
        {
            int tiepTuc = -1;
            do
            {
                Console.Write("Nhập MaSV: ");
                string ma = Console.ReadLine();
                Console.Write("Nhập Ten: ");
                string ten = Console.ReadLine();
                Console.Write("Nhập năm sinh: ");
                int nam = int.Parse(Console.ReadLine());
                Console.Write("Nhập điểm: ");
                double diem = double.Parse(Console.ReadLine());
                SinhVien sinhVien = new SinhVien(ma,ten,nam,diem);
                DSSV.Add(sinhVien);
                Console.Write("Ban muon chon tiep khong (1-co/2-Khong):");
                tiepTuc = int.Parse(Console.ReadLine());
            } while (tiepTuc == 1);
        }
        public void xuatDS()
        {
            foreach (SinhVien IN in DSSV)
            {
                IN.inThongTin();
            }
        }
        public void SVCoVe()
        {
            Console.WriteLine("Danh sach sinh vien duoc tang ve HappyBee la: ");
            foreach (SinhVien IN in DSSV)
            {
                if (IN.GetDiem() >= 8)
                {
                    IN.inThongTin();
                }
            }
        }
        public void svKhongVe()
        {
            SinhVien Xoasinhvien = DSSV.Find(xoa => xoa.GetTuoi() > 25);
            if(Xoasinhvien.GetTuoi() > 25)
            {
                DSSV.Remove(Xoasinhvien);
            }
            foreach (SinhVien IN in DSSV)
            {
                    IN.inThongTin();
            }
        }
    }
}
