namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Consultant")]
    public partial class Consultant
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(2000)]
        public string Conntent { get; set; }

        public DateTime? DateAdd { get; set; }

        public bool? Visible { get; set; }
    }
}
