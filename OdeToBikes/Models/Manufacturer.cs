using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public virtual ICollection<ManufacturerModel> Models { get; set; }
    }
}