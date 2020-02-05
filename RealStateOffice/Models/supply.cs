namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.supply")]
    public partial class supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public supply()
        {
            deal = new HashSet<deal>();
        }

        [Key]
        public int supply_id { get; set; }

        public int client_id { get; set; }

        public int agent_id { get; set; }

        public int object_id { get; set; }

        public int price { get; set; }

        public virtual agent agent { get; set; }

        public virtual client client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<deal> deal { get; set; }

        public virtual _object _object { get; set; }
    }
}
