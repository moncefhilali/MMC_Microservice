using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Session.Commands;

public class SessionCreateCmdHandler : IRequestHandler<SessionCreateCmd, SessionGetDTO>
{
    private readonly IUnitOfService _service;
    public SessionCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<SessionGetDTO> Handle(SessionCreateCmd request, CancellationToken cancellationToken)
    {
        var sessionPostDTO = new SessionPostDTO
        (
            request.Name,
            request.NumPlace,
            request.Description,
            request.StartDate,
            request.EndDate,
            request.EventId,
            request.ModeId
        );

        var session = await _service.SessionService.CreateAsync(sessionPostDTO);
        return session;
    }
}