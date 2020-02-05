namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.house_dem")]
    public partial class house_dem
    {
        [Key]
        public int demand_id { get; set; }

        public int? min_area { get; set; }

        public int? max_area { get; set; }

        public int? min_rooms { get; set; }

        public int? max_rooms { get; set; }

        public int? min_floors { get; set; }

        public int? max_floors { get; set; }

        public virtual demand demand { get; set; }
    }
}
