namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETHOADON")]
    public class CHITIETHOADON
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string MAHOADON { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MASACH { get; set; }

        public int? GIABAN { get; set; }

        public int? SOLUONG { get; set; }

        [Column(TypeName = "money")]
        public decimal? THANHTIEN { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
