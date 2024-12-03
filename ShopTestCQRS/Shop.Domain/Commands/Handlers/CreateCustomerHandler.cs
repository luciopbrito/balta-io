using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers {
  public class CreateCustomerHandler : 
  IRequestHandler<CreateCustomerRequest, CreateCustomerResponse> {
    public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
      // verifica se o cliente já está cadastrado
      // valida os dados
      // insere o cliente
      // envia e-mail de boas vindas.
      var result = new CreateCustomerResponse
      {
        Id = Guid.NewGuid(),
        Name = "Lúcio Brito",
        Email = "lucio@email.com",
        Date = DateTime.Now 
      };

      return Task.FromResult(result);
    }
  }
}