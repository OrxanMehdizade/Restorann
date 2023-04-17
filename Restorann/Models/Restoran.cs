using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restorann.Models
{
    public class Restoran : RestoranID
    {
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public Double? Price { get; set; }
        public string? ImagebackUrl { get; set; }


    }
}
