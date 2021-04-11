namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnnouncementLocation")]
    public partial class AnnouncementLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnnouncementLocation()
        {
            Announcements = new HashSet<Announcement>();
        }

        [Key]
        public int LocationId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
