using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Response;

namespace Shop.Domain.Commands.Handlers {
  public interface ICreateCustomerHandler {
    public CreateCustomerResponse Handle(CreateCustomerRequest request);
  }
}