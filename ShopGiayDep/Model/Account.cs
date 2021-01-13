namespace ShopGiayDep.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [Key]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(20)]
        public string MaCV { get; set; }

        [StringLength(20)]
        public string MaNV { get; set; }

        public int TinhTrang { get; set; }

        public virtual ChucVu ChucVu { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
