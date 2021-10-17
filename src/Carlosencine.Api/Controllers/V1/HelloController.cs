using Carlosencine.Application.Queries.Hello.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Carlosencine.Api.Controllers.V1
{
    [Route("v1/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        public IMediator Mediator { get; }

        public HelloController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> GetHello([FromBody] HelloRequest request, CancellationToken cancellationToken)
        {
            var response = await Mediator.Send(request, cancellationToken);

            return Ok(response);
        }
    }
}
