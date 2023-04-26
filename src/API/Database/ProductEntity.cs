using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Database
{
    public class ProductEntity
    {
        public long Id { get; set; }
        public Guid ExternalId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
