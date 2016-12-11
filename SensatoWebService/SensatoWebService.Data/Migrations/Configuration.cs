namespace SensatoWebService.Data.Migrations
{
    using Models;
    using Models.Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SensatoDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SensatoDbContext context)
        {
            //var user = context.Users.First();

            //var hive = new Hive
            //{
            //    IsRemoved = false,
            //    Name = "асдасдасдасдад",
            //};

            //user.Hives.Add(hive);
            //context.SaveChanges();
        }
    }
}