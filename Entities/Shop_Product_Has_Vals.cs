namespace Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_Product_Has_Vals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public int? attr_id { get; set; }

        public int? val_id { get; set; }

        public virtual Shop_Attributes Shop_Attributes { get; set; }

        public virtual Shop_Attributes_Vals Shop_Attributes_Vals { get; set; }
    }
}
