using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Commands;

public class ModeUpdateCmdHandler : IRequestHandler<ModeUpdateCmd, ModeGetDTO>
{
    private readonly IUnitOfService _service;
    public ModeUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ModeGetDTO> Handle(ModeUpdateCmd request, CancellationToken cancellationToken)
    {
        var modePutDTO = new ModePutDTO(request.Id, request.Name);
        var mode = await _service.ModeService.UpdateAsync(modePutDTO);
        return mode;
    }
}