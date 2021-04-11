namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ad
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string AdTitle { get; set; }

        [Column(TypeName = "ntext")]
        public string AdDescription { get; set; }

        [StringLength(100)]
        public string AdLink { get; set; }

        [StringLength(50)]
        public string AdImage { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateStart { get; set; }

        public DateTime? DateEnd { get; set; }

        public bool? Deleted { get; set; }

        public int? PositionId { get; set; }

        [StringLength(50)]
        public string AdLargeImage { get; set; }

        public int Stt { get; set; }

        public virtual PositionAd PositionAd { get; set; }
    }
}
