namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Counter")]
    public partial class Counter
    {
        public int ID { get; set; }

        public DateTime DateVisited { get; set; }

        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(10)]
        public string Country { get; set; }
    }
}
