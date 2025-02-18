#nullable disable

using MediatR;
using ShopSystem.Application.Interfaces;
using ShopSystem.Domain.Entities;
using ShopSystem.Domain.ValueObjects;

namespace ShopSystem.Application.Features.Products.Commands;

public record ProductCreateCommand(string Name, string Description, decimal Price, string Currency, int Stock) : IRequest<Guid>;

public class ProductCreateCommandHandler : IRequestHandler<ProductCreateCommand, Guid>
{
    private readonly IProductRepository _repository;

    public ProductCreateCommandHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(ProductCreateCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Description, new Money(request.Price, request.Currency), request.Stock);
        await _repository.AddAsync(product);
        return product.Id;
    }
}
