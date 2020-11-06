﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    HoNV = table.Column<string>(maxLength: 50, nullable: false),
                    TenNV = table.Column<string>(maxLength: 50, nullable: false),
                    DoBNV = table.Column<DateTime>(type: "Date", nullable: false),
                    DiaChiNV = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocGia",
                columns: table => new
                {
                    MaDG = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    HoDG = table.Column<string>(maxLength: 50, nullable: false),
                    TenDG = table.Column<string>(maxLength: 50, nullable: false),
                    DoBDG = table.Column<DateTime>(type: "Date", nullable: false),
                    EmailDG = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    DiaChiDG = table.Column<string>(maxLength: 100, nullable: false),
                    NgayDK = table.Column<DateTime>(type: "Date", nullable: false),
                    NgayHetHanDK = table.Column<DateTime>(type: "Date", nullable: false),
                    TrangThaiThe = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocGia", x => x.MaDG);
                });

            migrationBuilder.CreateTable(
                name: "NhaCungCap",
                columns: table => new
                {
                    MaNCC = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    TenNCC = table.Column<string>(maxLength: 100, nullable: false),
                    DiaChiNCC = table.Column<string>(maxLength: 100, nullable: false),
                    SdtNCC = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaCungCap", x => x.MaNCC);
                });

            migrationBuilder.CreateTable(
                name: "NhaXuatBan",
                columns: table => new
                {
                    MaNXB = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    TenNXB = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhaXuatBan", x => x.MaNXB);
                });

            migrationBuilder.CreateTable(
                name: "TacGia",
                columns: table => new
                {
                    MaTG = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    TenTG = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TacGia", x => x.MaTG);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    MaTL = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    TenTL = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.MaTL);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AppRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuMuon",
                columns: table => new
                {
                    MaPM = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaDG = table.Column<string>(nullable: true),
                    NgayMuon = table.Column<DateTime>(type: "Date", nullable: false),
                    TongPhiMuon = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuMuon", x => x.MaPM);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_DocGia_MaDG",
                        column: x => x.MaDG,
                        principalTable: "DocGia",
                        principalColumn: "MaDG",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuMuon_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuPhat",
                columns: table => new
                {
                    MaPP = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaDG = table.Column<string>(nullable: true),
                    TongPhiPhat = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuPhat", x => x.MaPP);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_DocGia_MaDG",
                        column: x => x.MaDG,
                        principalTable: "DocGia",
                        principalColumn: "MaDG",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuPhat_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuTra",
                columns: table => new
                {
                    MaPT = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaDG = table.Column<string>(nullable: true),
                    NgayTra = table.Column<DateTime>(type: "Date", nullable: false),
                    TongPhiTra = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuTra", x => x.MaPT);
                    table.ForeignKey(
                        name: "FK_PhieuTra_DocGia_MaDG",
                        column: x => x.MaDG,
                        principalTable: "DocGia",
                        principalColumn: "MaDG",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuTra_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhieuNhap",
                columns: table => new
                {
                    MaPN = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaNCC = table.Column<string>(nullable: true),
                    NgayNhap = table.Column<DateTime>(type: "Date", nullable: false),
                    TongTienNhap = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuNhap", x => x.MaPN);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_NhaCungCap_MaNCC",
                        column: x => x.MaNCC,
                        principalTable: "NhaCungCap",
                        principalColumn: "MaNCC",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhieuNhap_AppUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DauSach",
                columns: table => new
                {
                    MaDS = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaTL = table.Column<string>(nullable: true),
                    MaTG = table.Column<string>(nullable: true),
                    MaNXB = table.Column<string>(nullable: true),
                    TenDS = table.Column<string>(maxLength: 100, nullable: false),
                    SoLuongDS = table.Column<int>(nullable: false),
                    HinhAnh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DauSach", x => x.MaDS);
                    table.ForeignKey(
                        name: "FK_DauSach_NhaXuatBan_MaNXB",
                        column: x => x.MaNXB,
                        principalTable: "NhaXuatBan",
                        principalColumn: "MaNXB",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DauSach_TacGia_MaTG",
                        column: x => x.MaTG,
                        principalTable: "TacGia",
                        principalColumn: "MaTG",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DauSach_TheLoai_MaTL",
                        column: x => x.MaTL,
                        principalTable: "TheLoai",
                        principalColumn: "MaTL",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuNhap",
                columns: table => new
                {
                    MaPN = table.Column<string>(nullable: false),
                    MaDS = table.Column<string>(nullable: false),
                    SoLuongNhap = table.Column<int>(nullable: false),
                    DonGiaSach = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuNhap", x => new { x.MaPN, x.MaDS });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_DauSach_MaDS",
                        column: x => x.MaDS,
                        principalTable: "DauSach",
                        principalColumn: "MaDS",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuNhap_PhieuNhap_MaPN",
                        column: x => x.MaPN,
                        principalTable: "PhieuNhap",
                        principalColumn: "MaPN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sach",
                columns: table => new
                {
                    MaSach = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaDS = table.Column<string>(nullable: true),
                    GiaBia = table.Column<int>(nullable: false),
                    ViTri = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    TrangThaiSach = table.Column<int>(nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sach", x => x.MaSach);
                    table.ForeignKey(
                        name: "FK_Sach_DauSach_MaDS",
                        column: x => x.MaDS,
                        principalTable: "DauSach",
                        principalColumn: "MaDS",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuMuon",
                columns: table => new
                {
                    MaPM = table.Column<string>(nullable: false),
                    MaSach = table.Column<string>(nullable: false),
                    PhiMuon = table.Column<int>(nullable: false),
                    NgayHetHan = table.Column<DateTime>(type: "Date", nullable: false),
                    GiaHan = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuMuon", x => new { x.MaPM, x.MaSach });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_PhieuMuon_MaPM",
                        column: x => x.MaPM,
                        principalTable: "PhieuMuon",
                        principalColumn: "MaPM",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuMuon_Sach_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sach",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuPhat",
                columns: table => new
                {
                    MaPP = table.Column<string>(nullable: false),
                    MaSach = table.Column<string>(nullable: false),
                    NoiDungViPham = table.Column<string>(maxLength: 256, nullable: false),
                    XuLyViPham = table.Column<string>(maxLength: 256, nullable: false),
                    PhiPhat = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuPhat", x => new { x.MaPP, x.MaSach });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuPhat_PhieuPhat_MaPP",
                        column: x => x.MaPP,
                        principalTable: "PhieuPhat",
                        principalColumn: "MaPP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuPhat_Sach_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sach",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuTra",
                columns: table => new
                {
                    MaPT = table.Column<string>(nullable: false),
                    MaSach = table.Column<string>(nullable: false),
                    TrangThaiSachTra = table.Column<int>(nullable: false),
                    PhiTra = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuTra", x => new { x.MaPT, x.MaSach });
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuTra_PhieuTra_MaPT",
                        column: x => x.MaPT,
                        principalTable: "PhieuTra",
                        principalColumn: "MaPT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuTra_Sach_MaSach",
                        column: x => x.MaSach,
                        principalTable: "Sach",
                        principalColumn: "MaSach",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "NhaXuatBan",
                columns: new[] { "MaNXB", "TenNXB" },
                values: new object[] { "NXB001", "Nhà xuất bản trẻ" });

            migrationBuilder.InsertData(
                table: "TacGia",
                columns: new[] { "MaTG", "TenTG" },
                values: new object[,]
                {
                    { "TG001", "Nguyễn Nhật Ánh" },
                    { "TG002", "Nguyễn Ngọc Tư" }
                });

            migrationBuilder.InsertData(
                table: "TheLoai",
                columns: new[] { "MaTL", "TenTL" },
                values: new object[,]
                {
                    { "TL001", "Truyện ngắn" },
                    { "TL002", "Truyện dài" },
                    { "TL003", "Thơ" },
                    { "TL004", "Tản văn" }
                });

            migrationBuilder.InsertData(
                table: "DauSach",
                columns: new[] { "MaDS", "HinhAnh", "MaNXB", "MaTG", "MaTL", "SoLuongDS", "TenDS" },
                values: new object[] { "DS002", "HinhAnhDauSach/DS002", "NXB001", "TG001", "TL001", 5, "Cánh đồng bất tận" });

            migrationBuilder.InsertData(
                table: "DauSach",
                columns: new[] { "MaDS", "HinhAnh", "MaNXB", "MaTG", "MaTL", "SoLuongDS", "TenDS" },
                values: new object[] { "DS001", "HinhAnhDauSach/DS001", "NXB001", "TG001", "TL002", 5, "Tôi thấy hoa vàng trên cỏ xanh" });

            migrationBuilder.InsertData(
                table: "Sach",
                columns: new[] { "MaSach", "GiaBia", "MaDS", "ViTri" },
                values: new object[,]
                {
                    { "S006", 59000, "DS002", "E406" },
                    { "S007", 59000, "DS002", "E407" },
                    { "S008", 59000, "DS002", "E408" },
                    { "S009", 59000, "DS002", "E409" },
                    { "S010", 59000, "DS002", "E410" },
                    { "S001", 99000, "DS001", "E401" },
                    { "S002", 99000, "DS001", "E402" },
                    { "S003", 99000, "DS001", "E403" },
                    { "S004", 99000, "DS001", "E404" },
                    { "S005", 99000, "DS001", "E405" }
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AppRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AppUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AppUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuMuon_MaSach",
                table: "ChiTietPhieuMuon",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuNhap_MaDS",
                table: "ChiTietPhieuNhap",
                column: "MaDS");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuPhat_MaSach",
                table: "ChiTietPhieuPhat",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuTra_MaSach",
                table: "ChiTietPhieuTra",
                column: "MaSach");

            migrationBuilder.CreateIndex(
                name: "IX_DauSach_MaNXB",
                table: "DauSach",
                column: "MaNXB");

            migrationBuilder.CreateIndex(
                name: "IX_DauSach_MaTG",
                table: "DauSach",
                column: "MaTG");

            migrationBuilder.CreateIndex(
                name: "IX_DauSach_MaTL",
                table: "DauSach",
                column: "MaTL");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_MaDG",
                table: "PhieuMuon",
                column: "MaDG");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuMuon_UserId",
                table: "PhieuMuon",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_MaNCC",
                table: "PhieuNhap",
                column: "MaNCC");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuNhap_UserId",
                table: "PhieuNhap",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_MaDG",
                table: "PhieuPhat",
                column: "MaDG");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuPhat_UserId",
                table: "PhieuPhat",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTra_MaDG",
                table: "PhieuTra",
                column: "MaDG");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuTra_UserId",
                table: "PhieuTra",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sach_MaDS",
                table: "Sach",
                column: "MaDS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuMuon");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuNhap");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuPhat");

            migrationBuilder.DropTable(
                name: "ChiTietPhieuTra");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "PhieuMuon");

            migrationBuilder.DropTable(
                name: "PhieuNhap");

            migrationBuilder.DropTable(
                name: "PhieuPhat");

            migrationBuilder.DropTable(
                name: "PhieuTra");

            migrationBuilder.DropTable(
                name: "Sach");

            migrationBuilder.DropTable(
                name: "NhaCungCap");

            migrationBuilder.DropTable(
                name: "DocGia");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "DauSach");

            migrationBuilder.DropTable(
                name: "NhaXuatBan");

            migrationBuilder.DropTable(
                name: "TacGia");

            migrationBuilder.DropTable(
                name: "TheLoai");
        }
    }
}