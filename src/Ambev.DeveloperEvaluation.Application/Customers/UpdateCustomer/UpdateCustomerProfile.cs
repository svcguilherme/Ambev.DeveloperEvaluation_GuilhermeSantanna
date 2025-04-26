using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Customers.UpdateCustomer;

/// <summary>
/// Profile for mapping between Customer entity and CreateCustomerResponse
/// </summary>
public class UpdateCustomerProfile : Profile
{
    /// <summary>
    /// Initializes the mappings for CreateUser operation
    /// </summary>
    public  UpdateCustomerProfile()
    {
        CreateMap<UpdateCustomerCommand, Customer>();
        CreateMap<Customer, UpdateCustomerResult>();
    }
}
