using SimpleSoft.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Handler
{
    public class CreateProductCommand: Command<CreateProductResult>
    {    
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
