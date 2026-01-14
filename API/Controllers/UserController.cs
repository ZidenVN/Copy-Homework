using Application.Abtractions;
using Application.AppExceptions;
using Application.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController(IUserService service) : ControllerBase
    {
        private readonly IUserService _service = service;
        // controller mẫu thôi phải sửa lại á
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var user = await _service.GetByIdAsync(id) ?? throw new NotFoundException(Message.UserMessage.NotFound);
            return Ok(user);
        }
    }
}
