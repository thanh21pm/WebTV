using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            CthoaDon = new HashSet<CthoaDon>();
        }

        [Key]
        [Column("mahd")]
        public int Mahd { get; set; }
        [Column("ngay", TypeName = "datetime")]
        public DateTime Ngay { get; set; }
        [Column("tongtien")]
        public int Tongtien { get; set; }
        [Column("makh")]
        public int Makh { get; set; }
        [Column("madc")]
        public int Madc { get; set; }
        [Column("trangthai")]
        public int Trangthai { get; set; }

        [ForeignKey(nameof(Madc))]
        [InverseProperty(nameof(DiaChi.HoaDon))]
        public virtual DiaChi MadcNavigation { get; set; }
        [ForeignKey(nameof(Makh))]
        [InverseProperty(nameof(KhachHang.HoaDon))]
        public virtual KhachHang MakhNavigation { get; set; }
        [InverseProperty("MahdNavigation")]
        public virtual ICollection<CthoaDon> CthoaDon { get; set; }
    }
}
