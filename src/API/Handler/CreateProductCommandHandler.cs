using API.Database;
using Microsoft.EntityFrameworkCore;
using SimpleSoft.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.Handler
{
    public class CreateProductCommandHandler: ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        private readonly ApiDbContext _context;
        public CreateProductCommandHandler(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<CreateProductResult> HandleAsync(CreateProductCommand cmd, CancellationToken ct)
        {
            var products = _context.Set<ProductEntity>();

            if (await products.AnyAsync(p => p.Code == cmd.Code, ct))
            {
                throw new InvalidOperationException($"Product code '{cmd.Code}' already exists");
            }

            var externalId = Guid.NewGuid();
            await products.AddAsync(new ProductEntity
            {
                ExternalId = externalId,
                Code = cmd.Code,
                Name = cmd.Name,
                Price = cmd.Price
            }, ct);

            await _context.SaveChangesAsync(ct);

            return new CreateProductResult
            {
                Id = externalId
            };
        }
    }
}
