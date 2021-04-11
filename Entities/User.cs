namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Pages = new HashSet<Page>();
        }

        public int Id { get; set; }

        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }

        [Required]
        [StringLength(500)]
        public string FullName { get; set; }

        [Required]
        [StringLength(500)]
        public string Email { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public DateTime CreatedOnDate { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime LastModifiedOnDate { get; set; }

        public int LastModifiedByUserId { get; set; }

        public DateTime LastLoginDate { get; set; }

        public bool Dennied { get; set; }

        public bool Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Page> Pages { get; set; }
    }
}
