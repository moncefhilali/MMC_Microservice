using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Queries;

public class SpeakerFindQueryHandler : IRequestHandler<SpeakerFindQuery, SpeakerGetDTO>
{
    private readonly IUnitOfService _service;
    public SpeakerFindQueryHandler(IUnitOfService service) => _service = service;




    public async Task<SpeakerGetDTO> Handle(SpeakerFindQuery request, CancellationToken cancellationToken)
    {
        var speaker = await _service.SpeakerService.FindAsync(request.Id);
        return speaker;
    }
}