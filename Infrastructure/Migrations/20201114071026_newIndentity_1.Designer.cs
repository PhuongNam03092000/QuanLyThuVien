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
    [Migration("20201114071026_newIndentity_1")]
    partial class newIndentity_1
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
                    b.Property<int>("MaPT")
                        .HasColumnType("int");

                    b.Property<int>("MaSach")
                        .HasColumnType("int");

                    b.Property<int>("PhiTra")
                        .HasColumnType("int");

                    b.Property<int>("TrangThaiSachTra")
                        .HasColumnType("int");

                    b.HasKey("MaPT", "MaSach");

                    b.HasIndex("MaSach");

                    b.ToTable("ChiTietPhieuTra");
                });

            modelBuilder.Entity("Domain.Entities.DocGia", b =>
                {
                    b.Property<int>("MaDG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("MaNCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<int>("MaNXB")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenNXB")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("MaNXB");

                    b.ToTable("NhaXuatBan");
                });

            modelBuilder.Entity("Domain.Entities.PhieuMuon", b =>
                {
                    b.Property<int>("MaPM")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaDG")
                        .HasColumnType("int");

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
                    b.Property<int>("MaPN")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaNCC")
                        .HasColumnType("int");

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
                    b.Property<int>("MaPP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaDG")
                        .HasColumnType("int");

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
                    b.Property<int>("MaPT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaDG")
                        .HasColumnType("int");

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
                    b.Property<int>("MaSach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GiaBia")
                        .HasColumnType("int");

                    b.Property<int>("MaNXB")
                        .HasColumnType("int");

                    b.Property<int>("MaTG")
                        .HasColumnType("int");

                    b.Property<int>("MaTL")
                        .HasColumnType("int");

                    b.Property<string>("TenSach")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

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

                    b.HasIndex("MaNXB");

                    b.HasIndex("MaTG");

                    b.HasIndex("MaTL");

                    b.ToTable("Sach");
                });

            modelBuilder.Entity("Domain.Entities.SachImage", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageCaption")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("MaSach")
                        .HasColumnType("int");

                    b.HasKey("ImageId");

                    b.HasIndex("MaSach");

                    b.ToTable("SachImage");
                });

            modelBuilder.Entity("Domain.Entities.TacGia", b =>
                {
                    b.Property<int>("MaTG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTG")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MaTG");

                    b.ToTable("TacGia");
                });

            modelBuilder.Entity("Domain.Entities.TheLoai", b =>
                {
                    b.Property<int>("MaTL")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTL")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MaTL");

                    b.ToTable("TheLoai");
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
                        .WithMany("ChiTietPhieuMuons")
                        .HasForeignKey("MaPM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("ChiTietPhieuMuons")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                });

            modelBuilder.Entity("Domain.Entities.SachImage", b =>
                {
                    b.HasOne("Domain.Entities.Sach", "Sach")
                        .WithMany("SachImages")
                        .HasForeignKey("MaSach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
