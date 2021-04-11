namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoppingCart")]
    public partial class ShoppingCart
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string CartID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DateAdded { get; set; }
    }
}
