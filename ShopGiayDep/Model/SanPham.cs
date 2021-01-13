namespace ShopGiayDep.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(20)]
        public string MaSP { get; set; }

        [StringLength(250)]
        public string TenSP { get; set; }

        [Required]
        [StringLength(20)]
        public string MaTH { get; set; }

        [StringLength(50)]
        public string MauSac { get; set; }

        public int Size { get; set; }

        public decimal? GiaVon { get; set; }

        public int SoLuongTon { get; set; }

        public decimal GiaBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual ThuongHieu ThuongHieu { get; set; }
    }
}
