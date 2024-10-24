namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SACH")]
    public  class SACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SACH()
        {
            CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            KHOSACHes = new HashSet<KHOSACH>();
        }

        public int IDMASACH { get; set; }

        [Key]
        [StringLength(6)]
        public string MASACH { get; set; }

        [Required]
        [StringLength(100)]
        public string TENNHAXUATBAN { get; set; }

        [Required]
        [StringLength(30)]
        public string TENTHELOAI { get; set; }

        [Required]
        [StringLength(6)]
        public string MATACGIA { get; set; }

        [StringLength(100)]
        public string TENSACH { get; set; }

        public int? GIANHAP { get; set; }

        public int? GIABAN { get; set; }

        public int? NAMXUATBAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOSACH> KHOSACHes { get; set; }

        public virtual NHAXUATBAN NHAXUATBAN { get; set; }

        public virtual TACGIA TACGIA { get; set; }

        public virtual THELOAI THELOAI { get; set; }

    }
}
