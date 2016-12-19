namespace SensatoWebService.Data.Migrations
{
    using Models;
    using Models.Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SensatoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SensatoContext context)
        {
            if (!context.Users.Any())
            {
                User user = new User
                {
                    Username = "FirstUser",
                    Password = "123",
                    IsDisabled = false,
                    IsLogged = false,
                    Role = RoleType.User,
                    Hives = new List<Hive>
                {
                    new Hive
                    {
                        Name = "FirstHive",
                        IsRemoved = false,
                        Frames = new List<Frame>
                        {
                            new Frame
                            {
                                Position = 1,
                                IsRemoved = false
                            },
                            new Frame
                            {
                                Position = 5,
                                IsRemoved = false
                            },
                            new Frame
                            {
                                Position = 8,
                                IsRemoved = false
                            },
                        }
                    }
                }
                };

                var frame = user.Hives.First().Frames.First();
                for (int i = 0; i < 700; i++)
                {
                    Measurment measurment = new Measurment
                    {
                        FirstSensorTemp = 15,
                        SecondSensorTemp = 17,
                        ThirdSensorTemp = 20,
                        DateTimeOfMeasurment = DateTime.Now.AddHours(1),
                        IsDeleted = false,
                    };

                    frame.Measurments.Add(measurment);
                }

                context.Users.Add(user);
                context.SaveChanges();
            }
        }
    }
}
