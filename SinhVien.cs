using System;
using System.Collections.Generic;
using System.Linq;

namespace baitap1
{
    internal class SinhVien
    {
        public string MaSo { get; set; }
        public string Ten { get; set; }
        public int Tuoi { get; set; }

        public SinhVien()
        {
            MaSo = "";
            Ten = "";
            Tuoi = 0;
        }

        public SinhVien(string maSo, string ten, int tuoi)
        {
            MaSo = maSo;
            Ten = ten;
            Tuoi = tuoi;
        }

        
        public static void InDanhSach(List<SinhVien> danhSach)
        {
            foreach (var sv in danhSach)
            {
                Console.WriteLine($"Ma so: {sv.MaSo}, Ten: {sv.Ten}, Tuoi: {sv.Tuoi}");
            }
        }

        
        public static List<SinhVien> TimHocSinhTuoi1518(List<SinhVien> danhSach)
        {
            return danhSach.Where(sv => sv.Tuoi >= 15 && sv.Tuoi <= 18).ToList();
        }

        
        public static List<SinhVien> TimHocSinhTenBatDauA(List<SinhVien> danhSach)
        {
            return danhSach.Where(sv => sv.Ten.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();
        }

        
        public static int TinhTongTuoi(List<SinhVien> danhSach)
        {
            return danhSach.Sum(sv => sv.Tuoi);
        }

        
        public static SinhVien TimHocSinhTuoiLonNhat(List<SinhVien> danhSach)
        {
            return danhSach.OrderByDescending(sv => sv.Tuoi).FirstOrDefault();
        }

        
        public static List<SinhVien> SapXepTheoTuoi(List<SinhVien> danhSach)
        {
            return danhSach.OrderBy(sv => sv.Tuoi).ToList();
        }
    }
}
