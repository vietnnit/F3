namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Videoclip")]
    public partial class Videoclip
    {
        [Key]
        public int ClipId { get; set; }

        [StringLength(200)]
        public string Clip_Name { get; set; }

        [StringLength(500)]
        public string Clip_Des { get; set; }

        [StringLength(100)]
        public string Clip_File { get; set; }

        public bool? Visible { get; set; }

        public DateTime? Clip_Create { get; set; }

        public int Group_Id { get; set; }
    }
}
