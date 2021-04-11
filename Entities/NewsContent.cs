namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsContent")]
    public partial class NewsContent
    {
        public int Id { get; set; }

        public int SubCategoryId { get; set; }

        [Required]
        [StringLength(500)]
        public string Title { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        public string Image { get; set; }

        public DateTime CreatedOnDate { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime ModifiedOnDate { get; set; }

        public int ModifiedByUserId { get; set; }

        public bool Published { get; set; }

        public bool MarkedImage { get; set; }

        public bool MarkedVideo { get; set; }

        public bool HotNews { get; set; }

        public DateTime HotNewsCreatedOnDate { get; set; }

        public bool Slide { get; set; }

        public DateTime SlideCreatedOnDate { get; set; }

        public bool Deleted { get; set; }
    }
}
