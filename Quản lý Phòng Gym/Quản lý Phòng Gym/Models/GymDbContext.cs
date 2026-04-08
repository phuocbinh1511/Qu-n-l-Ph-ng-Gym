using Microsoft.EntityFrameworkCore;
using Quan_Ly_Phong_Gym.Models;

namespace BT_CodeFirst_CafeManager.Models
{
    public class GymDbContext : DbContext
    {
        public DbSet<GoiTap> GoiTaps { get; set; }
        public DbSet<HoiVien> HoiViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer("Server=LAPTOP-J6SKU6DO\\HAPHUOCBINH;Database=GymDB_CodeFirst;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}