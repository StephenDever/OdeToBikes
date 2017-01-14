using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class ManufacturerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Info { get; set; }
        public int ManufacturerId { get; set; }
    }
}