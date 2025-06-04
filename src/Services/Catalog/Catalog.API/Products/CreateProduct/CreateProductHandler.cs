using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand
    (
        string Name, List<string> Categories, string Description, string ImageFile, decimal Price
    ) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        // Simulate product creation logic
        throw new NotImplementedException("Product creation logic is not implemented yet.");
    }

}
