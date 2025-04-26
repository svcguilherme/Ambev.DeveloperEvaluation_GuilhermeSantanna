using Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Mappings;

public class CreatePurchaseRequestProfile : Profile
{
    public CreatePurchaseRequestProfile()
    {
        CreateMap<CreatePurchaseRequestProfile, CreatePurchaseCommand>();
    }
}