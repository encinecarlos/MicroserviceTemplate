using Carlosencine.Application.Queries.Hello.Request;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Carlosencine.Application.Queries.Hello
{
    public class HelloQuery : IRequestHandler<HelloRequest, HelloResponse>
    {
        public Task<HelloResponse> Handle(HelloRequest request, CancellationToken cancellationToken)
        {
            var response = new HelloResponse
            {
                Message = $"Hello {request.Name}!"
            };

            return Task.FromResult(response);
        }
    }
}
