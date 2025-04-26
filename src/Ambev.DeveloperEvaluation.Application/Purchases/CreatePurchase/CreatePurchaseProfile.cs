using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;

/// <summary>
/// Profile for mapping between Purchase entity and CreatePurchaseResponse
/// </summary>
public class CreatePurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreatePurchase operation
    /// </summary>
    public CreatePurchaseProfile()
    {
        CreateMap<CreatePurchaseCommand, Purchase>();
        CreateMap<Purchase, CreatePurchaseResult>();
    }
}
