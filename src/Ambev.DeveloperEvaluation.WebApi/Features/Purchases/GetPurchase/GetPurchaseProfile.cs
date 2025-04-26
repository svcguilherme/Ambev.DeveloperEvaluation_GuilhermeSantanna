using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.GetPurchase;


/// <summary>
/// Profile for mapping GetPurchase feature requests to commands
/// </summary>
public class GetPurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetPurchase feature
    /// </summary>
    public GetPurchaseProfile()
    {
        CreateMap<Guid, Application.Purchases.GetPurchase.GetPurchaseCommand>()
            .ConstructUsing(id => new Application.Purchases.GetPurchase.GetPurchaseCommand(id));
    }
}
