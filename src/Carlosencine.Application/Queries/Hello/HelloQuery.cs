using Carlosencine.Application.Queries.Hello.Request;
using Flunt.Notifications;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Carlosencine.Application.Queries.Hello
{
    public class HelloQuery : Notifiable<Notification>, IRequestHandler<HelloRequest, HelloResponse>
    {
        public Task<HelloResponse> Handle(HelloRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                AddNotification("Validation", "Name cannot be Null.");
            }

            var response = new HelloResponse
            {
                Message = $"Hello {request.Name}!"
            };

            return Task.FromResult(response);
        }
    }
}
