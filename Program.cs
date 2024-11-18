using System;
using System.Collections.Generic;

namespace baitap1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<SinhVien> danhSach = new List<SinhVien>
            {
                new SinhVien("001", "Nguyen Van A", 16),
                new SinhVien("002", "Tran Thi B", 18),
                new SinhVien("003", "Le Van C", 20),
                new SinhVien("004", "Anh Nguyen D", 17),
                new SinhVien("005", "Pham Thi E", 22)
            };

            
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            SinhVien.InDanhSach(danhSach);
            Console.WriteLine();

            
            Console.WriteLine("Hoc sinh co tuoi tu 15 den 18:");
            var hocSinhTuoi1518 = SinhVien.TimHocSinhTuoi1518(danhSach);
            SinhVien.InDanhSach(hocSinhTuoi1518);
            Console.WriteLine();

            
            Console.WriteLine("Hoc sinh co ten bat dau bang chu A:");
            var hocSinhTenA = SinhVien.TimHocSinhTenBatDauA(danhSach);
            SinhVien.InDanhSach(hocSinhTenA);
            Console.WriteLine();

            
            int tongTuoi = SinhVien.TinhTongTuoi(danhSach);
            Console.WriteLine($"Tong tuoi cua tat ca hoc sinh: {tongTuoi}");
            Console.WriteLine();

            
            Console.WriteLine("Hoc sinh co tuoi lon nhat:");
            var hocSinhTuoiLonNhat = SinhVien.TimHocSinhTuoiLonNhat(danhSach);
            if (hocSinhTuoiLonNhat != null)
            {
                Console.WriteLine($"Ma so: {hocSinhTuoiLonNhat.MaSo}, Ten: {hocSinhTuoiLonNhat.Ten}, Tuoi: {hocSinhTuoiLonNhat.Tuoi}");
            }
            Console.WriteLine();

            
            Console.WriteLine("Danh sach hoc sinh sau khi sap xep theo tuoi tang dan:");
            var danhSachSapXep = SinhVien.SapXepTheoTuoi(danhSach);
            SinhVien.InDanhSach(danhSachSapXep);
            Console.WriteLine();
        }
    }
}
