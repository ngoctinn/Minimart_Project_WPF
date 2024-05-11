using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Minimart_Project_WPF.Models
{
    public partial class csassignmentContext : DbContext
    {
        public csassignmentContext()
        {
        }

        public csassignmentContext(DbContextOptions<csassignmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; } = null!;
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; } = null!;
        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; } = null!;
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; } = null!;
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; } = null!;
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ngoctin\\TIN;Initial Catalog=cs-assignment;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChiTietHoaDon");

                entity.Property(e => e.DonGia)
                    .HasColumnType("money")
                    .HasColumnName("donGia");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("maHoaDon")
                    .IsFixedLength();

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maSanPham")
                    .IsFixedLength();

                entity.Property(e => e.SoLuong).HasColumnName("soLuong");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("money")
                    .HasColumnName("thanhTien");

                entity.HasOne(d => d.MaHoaDonNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDon_HoaDon");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietHoaDon_SanPham");
            });

            modelBuilder.Entity<ChiTietPhieuNhap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChiTietPhieuNhap");

                entity.Property(e => e.DonGia)
                    .HasColumnType("money")
                    .HasColumnName("donGia");

                entity.Property(e => e.MaPhieuNhap)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("maPhieuNhap")
                    .IsFixedLength();

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maSanPham")
                    .IsFixedLength();

                entity.Property(e => e.SoLuong).HasColumnName("soLuong");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("money")
                    .HasColumnName("thanhTien");

                entity.HasOne(d => d.MaPhieuNhapNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaPhieuNhap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietPhieuNhap_PhieuNhap");

                entity.HasOne(d => d.MaSanPhamNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ChiTietPhieuNhap_SanPham");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHoaDon)
                    .HasName("PK_HoaDon_1");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHoaDon)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .HasColumnName("maHoaDon")
                    .IsFixedLength();

                entity.Property(e => e.GiamGia)
                    .HasColumnType("money")
                    .HasColumnName("giamGia");

                entity.Property(e => e.MaKhachHang)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maKhachHang")
                    .IsFixedLength();

                entity.Property(e => e.MaKhuyenMai)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maKhuyenMai")
                    .IsFixedLength();

                entity.Property(e => e.MaNguoiTao)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNguoiTao")
                    .IsFixedLength();

                entity.Property(e => e.TenKhuyenMai)
                    .HasMaxLength(255)
                    .HasColumnName("tenKhuyenMai");

                entity.Property(e => e.ThanhTien)
                    .HasColumnType("money")
                    .HasColumnName("thanhTien");

                entity.Property(e => e.ThoiGianTao)
                    .HasPrecision(0)
                    .HasColumnName("thoiGianTao");

                entity.Property(e => e.TienNhan)
                    .HasColumnType("money")
                    .HasColumnName("tienNhan");

                entity.Property(e => e.TienThua)
                    .HasColumnType("money")
                    .HasColumnName("tienThua");

                entity.Property(e => e.TongTien)
                    .HasColumnType("money")
                    .HasColumnName("tongTien");

                entity.HasOne(d => d.MaKhachHangNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhachHang)
                    .HasConstraintName("FK_HoaDon_KhachHang");

                entity.HasOne(d => d.MaKhuyenMaiNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKhuyenMai)
                    .HasConstraintName("FK_HoaDon_KhuyenMai");

                entity.HasOne(d => d.MaNguoiTaoNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaNguoiTao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDon_NguoiTao");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKhachHang);

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKhachHang)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maKhachHang")
                    .IsFixedLength();

                entity.Property(e => e.DiemThanhVien).HasColumnName("diemThanhVien");

                entity.Property(e => e.HangThanhVien)
                    .HasMaxLength(4)
                    .HasColumnName("hangThanhVien");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(255)
                    .HasColumnName("hoTen");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("soDienThoai");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");
            });

            modelBuilder.Entity<KhuyenMai>(entity =>
            {
                entity.HasKey(e => e.MaKhuyenMai);

                entity.ToTable("KhuyenMai");

                entity.Property(e => e.MaKhuyenMai)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maKhuyenMai")
                    .IsFixedLength();

                entity.Property(e => e.GiaTri).HasColumnName("giaTri");

                entity.Property(e => e.LoaiGiaTri)
                    .HasMaxLength(50)
                    .HasColumnName("loaiGiaTri");

                entity.Property(e => e.TenKhuyenMai)
                    .HasMaxLength(255)
                    .HasColumnName("tenKhuyenMai");

                entity.Property(e => e.ThoiGianBatDau)
                    .HasPrecision(0)
                    .HasColumnName("thoiGianBatDau");

                entity.Property(e => e.ThoiGianKetThuc)
                    .HasPrecision(0)
                    .HasColumnName("thoiGianKetThuc");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoaiSanPham);

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.MaLoaiSanPham)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maLoaiSanPham")
                    .IsFixedLength();

                entity.Property(e => e.TenLoaiSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("tenLoaiSanPham");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.MaNguoiDung)
                    .HasName("PK_NguoiDung_1");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.MaNguoiDung)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNguoiDung")
                    .IsFixedLength();

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("diaChi");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.GioiTinh)
                    .HasMaxLength(3)
                    .HasColumnName("gioiTinh");

                entity.Property(e => e.HoTen)
                    .HasMaxLength(255)
                    .HasColumnName("hoTen");

                entity.Property(e => e.MaPhanQuyen)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("maPhanQuyen")
                    .IsFixedLength();

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("matKhau");

                entity.Property(e => e.NgaySinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaySinh");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("soDienThoai");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("tenDangNhap");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");

                entity.HasOne(d => d.MaPhanQuyenNavigation)
                    .WithMany(p => p.NguoiDungs)
                    .HasForeignKey(d => d.MaPhanQuyen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NguoiDung_PhanQuyen");
            });

            modelBuilder.Entity<NhaCungCap>(entity =>
            {
                entity.HasKey(e => e.MaNhaCungCap);

                entity.ToTable("NhaCungCap");

                entity.Property(e => e.MaNhaCungCap)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNhaCungCap")
                    .IsFixedLength();

                entity.Property(e => e.DiaChi)
                    .HasMaxLength(255)
                    .HasColumnName("diaChi");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.SoDienThoai)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("soDienThoai");

                entity.Property(e => e.TenNhaCungCap)
                    .HasMaxLength(255)
                    .HasColumnName("tenNhaCungCap");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");
            });

            modelBuilder.Entity<PhanQuyen>(entity =>
            {
                entity.HasKey(e => e.MaPhanQuyen);

                entity.ToTable("PhanQuyen");

                entity.Property(e => e.MaPhanQuyen)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("maPhanQuyen")
                    .IsFixedLength();

                entity.Property(e => e.TenPhanQuyen)
                    .HasMaxLength(255)
                    .HasColumnName("tenPhanQuyen");
            });

            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.HasKey(e => e.MaPhieuNhap);

                entity.ToTable("PhieuNhap");

                entity.Property(e => e.MaPhieuNhap)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("maPhieuNhap")
                    .IsFixedLength();

                entity.Property(e => e.MaNguoiDuyet)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNguoiDuyet")
                    .IsFixedLength();

                entity.Property(e => e.MaNguoiNhap)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNguoiNhap")
                    .IsFixedLength();

                entity.Property(e => e.MaNguoiTao)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNguoiTao")
                    .IsFixedLength();

                entity.Property(e => e.MaNhaCungCap)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maNhaCungCap")
                    .IsFixedLength();

                entity.Property(e => e.ThoiGianDuyet)
                    .HasPrecision(0)
                    .HasColumnName("thoiGianDuyet");

                entity.Property(e => e.ThoiGianNhap)
                    .HasPrecision(0)
                    .HasColumnName("thoiGianNhap");

                entity.Property(e => e.ThoiGianTao)
                    .HasPrecision(0)
                    .HasColumnName("thoiGianTao");

                entity.Property(e => e.TongTien)
                    .HasColumnType("money")
                    .HasColumnName("tongTien");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");

                entity.HasOne(d => d.MaNguoiDuyetNavigation)
                    .WithMany(p => p.PhieuNhapMaNguoiDuyetNavigations)
                    .HasForeignKey(d => d.MaNguoiDuyet)
                    .HasConstraintName("FK_PhieuNhap_NguoiDuyet");

                entity.HasOne(d => d.MaNguoiNhapNavigation)
                    .WithMany(p => p.PhieuNhapMaNguoiNhapNavigations)
                    .HasForeignKey(d => d.MaNguoiNhap)
                    .HasConstraintName("FK_PhieuNhap_NguoiNhap");

                entity.HasOne(d => d.MaNguoiTaoNavigation)
                    .WithMany(p => p.PhieuNhapMaNguoiTaoNavigations)
                    .HasForeignKey(d => d.MaNguoiTao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhieuNhap_NguoiTao");

                entity.HasOne(d => d.MaNhaCungCapNavigation)
                    .WithMany(p => p.PhieuNhaps)
                    .HasForeignKey(d => d.MaNhaCungCap)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhieuNhap_NhaCungCap");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSanPham);

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maSanPham")
                    .IsFixedLength();

                entity.Property(e => e.Anh)
                    .HasColumnType("image")
                    .HasColumnName("anh");

                entity.Property(e => e.DonViTinh)
                    .HasMaxLength(50)
                    .HasColumnName("donViTinh");

                entity.Property(e => e.GiaBan)
                    .HasColumnType("money")
                    .HasColumnName("giaBan");

                entity.Property(e => e.MaLoaiSanPham)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("maLoaiSanPham")
                    .IsFixedLength();

                entity.Property(e => e.SoLuong).HasColumnName("soLuong");

                entity.Property(e => e.TenSanPham)
                    .HasMaxLength(255)
                    .HasColumnName("tenSanPham");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(50)
                    .HasColumnName("trangThai");

                entity.HasOne(d => d.MaLoaiSanPhamNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoaiSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPham_LoaiSanPham");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
