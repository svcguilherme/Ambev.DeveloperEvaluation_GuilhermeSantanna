using AutoMapper;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Application.Purchases.UpdatePurchase;

namespace Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;

/// <summary>
/// Profile for mapping between Purchase entity and CreatePurchaseResponse
/// </summary>
public class UpdatePurchaseProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreatePurchase operation
    /// </summary>
    public UpdatePurchaseProfile()
    {
        CreateMap<UpdatePurchaseCommand, Purchase>();
        CreateMap<Purchase, UpdatePurchaseResult>();
    }
}
