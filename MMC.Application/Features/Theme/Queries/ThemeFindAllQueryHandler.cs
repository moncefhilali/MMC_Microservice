using MediatR;
using MMC.Application.Features.City.Queries;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Queries;

public class ThemeFindAllQueryHandler : IRequestHandler<ThemeFindAllQuery, IEnumerable<ThemeGetDTO>>
{
    private readonly IUnitOfService _service;
    public ThemeFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<ThemeGetDTO>> Handle(ThemeFindAllQuery request, CancellationToken cancellationToken)
    {
        var themes = await _service.ThemeService.FindAllAsync();
        return themes;
    }
}