using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlosencine.Application.Queries.Hello.Request
{
    public class HelloRequest : IRequest<HelloResponse>
    {
        public string Name { get; set; }
    }
}
