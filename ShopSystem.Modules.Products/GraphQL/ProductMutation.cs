#nullable disable

using HotChocolate;
using MediatR;
using ShopSystem.Application.Features.Products.Commands;

namespace ShopSystem.Modules.Products.GraphQL;

public class ProductMutation
{
    public async Task<Guid> CreateProduct([Service] IMediator mediator, ProductCreateCommand command)
    {
        return await mediator.Send(command);
    }

    //public async Task<bool> UpdateProduct([Service] IMediator mediator, ProductUpdateCommand command)
    //{
    //    return await mediator.Send(command);
    //}

    //public async Task<bool> DeleteProduct([Service] IMediator mediator, Guid id)
    //{
    //    return await mediator.Send(new ProductDeleteCommand(id));
    //}
}
