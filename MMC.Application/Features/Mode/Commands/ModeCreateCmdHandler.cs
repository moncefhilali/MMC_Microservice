using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Commands;

public class ModeCreateCmdHandler : IRequestHandler<ModeCreateCmd, ModeGetDTO>
{
    private readonly IUnitOfService _service;
    public ModeCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<ModeGetDTO> Handle(ModeCreateCmd request, CancellationToken cancellationToken)
    {
        var modePostDTO = new ModePostDTO(request.name);
        var mode = await _service.ModeService.CreateAsync(modePostDTO);
        return mode;
    }
}