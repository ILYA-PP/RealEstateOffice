namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.land_dem")]
    public partial class land_dem
    {
        [Key]
        public int demand_id { get; set; }

        public int? min_area { get; set; }

        public int? max_area { get; set; }

        public virtual demand demand { get; set; }
    }
}
