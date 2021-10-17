using MediatR;

namespace Carlosencine.Application.Queries.Hello.Request
{
    public class HelloRequest : IRequest<HelloResponse>
    {
        public string Name { get; set; }
    }
}
