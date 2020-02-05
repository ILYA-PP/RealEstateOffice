namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.land")]
    public partial class land
    {
        [Key]
        public int object_id { get; set; }

        public float? area { get; set; }

        public virtual _object _object { get; set; }
    }
}
