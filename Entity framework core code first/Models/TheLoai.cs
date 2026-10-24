using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyThuVienEFCore.Models
{
    public class TheLoai
    {
        [Key]
        public int MaTheLoai { get; set; }

        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        [StringLength(100)]
        public string TenTheLoai { get; set; } = string.Empty;

        public ICollection<Sach> DanhSachSach { get; set; }
            = new List<Sach>();
    }
}
