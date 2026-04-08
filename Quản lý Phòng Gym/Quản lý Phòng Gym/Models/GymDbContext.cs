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
            // Thay TÊN_SERVER_CỦA_BẠN bằng tên máy bạn (ví dụ: .\SQLEXPRESS)
            optionsBuilder.UseSqlServer("Server=TÊN_SERVER_CỦA_BẠN;Database=GymDB_CodeFirst;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}