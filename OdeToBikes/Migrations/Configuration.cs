namespace OdeToBikes.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<OdeToBikes.Models.OdeToBikesDb>
    {
        public Configuration()
        {
            // set to true when setting up databases and making changes. 
            // Set to false when app is done and deployed and minimal changes will be made.
            AutomaticMigrationsEnabled = true;
            ContextKey = "OdeToBikes.Models.OdeToBikesDb";
        }

        protected override void Seed(OdeToBikes.Models.OdeToBikesDb context)
        {

            context.Manufacturers.AddOrUpdate(m => m.Name,
                new Manufacturer
                {
                    Name = "Specialized",
                    Location = "Morgan Hill, CA, USA",
                    Models = 
                        new List<ManufacturerModel>
                        {
                            new ManufacturerModel { Name = "Sirrus", Year = 1991, Info = "7-speed"}
                        }
                },
                new Manufacturer { Name = "Miyata", Location = "Tokyo, Japan" },
                new Manufacturer { Name = "Nishiki", Location = "Kobe, Japan" },
                new Manufacturer { Name = "Bridgestone", Location = "Tokyo, Japan" },
                new Manufacturer { Name = "Giant", Location = "Taichung, Taiwan" },
                new Manufacturer { Name = "Trek", Location = "Waterloo, WI, USA" },
                new Manufacturer { Name = "Cannondale", Location = "Wilton, CT, USA" },
                new Manufacturer { Name = "Colnago", Location = "Cambiago, Italy" },
                new Manufacturer { Name = "Peugeot", Location = "Sochaux, France" },
                new Manufacturer { Name = "Raleigh", Location = "Nottingham, UK" },
                new Manufacturer { Name = "Centurion", Location = "Camarillo, CA, USA" },
                new Manufacturer { Name = "Fuji", Location = "Japan" }
                );

        }
    }
}
