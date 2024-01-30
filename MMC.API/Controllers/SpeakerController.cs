using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Speaker.Commands;
using MMC.Application.Features.Speaker.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SpeakerController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var speakers = await Mediator.Send(new SpeakerFindAllQuery());
        return Ok(speakers);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var speaker = await Mediator.Send(new SpeakerFindQuery(id));
        return speaker is null ? NotFound() : Ok(speaker);
    }

    [HttpPost]
    public async Task<IActionResult> Create(SpeakerCreateCmd cmd)
    {
        var speaker = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = speaker.Id }, speaker);
    }

    [HttpPut]
    public async Task<IActionResult> Update(SpeakerUpdateCmd cmd)
    {
        var speaker = await Mediator.Send(cmd);
        return Ok(speaker);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new SpeakerDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}