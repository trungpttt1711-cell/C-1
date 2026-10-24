using Microsoft.EntityFrameworkCore;
using QuanLyThuVienEFCore.Models;

namespace QuanLyThuVienEFCore.Data
{
    public class QLTVDBContext : DbContext
    {
        public DbSet<Sach> Sach { get; set; }
        public DbSet<TheLoai> TheLoai { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\MSSQLLocalDB;Database=QLTVDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sach>()
                .HasOne(s => s.TheLoai)
                .WithMany(t => t.DanhSachSach)
                .HasForeignKey(s => s.MaTheLoai);
        }
    }
}
