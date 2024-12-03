using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Response;

namespace Shop.Domain.Commands.Handlers {
  public class CreateCustomerHandler : ICreateCustomerHandler {
    public CreateCustomerResponse Handle(CreateCustomerRequest request) {
      // verifica se o cliente já está cadastrado
      // valida os dados
      // insere o cliente
      // envia e-mail de boas vindas.
      return new CreateCustomerResponse
      {
        Id = Guid.NewGuid(),
        Name = "Lúcio Brito",
        Email = "lucio@email.com",
        Date = DateTime.Now 
      };
    }
  }
}