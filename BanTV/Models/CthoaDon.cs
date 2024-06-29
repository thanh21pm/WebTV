using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    [Table("CTHoaDon")]
    public partial class CthoaDon
    {
        [Key]
        [Column("macthd")]
        public int Macthd { get; set; }
        [Column("mahd")]
        public int Mahd { get; set; }
        [Column("mamh")]
        public int Mamh { get; set; }
        [Column("dongia")]
        public int Dongia { get; set; }
        [Column("soluong")]
        public short Soluong { get; set; }
        [Column("thanhtien")]
        public int Thanhtien { get; set; }

        [ForeignKey(nameof(Mahd))]
        [InverseProperty(nameof(HoaDon.CthoaDon))]
        public virtual HoaDon MahdNavigation { get; set; }
        [ForeignKey(nameof(Mamh))]
        [InverseProperty(nameof(MatHang.CthoaDon))]
        public virtual MatHang MamhNavigation { get; set; }
    }
}
