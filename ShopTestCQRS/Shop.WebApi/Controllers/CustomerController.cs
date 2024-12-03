using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handlers;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Controllers {
  [ApiController]
  public class CustomerController : ControllerBase 
  {
    private readonly IMediator _mediator;

    public CustomerController(IMediator mediator)
    {
      _mediator = mediator;
    }

    [Route("create-customer")]
    [HttpPost]
    public Task<CreateCustomerResponse> Create(
      // [FromServices] IMediator mediator,
      [FromBody] CreateCustomerRequest command
    ) {
      return _mediator.Send(command);
    }
  }
}