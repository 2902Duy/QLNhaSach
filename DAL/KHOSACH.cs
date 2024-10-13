namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOSACH")]
    public class KHOSACH
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [StringLength(6)]
        public string IDKHO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string MASACH { get; set; }

        public byte? SL { get; set; }

        public virtual SACH SACH { get; set; }
    }
}
