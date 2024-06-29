using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    public partial class MatHang
    {
        public MatHang()
        {
            CthoaDon = new HashSet<CthoaDon>();
        }

        [Key]
        [Column("mamh")]
        public int Mamh { get; set; }
        [Required]
        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; }
        [Column("giagoc")]
        public int Giagoc { get; set; }
        [Column("giaban")]
        public int Giaban { get; set; }
        [Column("soluong")]
        public int Soluong { get; set; }
        [Column("mota")]
        [StringLength(500)]
        public string Mota { get; set; }
        [Column("hinhanh")]
        [StringLength(255)]
        public string Hinhanh { get; set; }
        [Column("daxoa")]
        public int Daxoa { get; set; }
        [Column("madm")]
        public int Madm { get; set; }
        public int? luotxem { get; set; }
        public int luotmua { get; set; }
        public int? hot { get; set; }

        [ForeignKey(nameof(Madm))]
        [InverseProperty(nameof(DanhMuc.MatHang))]
        public virtual DanhMuc MadmNavigation { get; set; }
        [InverseProperty("MamhNavigation")]
        public virtual ICollection<CthoaDon> CthoaDon { get; set; }
    }
}
