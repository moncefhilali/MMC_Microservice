using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Partner.Commands;
using MMC.Application.Features.Partner.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PartnerController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var partners = await Mediator.Send(new PartnerFindAllQuery());
        return Ok(partners);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(Guid id)
    {
        var partner = await Mediator.Send(new PartnerFindQuery(id));
        return partner is null ? NotFound() : Ok(partner);
    }

    [HttpPost]
    public async Task<IActionResult> Create(PartnerCreateCmd cmd)
    {
        var partner = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = partner.Id }, partner);
    }

    [HttpPut]
    public async Task<IActionResult> Update(PartnerUpdateCmd cmd)
    {
        var partner = await Mediator.Send(cmd);
        return Ok(partner);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var success = await Mediator.Send(new PartnerDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}