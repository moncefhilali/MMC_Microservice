using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.User.Commands;
using MMC.Application.Features.User.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var users = await Mediator.Send(new UserFindAllQuery());
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var user = await Mediator.Send(new UserFindQuery(id));
        return user is null ? NotFound() : Ok(user);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new UserDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}