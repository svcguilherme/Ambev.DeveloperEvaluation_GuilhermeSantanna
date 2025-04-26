using MediatR;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Ambev.DeveloperEvaluation.WebApi.Common;
using Ambev.DeveloperEvaluation.WebApi.Features.Purchases.DeletePurchase;
using Ambev.DeveloperEvaluation.Application.Purchases.DeletePurchase;
using Ambev.DeveloperEvaluation.WebApi.Features.Purchases.GetPurchase;
using Ambev.DeveloperEvaluation.Application.Purchases.GetPurchase;
using Ambev.DeveloperEvaluation.WebApi.Features.Purchases.CreatePurchase;
using Ambev.DeveloperEvaluation.Application.Purchases.CreatePurchase;
using Ambev.DeveloperEvaluation.Application.Purchases.UpdatePurchase;
using Ambev.DeveloperEvaluation.WebApi.Features.Purchases.CreatePurchase;
using Ambev.DeveloperEvaluation.WebApi.Features.Purchases.UpdatePurchase;


namespace Ambev.DeveloperEvaluation.WebApi.Features.Purchases;

/// <summary>
/// Controller for managing purchase operations
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class PurchasesController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    /// <summary>
    /// Initializes a new instance of PurchasesController
    /// </summary>
    /// <param name="mediator">The mediator instance</param>
    /// <param name="mapper">The AutoMapper instance</param>
    public PurchasesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    /// <summary>
    /// Creates a new purchase
    /// </summary>
    /// <param name="request">The purchase creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created purchase details</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreatePurchaseResponse>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreatePurchase([FromBody] CreatePurchaseRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreatePurchaseRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<CreatePurchaseCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Created(string.Empty, new ApiResponseWithData<CreatePurchaseResponse>
        {
            Success = true,
            Message = "Purchase created successfully",
            Data = _mapper.Map<CreatePurchaseResponse>(response)
        });
    }


    /// <summary>
    /// Update a purchase
    /// </summary>
    /// <param name="request">The product creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The update product details</returns>
    [HttpPut]
    [ProducesResponseType(typeof(ApiResponseWithData<CreatePurchaseResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdatePurchase([FromBody] UpdatePurchaseRequest request, CancellationToken cancellationToken)
    {
        var validator = new UpdatePurchaseRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<UpdatePurchaseCommand>(request);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<UpdatePurchaseResponse>
        {
            Success = true,
            Message = "Purchase update successfully",
            Data = _mapper.Map<UpdatePurchaseResponse>(response)
        });
    }


    /// <summary>
    /// Retrieves a purchase by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the purchase</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The purchase details if found</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetPurchaseResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPurchase([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new GetPurchaseRequest { Id = id };
        var validator = new GetPurchaseRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<GetPurchaseCommand>(request.Id);
        var response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetPurchaseResponse>
        {
            Success = true,
            Message = "Purchase retrieved successfully",
            Data = _mapper.Map<GetPurchaseResponse>(response)
        });
    }

    /// <summary>
    /// Deletes a purchase by their ID
    /// </summary>
    /// <param name="id">The unique identifier of the purchase to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>Success response if the purchase was deleted</returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DeletePurchase([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new DeletePurchaseRequest { Id = id };
        var validator = new DeletePurchaseRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.Errors);

        var command = _mapper.Map<DeletePurchaseCommand>(request.Id);
        await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponse
        {
            Success = true,
            Message = "Purchase deleted successfully"
        });
    }
}
