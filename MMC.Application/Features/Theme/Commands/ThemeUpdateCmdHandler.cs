using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Commands;

public class ThemeUpdateCmdHandler : IRequestHandler<ThemeUpdateCmd, ThemeGetDTO>
{
    private readonly IUnitOfService _service;
    public ThemeUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ThemeGetDTO> Handle(ThemeUpdateCmd request, CancellationToken cancellationToken)
    {
        var themePutDTO = new ThemePutDTO(request.Id, request.Name);
        var theme = await _service.ThemeService.UpdateAsync(themePutDTO);
        return theme;
    }
}