using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xuongThucHanh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            Console.OutputEncoding = Encoding.UTF8;
            SinhVienService SVService = new SinhVienService();
            int chon = -1;
            do
            {
                Console.WriteLine("-----------QUAN LY SINH VIEN----------");
                Console.WriteLine("1.Nhập một hoặc nhiều sinh viên");
                Console.WriteLine("2.Xuất danh sách SV");
                Console.WriteLine("3.Sinh viên có vé HappyBEE");
                Console.WriteLine("4.Sinh viên không được tham gia HappyBee");
                Console.WriteLine("5.Kế thừa");
                Console.WriteLine("0.Thoát");
                Console.Write("Mời bạn chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        SVService.themSV();
                        break;
                    case 2:
                        SVService.xuatDS();
                        break;
                    case 3:
                        SVService.SVCoVe();
                        break;
                    case 4:
                        SVService.svKhongVe();
                        break;
                    case 5:
                        keThua();
                        break;
                    case 0:
                        Console.WriteLine("Thoát!!");
                        break;
                    default:
                        Console.WriteLine("Chi chon 0-5");
                        break;
                }
            } while (chon != 0);
        }
        static void keThua()
        {
            Console.Write("Nhập MaSV: ");
            string ma = Console.ReadLine();
            Console.Write("Nhập Ten: ");
            string ten = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            int nam = int.Parse(Console.ReadLine());
            Console.Write("Nhập điểm: ");
            double diem = double.Parse(Console.ReadLine());
            Console.Write("Nhập kì học: ");
            int kihoc = int.Parse(Console.ReadLine());
            SinhVienUD sinhVienUD = new SinhVienUD(ma,ten,nam,diem,kihoc);
            sinhVienUD.inThongTin();
        }
    }
}
