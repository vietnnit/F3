namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [StringLength(50)]
        public string Image1FileName { get; set; }

        [StringLength(50)]
        public string Image2FileName { get; set; }

        public bool OnCatalogPromotion { get; set; }

        public bool OnDepartmentPromotion { get; set; }

        [StringLength(2000)]
        public string SumaryDescription { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string Image3FileName { get; set; }

        [StringLength(4000)]
        public string Promotion { get; set; }

        [StringLength(200)]
        public string Warranty { get; set; }

        public int? ProductTypeID { get; set; }

        public virtual Shop_ProductType Shop_ProductType { get; set; }
    }
}
