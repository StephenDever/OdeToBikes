using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBikes.Controllers
{
    public class ManufacturerModel
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Info { get; set; }
    }
}