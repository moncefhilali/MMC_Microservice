using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Event.Commands;
using MMC.Application.Features.Event.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var events = await Mediator.Send(new EventFindAllQuery());
        return Ok(events);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var @event = await Mediator.Send(new EventFindQuery(id));
        return @event is null ? NotFound() : Ok(@event);
    }

    [HttpPost]
    public async Task<IActionResult> Create(EventCreateCmd cmd)
    {
        var @event = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = @event.Id }, @event);
    }

    [HttpPut]
    public async Task<IActionResult> Update(EventUpdateCmd cmd)
    {
        var @event = await Mediator.Send(cmd);
        return Ok(@event);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new EventDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}