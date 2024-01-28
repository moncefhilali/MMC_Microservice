using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Queries;

public class ModeFindQueryHandler : IRequestHandler<ModeFindQuery, ModeGetDTO>
{
    private readonly IUnitOfService _service;
    public ModeFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<ModeGetDTO> Handle(ModeFindQuery request, CancellationToken cancellationToken)
    {
        var mode = await _service.ModeService.FindAsync(request.id);
        return mode;
    }
}
