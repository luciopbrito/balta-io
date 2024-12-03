using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Handlers;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Response;

namespace Shop.Controllers {
  [ApiController]
  public class CustomerController : ControllerBase 
  {
    [Route("create-customer")]
    [HttpPost]
    public CreateCustomerResponse
     Create(
      [FromServices] ICreateCustomerHandler handler,
      [FromBody] CreateCustomerRequest command
    ) {
      return handler.Handle(command);
    }
  }
}