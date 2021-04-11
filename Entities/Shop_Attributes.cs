namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_Attributes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop_Attributes()
        {
            Shop_Attributes_Vals = new HashSet<Shop_Attributes_Vals>();
            Shop_Product_Has_Vals = new HashSet<Shop_Product_Has_Vals>();
        }

        public int ID { get; set; }

        [StringLength(200)]
        public string attr_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Attributes_Vals> Shop_Attributes_Vals { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shop_Product_Has_Vals> Shop_Product_Has_Vals { get; set; }
    }
}
