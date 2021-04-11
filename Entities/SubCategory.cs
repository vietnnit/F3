namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SubCategory")]
    public partial class SubCategory
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Seo { get; set; }

        public bool Deleted { get; set; }
    }
}
