using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BanTV.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Data
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CthoaDon> CthoaDon { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DiaChi> DiaChi { get; set; }
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<MatHang> MatHang { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-K4AU2U2\\SQLEXPRESS;Database=BanTV;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CthoaDon>(entity =>
            {
                entity.HasKey(e => e.Macthd)
                    .HasName("PK__CTHoaDon__50C3A3F84C5059CC");

                entity.Property(e => e.Dongia).HasDefaultValueSql("((0))");

                entity.Property(e => e.Soluong).HasDefaultValueSql("((0))");

                entity.Property(e => e.Thanhtien).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MahdNavigation)
                    .WithMany(p => p.CthoaDon)
                    .HasForeignKey(d => d.Mahd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTHoaDon__mahd__4E88ABD4");

                entity.HasOne(d => d.MamhNavigation)
                    .WithMany(p => p.CthoaDon)
                    .HasForeignKey(d => d.Mamh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CTHoaDon__mamh__4F7CD00D");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.Madm)
                    .HasName("PK__DanhMuc__7A21E0204CD3DE44");
            });

            modelBuilder.Entity<DiaChi>(entity =>
            {
                entity.HasKey(e => e.Madc)
                    .HasName("PK__DiaChi__7A21E05A6DCD77B5");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.DiaChi)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DiaChi__makh__3B75D760");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.Mahd)
                    .HasName("PK__HoaDon__7A2100DE93D2CA7C");

                entity.Property(e => e.Tongtien).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.MadcNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.Madc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__madc__403A8C7D");

                entity.HasOne(d => d.MakhNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.Makh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDon__makh__3F466844");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.Makh)
                    .HasName("PK__KhachHan__7A21BB4CFD4429C1");

                entity.Property(e => e.Dienthoai).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Matkhau).IsUnicode(false);
            });

            modelBuilder.Entity<MatHang>(entity =>
            {
                entity.HasKey(e => e.Mamh)
                    .HasName("PK__MatHang__7A21CB8E1A2C4B7F");

                entity.Property(e => e.Hinhanh).IsUnicode(false);

                entity.HasOne(d => d.MadmNavigation)
                    .WithMany(p => p.MatHang)
                    .HasForeignKey(d => d.Madm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MatHang__madm__46E78A0C");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.Manv)
                    .HasName("PK__NhanVien__7A21B37D87370F66");

                entity.Property(e => e.Dienthoai).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Matkhau).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
