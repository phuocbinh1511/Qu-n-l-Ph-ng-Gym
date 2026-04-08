using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Quan_Ly_Phong_Gym.Models
{
    public class HoiVien
    {
        [Key]
        public int MaHoiVien { get; set; }

        [Required]
        public string HoTen { get; set; } = default!; 

        public string? SoDienThoai { get; set; } 

        
        public int MaGoi { get; set; }

        [ForeignKey("MaGoi")]
        public GoiTap GoiTap { get; set; } = default!;
    }
}