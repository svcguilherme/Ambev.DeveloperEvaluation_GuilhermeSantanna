using AutoMapper;
using Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases.CreatePurchase;

/// <summary>
/// Profile for mapping between Application and API CreatePurchase responses
/// </summary>
public class CreatePurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreatePurchase feature
    /// </summary>
    public CreatePurchaseProfile()
    {
        CreateMap<CreatePurchaseRequest, CreatePurchaseCommand>();
        CreateMap<CreatePurchaseResult, CreatePurchaseResponse>();
    }
}
