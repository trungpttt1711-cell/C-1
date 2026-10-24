
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyThuVienEFCore.Models
{
    public class Sach
    {
        [Key]
        public int MaSach { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        [StringLength(200)]
        public string TenSach { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(100)]
        public string TacGia { get; set; } = string.Empty;

        [Range(0, int.MaxValue)]
        public int NamXuatBan { get; set; }

        [Range(0, double.MaxValue)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal GiaBan { get; set; }

        [Required]
        public int MaTheLoai { get; set; }

        [ForeignKey(nameof(MaTheLoai))]
        public TheLoai TheLoai { get; set; } = null!;
    }
}
