using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Session.Queries;

public class SessionFindQueryHandler : IRequestHandler<SessionFindQuery, SessionGetDTO>
{
    private readonly IUnitOfService _service;
    public SessionFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<SessionGetDTO> Handle(SessionFindQuery request, CancellationToken cancellationToken)
    {
        var session = await _service.SessionService.FindAsync(request.Id);
        return session;
    }
}