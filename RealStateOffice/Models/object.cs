namespace RealStateOffice
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("public.object")]
    public partial class _object
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public _object()
        {
            supply = new HashSet<supply>();
        }

        [Key]
        public int object_id { get; set; }

        public int? address_id { get; set; }

        public float? latitude { get; set; }

        public float? longitude { get; set; }
        public int? type_id { get; set; }

        public virtual address address { get; set; }
        public virtual objecttype objecttype { get; set; }

        public virtual apartment apartment { get; set; }

        public virtual house house { get; set; }

        public virtual land land { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<supply> supply { get; set; }
    }
}
