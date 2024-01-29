using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Sponsor.Commands;
using MMC.Application.Features.Sponsor.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SponsorController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var sponsors = await Mediator.Send(new SponsorFindAllQuery());
        return Ok(sponsors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var sponsor = await Mediator.Send(new SponsorFindQuery(id));
        return sponsor is null ? NotFound() : Ok(sponsor);
    }

    [HttpPost]
    public async Task<IActionResult> Create(SponsorCreateCmd cmd)
    {
        var sponsor = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = sponsor.Id }, sponsor);
    }

    [HttpPut]
    public async Task<IActionResult> Update(SponsorUpdateCmd cmd)
    {
        var sponsor = await Mediator.Send(cmd);
        return Ok(sponsor);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new SponsorDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}