using MediatR;
using MMC.Application.Interfaces;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Commands;

public class SpeakerCreateCmdHandler : IRequestHandler<SpeakerCreateCmd, SpeakerGetDTO>
{
    private readonly IUnitOfService _service;
    public SpeakerCreateCmdHandler(IUnitOfService service) => _service = service;




    public async Task<SpeakerGetDTO> Handle(SpeakerCreateCmd request, CancellationToken cancellationToken)
    {
        var speakerPostDTO = new SpeakerPostDTO
        (
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

        var speaker = await _service.SpeakerService.CreateAsync(speakerPostDTO);
        return speaker;
    }
}