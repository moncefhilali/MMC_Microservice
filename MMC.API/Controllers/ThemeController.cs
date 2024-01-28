using Microsoft.AspNetCore.Mvc;
using MMC.Application.Features.Theme.Commands;
using MMC.Application.Features.Theme.Queries;

namespace MMC.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ThemeController : ApiControllerBase
{
    [HttpGet]
    public async Task<IActionResult> FindAll()
    {
        var themes = await Mediator.Send(new ThemeFindAllQuery());
        return Ok(themes);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Find(int id)
    {
        var theme = await Mediator.Send(new ThemeFindQuery(id));
        return theme is null ? NotFound() : Ok(theme);
    }

    [HttpPost]
    public async Task<IActionResult> Create(ThemeCreateCmd cmd)
    {
        var theme = await Mediator.Send(cmd);
        return CreatedAtAction(nameof(Find), new { id = theme.Id }, theme);
    }

    [HttpPut]
    public async Task<IActionResult> Update(ThemeUpdateCmd cmd)
    {
        var theme = await Mediator.Send(cmd);
        return Ok(theme);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var success = await Mediator.Send(new ThemeDeleteCmd(id));
        return success ? Ok(success) : NotFound();
    }
}