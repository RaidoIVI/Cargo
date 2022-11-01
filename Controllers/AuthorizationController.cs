using Microsoft.AspNetCore.Mvc;
using Storage;

namespace Cargo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AuthorizationController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            User user = new(value);
            if (user != null)
                if (user.Exists)
                    if (user.Enabled) return Ok();
                    else return BadRequest("Вход запрещен");
                else return BadRequest("Пользователь не существует");
            else return BadRequest("Сервер авторизации недоступен");
        }
    }
}
