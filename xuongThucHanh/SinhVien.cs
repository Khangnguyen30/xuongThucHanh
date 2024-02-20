using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuongThucHanh
{
    internal class SinhVien
    {
        private string maSInhVien { get; set; }
        private string Ten { get; set; }
        private int namSInh { get; set; }
        private double Diem { get; set; }
        public SinhVien()
        {
            
        }
        public SinhVien(string ma,string ten,int nam,double diem)
        {
            maSInhVien = ma;
            Ten = ten;
            namSInh = nam;
            Diem = diem;
        }
        public virtual void inThongTin()
        {
            Console.WriteLine($"Ma Sinh Vien: {maSInhVien}  Ten sinh vien: {Ten}  Diem: {Diem}  Nam Sinh: {namSInh} ");
        }
        public double GetDiem()
        {
            return Diem;
        }
        public int GetTuoi()
        {
            int namHienTai = DateTime.Now.Year;
            namHienTai -= namSInh;
            return namHienTai;
        }
        
    }
}
