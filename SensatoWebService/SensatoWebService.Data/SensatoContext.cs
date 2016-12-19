namespace SensatoWebService.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SensatoContext : DbContext
    {
        public SensatoContext()
            : base("name=SensatoContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Hive> Hives { get; set; }

        public DbSet<Frame> Frames { get; set; }

        public DbSet<Measurment> Measurments { get; set; }
    }
}