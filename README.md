# Balta IO

This repository is just source code of all balta io's courses and classes.

## Table of Contents

- [about CQRS](#about-cqrs)

### about CQRS

Video - **ASP.NET Core APIs: CQRS e Mediator | por André Baltieri**

- [link](https://www.youtube.com/watch?v=G0yi5PTzhLA)

#### Commands

- Handlers

A `handler` modifies the model values.

- Requests

A `request` handles the information from UI/Client.

- Responses

A `response` defines the structure needs to back for UI/Client.

#### MediatR

MediatR is a behavioral design pattern that abstracts and centralizes communication between components, promoting loose coupling

##### `IRequest<Response>`

The class that implements this interface becomes a `request` that MediatR will handle it. Must need to indicate a response type.

```cs
public class CreateCustomerRequest : IRequest<CreateCustomerResponse> 
{
  public string Name { get; set;}
  public string Email { get; set;}
}
```

##### `IRequestHandler<Request,Response>`

The class that implements this interface becomes a `request handler` that MediatR will handle it. Must need to indicate two generics. One for `request` and another for `response`.

```cs
public class CreateCustomerHandler : 
IRequestHandler<CreateCustomerRequest, CreateCustomerResponse> 
{
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
```
