namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_ProductType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_ProductType()
        {
            Shop_Product = new HashSet<Shop_Product>();
        }

        [Key]
        public int ProductTypeID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public bool? Visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Product> Shop_Product { get; set; }
    }
}
