namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Category()
        {
            Shop_ProductCategory = new HashSet<Shop_ProductCategory>();
        }

        [Key]
        public int CategoryID { get; set; }

        public int DepartmentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public virtual Shop_Department Shop_Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_ProductCategory> Shop_ProductCategory { get; set; }
    }
}
