namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Department()
        {
            Shop_Category = new HashSet<Shop_Category>();
        }

        [Key]
        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public bool IsHomepage { get; set; }

        public bool Visible { get; set; }

        public int? ParentID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Category> Shop_Category { get; set; }
    }
}
