using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.DeletePurchase;

/// <summary>
/// Profile for mapping DeletePurchase feature requests to commands
/// </summary>
public class DeletePurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for DeletePurchase feature
    /// </summary>
    public DeletePurchaseProfile()
    {
        CreateMap<Guid, Application.Purchases.DeletePurchase.DeletePurchaseCommand>()
            .ConstructUsing(id => new Application.Purchases.DeletePurchase.DeletePurchaseCommand(id));
    }
}
