using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToBikes.Models
{
    public class ManufacturerListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int CountOfModels { get; set; }
    }
}