namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TACGIA")]
    public class TACGIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TACGIA()
        {
            SACHes = new HashSet<SACH>();
        }

        public int IDTACGIA { get; set; }

        [Key]
        [StringLength(6)]
        public string MATACGIA { get; set; }

        [Required]
        [StringLength(100)]
        public string TENTACGIA { get; set; }

        [Required]
        [StringLength(100)]
        public string QUEQUAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SACH> SACHes { get; set; }
    }
}
