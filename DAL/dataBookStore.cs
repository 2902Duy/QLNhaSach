using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class dataBookStore : DbContext
    {
        public dataBookStore()
            : base("name=dataBookStore")
        {
        }

        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHOSACH> KHOSACHes { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public virtual DbSet<THELOAI> THELOAIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.MAHOADON)
                .IsUnicode(false);

            modelBuilder.Entity<CHITIETHOADON>()
                .Property(e => e.MASACH)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.MAHOADON)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOSACH>()
                .Property(e => e.IDKHO)
                .IsUnicode(false);

            modelBuilder.Entity<KHOSACH>()
                .Property(e => e.MASACH)
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.NHAXUATBAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.MASACH)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.MATACGIA)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.KHOSACHes)
                .WithRequired(e => e.SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.MATACGIA)
                .IsUnicode(false);

            modelBuilder.Entity<TACGIA>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.TACGIA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.USERNAME)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<THELOAI>()
                .HasMany(e => e.SACHes)
                .WithRequired(e => e.THELOAI)
                .WillCascadeOnDelete(false);
        }
    }
}
