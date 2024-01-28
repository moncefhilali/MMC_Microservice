using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Mode.Commands;
using MMC.Application.Features.Mode.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModeController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var modes = await Mediator.Send(new ModeFindAllQuery());
        return Ok(modes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(int id)
    {
        var mode = await Mediator.Send(new ModeFindQuery(id));
        return mode is null ? NotFound() : Ok(mode);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ModeCreateCmd cmd)
    {
        var mode = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = mode.Id }, mode);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ModeUpdateCmd cmd)
    {
        var mode = await Mediator.Send(cmd);
        return Ok(mode);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await Mediator.Send(new ModeDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}