namespace SensatoWebService.Data
{
    using System.Data.Entity;
    using Models;

    public partial class SensatoDBContext : DbContext
    {
        public SensatoDBContext()
            : base("name=SensatoContext")
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
