using API.Handler;
using API.Model;
using API.Model.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleSoft.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductModel>> SearchAsync([FromQuery] string filterQ, [FromQuery] int? skip, [FromQuery] int? take, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id:guid}")]
        public async Task<ProductModel> GetByIdAsync([FromRoute] Guid id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<CreateProductResultModel> CreateAsync([FromBody] CreateProductModel model, CancellationToken ct)
        {
            var result = await _mediator.SendAsync(new CreateProductCommand
            {
                Code = model.Code,
                Name = model.Name,
                Price = model.Price
            }, ct);

            return new CreateProductResultModel
            {
                Id = result.Id
            };
        }

        [HttpPut("{id:guid}")]
        public async Task UpdateAsync([FromRoute] Guid id, [FromBody] UpdateProductModel model, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id:guid}")]
        public async Task DeleteAsync([FromRoute] Guid id, CancellationToken ct)
        {
            throw new NotImplementedException();
        }

    }
}
