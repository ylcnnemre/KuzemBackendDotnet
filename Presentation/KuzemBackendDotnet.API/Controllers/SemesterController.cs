using KuzemBackendDotnet.Application.Features.Commands.Semester.CreateSemester;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace KuzemBackendDotnet.API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SemesterController : Controller
    {
        private readonly IMediator _mediator;

        public SemesterController(IMediator mediator)
        {
                this._mediator = mediator;
        }

        [HttpPost("[action]")]
        public async Task<IActionResult>  Create([FromBody] CreateSemesterCommandRequest request )
        {
            var response=  await _mediator.Send(request);    
            return Ok(response);
        }
    }
}
