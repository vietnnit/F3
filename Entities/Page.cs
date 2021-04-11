namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Page")]
    public partial class Page
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public DateTime? CreatedOnDate { get; set; }

        public int? CreatedByUserId { get; set; }

        public DateTime? ModifiedOnDate { get; set; }

        public int? ModifiedByUserId { get; set; }

        public bool? Published { get; set; }

        public bool? Visible { get; set; }

        public bool? HotNews { get; set; }

        public virtual User User { get; set; }
    }
}
