﻿// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(QLTVDbContext))]
    [Migration("20201106141145_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("Domain.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChiNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("DoBNV")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("HoNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuMuon", b =>
                {
                    b.Property<string>("MaPM")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MaSach")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("GiaHan")
                        .HasColumnType("Date");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("Date");

                    b.Property<int>("PhiMuon")
                        .HasColumnType("int");

                    b.HasKey("MaPM", "MaSach");

                    b.HasIndex("MaSach");

                    b.ToTable("ChiTietPhieuMuon");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuNhap", b =>
                {
                    b.Property<string>("MaPN")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MaDS")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("DonGiaSach")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.HasKey("MaPN", "MaDS");

                    b.HasIndex("MaDS");

                    b.ToTable("ChiTietPhieuNhap");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuPhat", b =>
                {
                    b.Property<string>("MaPP")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MaSach")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NoiDungViPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("PhiPhat")
                        .HasColumnType("int");

                    b.Property<string>("XuLyViPham")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("MaPP", "MaSach");

                    b.HasIndex("MaSach");

                    b.ToTable("ChiTietPhieuPhat");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuTra", b =>
                {
                    b.Property<string>("MaPT")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MaSach")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("PhiTra")
                        .HasColumnType("int");

                    b.Property<int>("TrangThaiSachTra")
                        .HasColumnType("int");

                    b.HasKey("MaPT", "MaSach");

                    b.HasIndex("MaSach");

                    b.ToTable("ChiTietPhieuTra");
                });

            modelBuilder.Entity("Domain.Entities.DauSach", b =>
                {
                    b.Property<string>("MaDS")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("HinhAnh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNXB")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MaTG")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("MaTL")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("SoLuongDS")
                        .HasColumnType("int");

                    b.Property<string>("TenDS")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaDS");

                    b.HasIndex("MaNXB");

                    b.HasIndex("MaTG");

                    b.HasIndex("MaTL");

                    b.ToTable("DauSach");

                    b.HasData(
                        new
                        {
                            MaDS = "DS001",
                            HinhAnh = "HinhAnhDauSach/DS001",
                            MaNXB = "NXB001",
                            MaTG = "TG001",
                            MaTL = "TL002",
                            SoLuongDS = 5,
                            TenDS = "Tôi thấy hoa vàng trên cỏ xanh"
                        },
                        new
                        {
                            MaDS = "DS002",
                            HinhAnh = "HinhAnhDauSach/DS002",
                            MaNXB = "NXB001",
                            MaTG = "TG001",
                            MaTL = "TL001",
                            SoLuongDS = 5,
                            TenDS = "Cánh đồng bất tận"
                        });
                });

            modelBuilder.Entity("Domain.Entities.DocGia", b =>
                {
                    b.Property<string>("MaDG")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("DiaChiDG")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<DateTime>("DoBDG")
                        .HasColumnType("Date");

                    b.Property<string>("EmailDG")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("HoDG")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<DateTime>("NgayDK")
                        .HasColumnType("Date");

                    b.Property<DateTime>("NgayHetHanDK")
                        .HasColumnType("Date");

                    b.Property<string>("TenDG")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<int>("TrangThaiThe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("MaDG");

                    b.ToTable("DocGia");
                });

            modelBuilder.Entity("Domain.Entities.NhaCungCap", b =>
                {
                    b.Property<string>("MaNCC")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("DiaChiNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SdtNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaNCC");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("Domain.Entities.NhaXuatBan", b =>
                {
                    b.Property<string>("MaNXB")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("MaNXB");

                    b.ToTable("NhaXuatBan");

                    b.HasData(
                        new
                        {
                            MaNXB = "NXB001",
                            TenNXB = "Nhà xuất bản trẻ"
                        });
                });

            modelBuilder.Entity("Domain.Entities.PhieuMuon", b =>
                {
                    b.Property<string>("MaPM")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("MaDG")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("NgayMuon")
                        .HasColumnType("Date");

                    b.Property<int>("TongPhiMuon")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaPM");

                    b.HasIndex("MaDG");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuMuon");
                });

            modelBuilder.Entity("Domain.Entities.PhieuNhap", b =>
                {
                    b.Property<string>("MaPN")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("MaNCC")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("Date");

                    b.Property<int>("TongTienNhap")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaPN");

                    b.HasIndex("MaNCC");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuNhap");
                });

            modelBuilder.Entity("Domain.Entities.PhieuPhat", b =>
                {
                    b.Property<string>("MaPP")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("MaDG")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("TongPhiPhat")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaPP");

                    b.HasIndex("MaDG");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuPhat");
                });

            modelBuilder.Entity("Domain.Entities.PhieuTra", b =>
                {
                    b.Property<string>("MaPT")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("MaDG")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("Date");

                    b.Property<int>("TongPhiTra")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaPT");

                    b.HasIndex("MaDG");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuTra");
                });

            modelBuilder.Entity("Domain.Entities.Sach", b =>
                {
                    b.Property<string>("MaSach")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("GiaBia")
                        .HasColumnType("int");

                    b.Property<string>("MaDS")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("TrangThaiSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("ViTri")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("MaSach");

                    b.HasIndex("MaDS");

                    b.ToTable("Sach");

                    b.HasData(
                        new
                        {
                            MaSach = "S001",
                            GiaBia = 99000,
                            MaDS = "DS001",
                            TrangThaiSach = 0,
                            ViTri = "E401"
                        },
                        new
                        {
                            MaSach = "S002",
                            GiaBia = 99000,
                            MaDS = "DS001",
                            TrangThaiSach = 0,
                            ViTri = "E402"
                        },
                        new
                        {
                            MaSach = "S003",
                            GiaBia = 99000,
                            MaDS = "DS001",
                            TrangThaiSach = 0,
                            ViTri = "E403"
                        },
                        new
                        {
                            MaSach = "S004",
                            GiaBia = 99000,
                            MaDS = "DS001",
                            TrangThaiSach = 0,
                            ViTri = "E404"
                        },
                        new
                        {
                            MaSach = "S005",
                            GiaBia = 99000,
                            MaDS = "DS001",
                            TrangThaiSach = 0,
                            ViTri = "E405"
                        },
                        new
                        {
                            MaSach = "S006",
                            GiaBia = 59000,
                            MaDS = "DS002",
                            TrangThaiSach = 0,
                            ViTri = "E406"
                        },
                        new
                        {
                            MaSach = "S007",
                            GiaBia = 59000,
                            MaDS = "DS002",
                            TrangThaiSach = 0,
                            ViTri = "E407"
                        },
                        new
                        {
                            MaSach = "S008",
                            GiaBia = 59000,
                            MaDS = "DS002",
                            TrangThaiSach = 0,
                            ViTri = "E408"
                        },
                        new
                        {
                            MaSach = "S009",
                            GiaBia = 59000,
                            MaDS = "DS002",
                            TrangThaiSach = 0,
                            ViTri = "E409"
                        },
                        new
                        {
                            MaSach = "S010",
                            GiaBia = 59000,
                            MaDS = "DS002",
                            TrangThaiSach = 0,
                            ViTri = "E410"
                        });
                });

            modelBuilder.Entity("Domain.Entities.TacGia", b =>
                {
                    b.Property<string>("MaTG")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("TenTG")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MaTG");

                    b.ToTable("TacGia");

                    b.HasData(
                        new
                        {
                            MaTG = "TG001",
                            TenTG = "Nguyễn Nhật Ánh"
                        },
                        new
                        {
                            MaTG = "TG002",
                            TenTG = "Nguyễn Ngọc Tư"
                        });
                });

            modelBuilder.Entity("Domain.Entities.TheLoai", b =>
                {
                    b.Property<string>("MaTL")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("TenTL")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MaTL");

                    b.ToTable("TheLoai");

                    b.HasData(
                        new
                        {
                            MaTL = "TL001",
                            TenTL = "Truyện ngắn"
                        },
                        new
                        {
                            MaTL = "TL002",
                            TenTL = "Truyện dài"
                        },
                        new
                        {
                            MaTL = "TL003",
                            TenTL = "Thơ"
                        },
                        new
                        {
                            MaTL = "TL004",
                            TenTL = "Tản văn"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuMuon", b =>
                {
                    b.HasOne("Domain.Entities.PhieuMuon", "PhieuMuon")
                        .WithMany("DSChiTietPhieuMuon")
                        .HasForeignKey("MaPM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("DSChiTietPhieuMuon")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuNhap", b =>
                {
                    b.HasOne("Domain.Entities.DauSach", "DauSach")
                        .WithMany("DSChiTietPhieuNhap")
                        .HasForeignKey("MaDS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.PhieuNhap", "PhieuNhap")
                        .WithMany("DSChiTietPhieuNhap")
                        .HasForeignKey("MaPN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuPhat", b =>
                {
                    b.HasOne("Domain.Entities.PhieuPhat", "PhieuPhat")
                        .WithMany("DSChiTietPhieuPhat")
                        .HasForeignKey("MaPP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("DSChiTietPhieuPhat")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuTra", b =>
                {
                    b.HasOne("Domain.Entities.PhieuTra", "PhieuTra")
                        .WithMany("DSChiTietPhieuTra")
                        .HasForeignKey("MaPT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("DSChiTietPhieuTra")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.DauSach", b =>
                {
                    b.HasOne("Domain.Entities.NhaXuatBan", "NhaXuatBan")
                        .WithMany("DSDauSach")
                        .HasForeignKey("MaNXB");

                    b.HasOne("Domain.Entities.TacGia", "TacGia")
                        .WithMany("DSDauSach")
                        .HasForeignKey("MaTG");

                    b.HasOne("Domain.Entities.TheLoai", "TheLoai")
                        .WithMany("DSDauSach")
                        .HasForeignKey("MaTL");
                });

            modelBuilder.Entity("Domain.Entities.PhieuMuon", b =>
                {
                    b.HasOne("Domain.Entities.DocGia", "DocGia")
                        .WithMany("DSPhieuMuon")
                        .HasForeignKey("MaDG");

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("DSPhieuMuon")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PhieuNhap", b =>
                {
                    b.HasOne("Domain.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("DSPhieuNhap")
                        .HasForeignKey("MaNCC");

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("DSPhieuNhap")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PhieuPhat", b =>
                {
                    b.HasOne("Domain.Entities.DocGia", "DocGia")
                        .WithMany("DSPhieuPhat")
                        .HasForeignKey("MaDG");

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("DSPhieuPhat")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PhieuTra", b =>
                {
                    b.HasOne("Domain.Entities.DocGia", "DocGia")
                        .WithMany("DSPhieuTra")
                        .HasForeignKey("MaDG");

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("DSPhieuTra")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Sach", b =>
                {
                    b.HasOne("Domain.Entities.DauSach", "DauSach")
                        .WithMany("DSSach")
                        .HasForeignKey("MaDS");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}