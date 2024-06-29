using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BanTV.Models
{
    public partial class DanhMuc
    {
        public DanhMuc()
        {
            MatHang = new HashSet<MatHang>();
        }

        [Key]
        [Column("madm")]
        public int Madm { get; set; }
        [Required]
        [Column("ten")]
        [StringLength(100)]
        public string Ten { get; set; }

        [InverseProperty("MadmNavigation")]
        public virtual ICollection<MatHang> MatHang { get; set; }
    }
}
