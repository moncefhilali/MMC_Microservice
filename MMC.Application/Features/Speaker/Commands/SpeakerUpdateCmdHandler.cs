using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Commands;

public class SpeakerUpdateCmdHandler : IRequestHandler<SpeakerUpdateCmd, SpeakerGetDTO>
{
    private readonly IUnitOfService _service;
    public SpeakerUpdateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<SpeakerGetDTO> Handle(SpeakerUpdateCmd request, CancellationToken cancellationToken)
    {
        var speakerPutDTO = new SpeakerPutDTO
        (
            request.Id,
            request.Firstname,
            request.Lastname,
            request.Email,
            request.Phone,
            request.Gender,
            request.PicturePath,
            request.MVP,
            request.MCT,
            request.Description,
            request.Facebook,
            request.Instagram,
            request.LinkedIn,
            request.TwitterX,
            request.UserId
        );

        var speaker = await _service.SpeakerService.UpdateAsync(speakerPutDTO);
        return speaker;
    }
}