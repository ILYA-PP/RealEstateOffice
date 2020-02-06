namespace RealStateOffice
{
    using System.Data.Entity;

    public partial class RealEstateEDM : DbContext
    {
        public RealEstateEDM()
            : base("name=RealEstateEDM")
        {
        }

        public virtual DbSet<address> address { get; set; }
        public virtual DbSet<agent> agent { get; set; }
        public virtual DbSet<apartment> apartment { get; set; }
        public virtual DbSet<apartment_dem> apartment_dem { get; set; }
        public virtual DbSet<client> client { get; set; }
        public virtual DbSet<deal> deal { get; set; }
        public virtual DbSet<demand> demand { get; set; }
        public virtual DbSet<house> house { get; set; }
        public virtual DbSet<house_dem> house_dem { get; set; }
        public virtual DbSet<land> land { get; set; }
        public virtual DbSet<land_dem> land_dem { get; set; }
        public virtual DbSet<_object> _object { get; set; }
        public virtual DbSet<objecttype> objecttype { get; set; }
        public virtual DbSet<supply> supply { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<address>()
                .HasMany(e => e.demand)
                .WithRequired(e => e.address)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<agent>()
                .HasMany(e => e.demand)
                .WithRequired(e => e.agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<agent>()
                .HasMany(e => e.supply)
                .WithRequired(e => e.agent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.demand)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<client>()
                .HasMany(e => e.supply)
                .WithRequired(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<demand>()
                .HasOptional(e => e.apartment_dem)
                .WithRequired(e => e.demand);

            modelBuilder.Entity<demand>()
                .HasMany(e => e.deal)
                .WithRequired(e => e.demand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<demand>()
                .HasOptional(e => e.house_dem)
                .WithRequired(e => e.demand);

            modelBuilder.Entity<demand>()
                .HasOptional(e => e.land_dem)
                .WithRequired(e => e.demand);

            modelBuilder.Entity<_object>()
                .HasOptional(e => e.apartment)
                .WithRequired(e => e._object);

            modelBuilder.Entity<_object>()
                .HasOptional(e => e.house)
                .WithRequired(e => e._object);

            modelBuilder.Entity<_object>()
                .HasOptional(e => e.land)
                .WithRequired(e => e._object);

            modelBuilder.Entity<_object>()
                .HasMany(e => e.supply)
                .WithRequired(e => e._object)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<objecttype>()
                .HasMany(e => e.demand)
                .WithRequired(e => e.objecttype)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<supply>()
                .HasMany(e => e.deal)
                .WithRequired(e => e.supply)
                .WillCascadeOnDelete(false);
        }
    }
}
