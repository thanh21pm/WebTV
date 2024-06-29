using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DiaChi = new HashSet<DiaChi>();
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        [Column("makh")]
        public int Makh { get; set; }

       
        [Required(ErrorMessage = "Vui lòng nhập tên.")]
        [RegularExpression(@"^[^\d]+$", ErrorMessage = "Tên không được chứa chữ số.")]
        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập số điện thoại.")]
        [RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Số điện thoại phải bắt đầu bằng số 0 và có đúng 10 chữ số.")]
        [Column("dienthoai")]
        [StringLength(20)]
        public string Dienthoai { get; set; }


        [Required(ErrorMessage = "Vui lòng Email.")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ.")]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }




        [Column("matkhau")]
        [StringLength(255)]
        public string Matkhau { get; set; }
        [Column("daxoa")]
        public int? Daxoa { get; set; }

        [InverseProperty("MakhNavigation")]
        public virtual ICollection<DiaChi> DiaChi { get; set; }
        [InverseProperty("MakhNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
