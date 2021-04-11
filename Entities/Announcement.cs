namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Announcement")]
    public partial class Announcement
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(4000)]
        public string Contents { get; set; }

        public int? TypeId { get; set; }

        public int? LocationId { get; set; }

        [StringLength(50)]
        public string ImageSmall { get; set; }

        [StringLength(50)]
        public string ImageLarge { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateEnd { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public bool? Deleted { get; set; }

        public virtual AnnouncementLocation AnnouncementLocation { get; set; }

        public virtual AnnouncementType AnnouncementType { get; set; }
    }
}
