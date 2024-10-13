namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public class TAIKHOAN
    {
        [Key]
        [StringLength(30)]
        public string USERNAME { get; set; }

        [StringLength(100)]
        public string PASSWORD { get; set; }
    }
}
