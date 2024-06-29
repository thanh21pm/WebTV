using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    public partial class DiaChi
    {
        public DiaChi()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        [Column("madc")]
        public int Madc { get; set; }
        [Required]
        [Column("diachi")]
        [StringLength(100)]
        public string Diachi1 { get; set; }
        [Required]
        [Column("phuongxa")]
        [StringLength(100)]
        public string Phuongxa { get; set; }
        [Required]
        [Column("quanhuyen")]
        [StringLength(100)]
        public string Quanhuyen { get; set; }
        [Required]
        [Column("tinhthanh")]
        [StringLength(100)]
        public string Tinhthanh { get; set; }
        [Column("makh")]
        public int Makh { get; set; }
        [Column("macdinh")]
        public int? Macdinh { get; set; }
        [Column("daxoa")]
        public int? Daxoa { get; set; }

        [ForeignKey(nameof(Makh))]
        [InverseProperty(nameof(KhachHang.DiaChi))]
        public virtual KhachHang MakhNavigation { get; set; }
        [InverseProperty("MadcNavigation")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
