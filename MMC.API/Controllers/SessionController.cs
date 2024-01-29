using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Session.Commands;
using MMC.Application.Features.Session.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var sessions = await Mediator.Send(new SessionFindAllQuery());
        return Ok(sessions);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var session = await Mediator.Send(new SessionFindQuery(id));
        return session is null ? NotFound() : Ok(session);
    }

    [HttpPost]
    public async Task<IActionResult> Create(SessionCreateCmd cmd)
    {
        var session = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = session.Id }, session);
    }

    [HttpPut]
    public async Task<IActionResult> Update(SessionUpdateCmd cmd)
    {
        var session = await Mediator.Send(cmd);
        return Ok(session);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new SessionDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}