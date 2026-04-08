using System.ComponentModel.DataAnnotations;




namespace Quan_Ly_Phong_Gym.Models
{
    public class GoiTap
    {
        [Key]
        public int MaGoi { get; set; }

        [Required]
        public string TenGoi { get; set; } = default!; // Thêm đoạn này

        public double GiaTien { get; set; }

        // Quan hệ: Một gói tập có nhiều hội viên đăng ký
        public ICollection<HoiVien> HoiViens { get; set; } = new List<HoiVien>(); // Khởi tạo danh sách mới
    }
}