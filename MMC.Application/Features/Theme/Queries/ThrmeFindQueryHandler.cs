using MediatR;
using MMC.Application.Features.City.Queries;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Queries;

public class ThemeFindQueryHandler : IRequestHandler<ThemeFindQuery, ThemeGetDTO>
{
    private readonly IUnitOfService _service;
    public ThemeFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<ThemeGetDTO> Handle(ThemeFindQuery request, CancellationToken cancellationToken)
    {
        var theme = await _service.ThemeService.FindAsync(request.Id);
        return theme;
    }
}