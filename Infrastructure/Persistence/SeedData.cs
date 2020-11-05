using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<TacGia>().HasData(
                    new TacGia() { MaTG = "TG001", TenTG = "Nguyễn Nhật Ánh" },
                    new TacGia() { MaTG = "TG002", TenTG = "Nguyễn Ngọc Tư" }
                );
            builder.Entity<NhaXuatBan>().HasData(
                    new NhaXuatBan() { MaNXB = "NXB001",TenNXB="Nhà xuất bản trẻ"}
                );
            builder.Entity<TheLoai>().HasData(
                    new TheLoai() { MaTL = "TL001",TenTL="Truyện ngắn"},
                    new TheLoai() { MaTL="TL002",TenTL="Truyện dài"},
                    new TheLoai() { MaTL = "TL003",TenTL="Thơ"},
                    new TheLoai() { MaTL="TL004",TenTL="Tản văn"}
                );
            builder.Entity<DauSach>().HasData(
                    new DauSach() { MaDS = "DS001",TenDS="Tôi thấy hoa vàng trên cỏ xanh",MaTG="TG001",MaTL="TL002",MaNXB="NXB001",SoLuongDS=5},
                    new DauSach() { MaDS = "DS002",TenDS="Cánh đồng bất tận",MaTG="TG001",MaTL="TL001",MaNXB="NXB001",SoLuongDS=5}
                );
            builder.Entity<Sach>().HasData(
                    new Sach() { MaSach="S001",MaDS="DS001",GiaBia = 99000,TrangThaiSach = TrangThaiSach.Khong,ViTri="E401"},
                    new Sach() { MaSach = "S002", MaDS = "DS001", GiaBia = 99000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E402" },
                    new Sach() { MaSach = "S003", MaDS = "DS001", GiaBia = 99000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E403" },
                    new Sach() { MaSach = "S004", MaDS = "DS001", GiaBia = 99000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E404" },
                    new Sach() { MaSach = "S005", MaDS = "DS001", GiaBia = 99000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E405" },
                    new Sach() { MaSach = "S006",MaDS = "DS002",GiaBia = 59000,TrangThaiSach = TrangThaiSach.Khong,ViTri = "E406"},
                    new Sach() { MaSach = "S007", MaDS = "DS002", GiaBia = 59000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E407" },
                    new Sach() { MaSach = "S008", MaDS = "DS002", GiaBia = 59000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E408" },
                    new Sach() { MaSach = "S009", MaDS = "DS002", GiaBia = 59000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E409" },
                    new Sach() { MaSach = "S010", MaDS = "DS002", GiaBia = 59000, TrangThaiSach = TrangThaiSach.Khong, ViTri = "E410" }
                );
        }        
    }
}