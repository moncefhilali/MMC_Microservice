using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Commands;

public class ThemeCreateCmdHandler : IRequestHandler<ThemeCreateCmd, ThemeGetDTO>
{
    private readonly IUnitOfService _service;
    public ThemeCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ThemeGetDTO> Handle(ThemeCreateCmd request, CancellationToken cancellationToken)
    {
        var themePostDTO = new ThemePostDTO(request.Name);
        var theme = await _service.ThemeService.CreateAsync(themePostDTO);
        return theme;
    }
}