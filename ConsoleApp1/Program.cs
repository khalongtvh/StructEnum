using System;

namespace ConsoleApp1
{
    class Program
    {
        struct SinhVien
        {
            public string MSV_229;
            public string HoTen_229;
            public double DiemTB_229;
        }

        enum diemMonHoc_229
        {
            toan_229 = 10,
            anh_229 = 9,
            van_229 = 5
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" MSV: ");
            SV.MSV_229 = Console.ReadLine();
            Console.Write(" Ho ten: ");
            SV.HoTen_229 = Console.ReadLine();
            SV.DiemTB_229 = ((int)diemMonHoc_229.toan_229 + (int)diemMonHoc_229.anh_229 + (int)diemMonHoc_229.van_229) /3;
        }

        static void XuatThongTinSinhVien(SinhVien SV)
        {
            Console.WriteLine(" MSV : " + SV.MSV_229);
            Console.WriteLine(" Ho ten: " + SV.HoTen_229);
            Console.WriteLine(" Diem TB: " + SV.DiemTB_229);
        }

        static void Main(string[] args)
        {
            

            SinhVien[] sv_229 = new SinhVien[3];
            for (int i_229 = 0; i_229 < sv_229.Length; i_229++)
            {
                NhapThongTinSinhVien(out sv_229[i_229]);
            }
            Console.Write("nhap ten sinh vien can tim : ");
            string name_229 = Console.ReadLine();
            
            for (int i = 0; i< sv_229.Length; i++)
            {
                if (sv_229[i].HoTen_229.Equals(name_229))
                {
                    Console.WriteLine("diem trung binh : " + sv_229[i].DiemTB_229);
                }
            }
        }
    }
}
