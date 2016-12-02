namespace SensatoWebService.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Models;

    public partial class SensatoDbContext : DbContext
    {
        public SensatoDbContext()
            : base("SensatoDbContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Hive> Hives { get; set; }

        public DbSet<Frame> Frames { get; set; }

        public DbSet<Measurment> Measurments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
