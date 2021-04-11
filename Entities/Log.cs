namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        [Key]
        public int Id_Log { get; set; }

        public DateTime? DateAdd { get; set; }

        [StringLength(250)]
        public string LogContent { get; set; }
    }
}
