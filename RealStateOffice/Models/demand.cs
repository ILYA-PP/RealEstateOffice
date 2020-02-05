namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.demand")]
    public partial class demand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public demand()
        {
            deal = new HashSet<deal>();
        }

        [Key]
        public int demand_id { get; set; }

        public int client_id { get; set; }

        public int agent_id { get; set; }

        public int address_id { get; set; }

        public int type_id { get; set; }

        public int? min_price { get; set; }

        public int? max_price { get; set; }

        public virtual address address { get; set; }

        public virtual agent agent { get; set; }

        public virtual apartment_dem apartment_dem { get; set; }

        public virtual client client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<deal> deal { get; set; }

        public virtual objecttype objecttype { get; set; }

        public virtual house_dem house_dem { get; set; }

        public virtual land_dem land_dem { get; set; }
    }
}
