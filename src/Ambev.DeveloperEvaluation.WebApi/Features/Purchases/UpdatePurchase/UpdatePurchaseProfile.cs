using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;
using Ambev.DeveloperEvaluation.Application.Purchases.UpdatePurchase;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.UpdatePurchase;

/// <summary>
/// Profile for mapping between Application and API CreatePurchase responses
/// </summary>
public class UpdatePurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreatePurchase feature
    /// </summary>
    public UpdatePurchaseProfile()
    {
        CreateMap<UpdatePurchaseRequest, UpdatePurchaseCommand>();
        CreateMap<UpdatePurchaseResult, UpdatePurchaseResponse>();
    }
}
