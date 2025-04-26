using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Purchases.GetPurchase;
/// <summary>
/// Profile for mapping between Purchase entity and GetPurchaseResponse
/// </summary>
public class GetPurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for GetPurchase operation
    /// </summary>
    public GetPurchaseProfile()
    {
        CreateMap<Purchase, GetPurchaseResult>();
    }
}
