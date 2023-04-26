using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model.Product
{
    public class CreateProductModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
