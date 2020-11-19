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
    [DbContext(typeof(QLTVContext))]
    [Migration("20201119124308_test3")]
    partial class test3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("Domain.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoBNV")
                        .HasColumnType("Date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("HoNV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNV")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuMuon", b =>
                {
                    b.Property<int>("MaPM")
                        .HasColumnType("int");

                    b.Property<int>("MaSach")
                        .HasColumnType("int");

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
                    b.Property<int>("MaPN")
                        .HasColumnType("int");

                    b.Property<int>("MaSach")
                        .HasColumnType("int");

                    b.Property<int>("DonGiaSach")
                        .HasColumnType("int");

                    b.Property<int>("SoLuongNhap")
                        .HasColumnType("int");

                    b.HasKey("MaPN", "MaSach");

                    b.HasIndex("MaPN")
                        .IsUnique();

                    b.ToTable("ChiTietPhieuNhap");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuPhat", b =>
                {
                    b.Property<int>("MaPP")
                        .HasColumnType("int");

                    b.Property<int>("MaSach")
                        .HasColumnType("int");

                    b.Property<string>("NoiDungViPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhiPhat")
                        .HasColumnType("int");

                    b.Property<string>("XuLyViPham")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPP", "MaSach");

                    b.HasIndex("MaSach");

                    b.ToTable("ChiTietPhieuPhat");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuTra", b =>
                {
                    b.Property<int>("MaPT")
                        .HasColumnType("int");

                    b.Property<int>("MaSach")
                        .HasColumnType("int");

                    b.Property<int>("PhiTra")
                        .HasColumnType("int");

                    b.Property<string>("TrangThaiSachTra")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPT", "MaSach");

                    b.HasIndex("MaSach");

                    b.ToTable("ChiTietPhieuTra");
                });

            modelBuilder.Entity("Domain.Entities.DocGia", b =>
                {
                    b.Property<int>("MaDG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChiDG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoBDG")
                        .HasColumnType("Date");

                    b.Property<string>("EmailDG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoDG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDK")
                        .HasColumnType("Date");

                    b.Property<DateTime>("NgayHetHanDK")
                        .HasColumnType("Date");

                    b.Property<string>("TenDG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThaiThe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaDG");

                    b.ToTable("DocGia");
                });

            modelBuilder.Entity("Domain.Entities.NhaCungCap", b =>
                {
                    b.Property<int>("MaNCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiaChiNCC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SdtNCC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNCC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNCC");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("Domain.Entities.NhaXuatBan", b =>
                {
                    b.Property<int>("MaNXB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenNXB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNXB");

                    b.ToTable("NhaXuatBan");
                });

            modelBuilder.Entity("Domain.Entities.PhieuMuon", b =>
                {
                    b.Property<int>("MaPM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaDG")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayMuon")
                        .HasColumnType("Date");

                    b.Property<int>("TongPhiMuon")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MaPM");

                    b.HasIndex("MaDG");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuMuon");
                });

            modelBuilder.Entity("Domain.Entities.PhieuNhap", b =>
                {
                    b.Property<int>("MaPN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaNCC")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayNhap")
                        .HasColumnType("Date");

                    b.Property<int>("TongTienNhap")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MaPN");

                    b.HasIndex("MaNCC");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuNhap");
                });

            modelBuilder.Entity("Domain.Entities.PhieuPhat", b =>
                {
                    b.Property<int>("MaPP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaDG")
                        .HasColumnType("int");

                    b.Property<int>("TongPhiPhat")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MaPP");

                    b.HasIndex("MaDG");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuPhat");
                });

            modelBuilder.Entity("Domain.Entities.PhieuTra", b =>
                {
                    b.Property<int>("MaPT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MaDG")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTra")
                        .HasColumnType("Date");

                    b.Property<int>("TongPhiTra")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MaPT");

                    b.HasIndex("MaDG");

                    b.HasIndex("UserId");

                    b.ToTable("PhieuTra");
                });

            modelBuilder.Entity("Domain.Entities.Sach", b =>
                {
                    b.Property<int>("MaSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("GiaBia")
                        .HasColumnType("int");

                    b.Property<int>("MaNXB")
                        .HasColumnType("int");

                    b.Property<int>("MaTG")
                        .HasColumnType("int");

                    b.Property<int>("MaTL")
                        .HasColumnType("int");

                    b.Property<string>("SachImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenSach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThaiSach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTri")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaSach");

                    b.HasIndex("MaNXB");

                    b.HasIndex("MaTG");

                    b.HasIndex("MaTL");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("Domain.Entities.TacGia", b =>
                {
                    b.Property<int>("MaTG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenTG")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaTG");

                    b.ToTable("TacGia");
                });

            modelBuilder.Entity("Domain.Entities.TheLoai", b =>
                {
                    b.Property<int>("MaTL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenTL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaTL");

                    b.ToTable("TheLoai");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

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
                        .WithMany("ChiTietPhieuMuons")
                        .HasForeignKey("MaPM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("ChiTietPhieuMuons")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuMuon");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuNhap", b =>
                {
                    b.HasOne("Domain.Entities.PhieuNhap", "PhieuNhap")
                        .WithMany("ChiTietPhieuNhaps")
                        .HasForeignKey("MaPN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithOne("ChiTietPhieuNhap")
                        .HasForeignKey("Domain.Entities.ChiTietPhieuNhap", "MaPN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuNhap");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuPhat", b =>
                {
                    b.HasOne("Domain.Entities.PhieuPhat", "PhieuPhat")
                        .WithMany("ChiTietPhieuPhats")
                        .HasForeignKey("MaPP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("ChiTietPhieuPhats")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuPhat");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Domain.Entities.ChiTietPhieuTra", b =>
                {
                    b.HasOne("Domain.Entities.PhieuTra", "PhieuTra")
                        .WithMany("ChiTietPhieuTras")
                        .HasForeignKey("MaPT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("ChiTietPhieuTras")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuTra");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Domain.Entities.PhieuMuon", b =>
                {
                    b.HasOne("Domain.Entities.DocGia", "DocGia")
                        .WithMany("PhieuMuons")
                        .HasForeignKey("MaDG")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("PhieuMuons")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("DocGia");
                });

            modelBuilder.Entity("Domain.Entities.PhieuNhap", b =>
                {
                    b.HasOne("Domain.Entities.NhaCungCap", "NhaCungCap")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("MaNCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("PhieuNhaps")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("NhaCungCap");
                });

            modelBuilder.Entity("Domain.Entities.PhieuPhat", b =>
                {
                    b.HasOne("Domain.Entities.DocGia", "DocGia")
                        .WithMany("PhieuPhats")
                        .HasForeignKey("MaDG")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("PhieuPhats")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("DocGia");
                });

            modelBuilder.Entity("Domain.Entities.PhieuTra", b =>
                {
                    b.HasOne("Domain.Entities.DocGia", "DocGia")
                        .WithMany("PhieuTras")
                        .HasForeignKey("MaDG")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.AppUser", "AppUser")
                        .WithMany("PhieuTras")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");

                    b.Navigation("DocGia");
                });

            modelBuilder.Entity("Domain.Entities.Sach", b =>
                {
                    b.HasOne("Domain.Entities.NhaXuatBan", "NhaXuatBan")
                        .WithMany("Sachs")
                        .HasForeignKey("MaNXB")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TacGia", "TacGia")
                        .WithMany("Sachs")
                        .HasForeignKey("MaTG")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TheLoai", "TheLoai")
                        .WithMany("Sachs")
                        .HasForeignKey("MaTL")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NhaXuatBan");

                    b.Navigation("TacGia");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.AppUser", b =>
                {
                    b.Navigation("PhieuMuons");

                    b.Navigation("PhieuNhaps");

                    b.Navigation("PhieuPhats");

                    b.Navigation("PhieuTras");
                });

            modelBuilder.Entity("Domain.Entities.DocGia", b =>
                {
                    b.Navigation("PhieuMuons");

                    b.Navigation("PhieuPhats");

                    b.Navigation("PhieuTras");
                });

            modelBuilder.Entity("Domain.Entities.NhaCungCap", b =>
                {
                    b.Navigation("PhieuNhaps");
                });

            modelBuilder.Entity("Domain.Entities.NhaXuatBan", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("Domain.Entities.PhieuMuon", b =>
                {
                    b.Navigation("ChiTietPhieuMuons");
                });

            modelBuilder.Entity("Domain.Entities.PhieuNhap", b =>
                {
                    b.Navigation("ChiTietPhieuNhaps");
                });

            modelBuilder.Entity("Domain.Entities.PhieuPhat", b =>
                {
                    b.Navigation("ChiTietPhieuPhats");
                });

            modelBuilder.Entity("Domain.Entities.PhieuTra", b =>
                {
                    b.Navigation("ChiTietPhieuTras");
                });

            modelBuilder.Entity("Domain.Entities.Sach", b =>
                {
                    b.Navigation("ChiTietPhieuMuons");

                    b.Navigation("ChiTietPhieuNhap");

                    b.Navigation("ChiTietPhieuPhats");

                    b.Navigation("ChiTietPhieuTras");
                });

            modelBuilder.Entity("Domain.Entities.TacGia", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("Domain.Entities.TheLoai", b =>
                {
                    b.Navigation("Sachs");
                });
#pragma warning restore 612, 618
        }
    }
}
