using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    public partial class NhanVien
    {
        [Key]
        [Column("manv")]
        public int Manv { get; set; }
        [Required]
        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; }
        [Required]
        [Column("dienthoai")]
        [StringLength(20)]
        public string Dienthoai { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Required]
        [Column("matkhau")]
        [StringLength(255)]
        public string Matkhau { get; set; }
        [Column("quyen")]
        public int? Quyen { get; set; }
    }
}
