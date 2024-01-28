using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Queries;

public class ModeFindAllQueryHandler : IRequestHandler<ModeFindAllQuery, IEnumerable<ModeGetDTO>>
{
    private readonly IUnitOfService _service;
    public ModeFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<ModeGetDTO>> Handle(ModeFindAllQuery request, CancellationToken cancellationToken)
    {
        var modes = await _service.ModeService.FindAllAsync();
        return modes;
    }
}