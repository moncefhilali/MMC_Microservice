using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Queries;

public class SpeakerFindAllQueryHandler : IRequestHandler<SpeakerFindAllQuery, IEnumerable<SpeakerGetDTO>>
{
    private readonly IUnitOfService _service;
    public SpeakerFindAllQueryHandler(IUnitOfService service) => _service = service;




    public async Task<IEnumerable<SpeakerGetDTO>> Handle(SpeakerFindAllQuery request, CancellationToken cancellationToken)
    {
        var speakers = await _service.SpeakerService.FindAllAsync();
        return speakers;
    }
}