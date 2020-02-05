namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.house")]
    public partial class house
    {
        [Key]
        public int object_id { get; set; }

        public short? floor_count { get; set; }

        public short? room_count { get; set; }

        public float? area { get; set; }

        public virtual _object _object { get; set; }
    }
}
