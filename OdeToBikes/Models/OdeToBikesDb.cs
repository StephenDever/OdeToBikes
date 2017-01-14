using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class OdeToBikesDb : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ManufacturerModel> Models { get; set; }
    }
}