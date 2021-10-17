using Carlosencine.Application.Queries.Hello.Request;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;

namespace Carlosencine.Api.Controllers.V1
{
    [Route("v1/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        #region Properties
        
        public IMediator Mediator { get; }

        #endregion

        #region Constructor
        
        public HelloController(IMediator mediator)
        {
            Mediator = mediator;
        }

        #endregion


        #region Actions
        
        /// <summary>
        /// Show asingle greeting to the user
        /// </summary>
        /// <param name="request">The name of the user</param>
        /// <param name="cancellationToken"></param>
        /// <returns>the greeting to the user</returns>
        [Produces(MediaTypeNames.Application.Json)]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(HelloResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult> GetHello([FromBody] HelloRequest request, CancellationToken cancellationToken)
        {
            var response = await Mediator.Send(request, cancellationToken);

            return Ok(response);
        } 
        
        #endregion
    }
}
