namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Document
    {
        public int DocumentId { get; set; }

        [StringLength(200)]
        public string Document_Name { get; set; }

        [StringLength(500)]
        public string Document_Des { get; set; }

        [StringLength(100)]
        public string Document_File { get; set; }

        public bool? Visible { get; set; }

        public DateTime? Document_Create { get; set; }
    }
}
