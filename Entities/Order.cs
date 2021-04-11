namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DateShipped { get; set; }

        public bool Verified { get; set; }

        public bool Completed { get; set; }

        public bool Canceled { get; set; }

        [StringLength(1000)]
        public string Comments { get; set; }

        [StringLength(50)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string CustomerEmail { get; set; }

        [StringLength(500)]
        public string ShippingAddress { get; set; }

        [StringLength(50)]
        public string CustomerMobile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
