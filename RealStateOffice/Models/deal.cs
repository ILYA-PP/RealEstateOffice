namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.deal")]
    public partial class deal
    {
        [Key]
        public int deal_id { get; set; }

        public int demand_id { get; set; }

        public int supply_id { get; set; }

        public virtual demand demand { get; set; }

        public virtual supply supply { get; set; }
    }
}
