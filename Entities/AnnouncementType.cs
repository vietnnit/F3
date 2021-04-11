namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnnouncementType")]
    public partial class AnnouncementType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnnouncementType()
        {
            Announcements = new HashSet<Announcement>();
        }

        [Key]
        public int TypeId { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public bool? Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Announcement> Announcements { get; set; }
    }
}
