using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Commands;

public record SpeakerUpdateCmd
(
    Guid Id,
    string Firstname,
    string Lastname,
    string Email,
    string Phone,
    char Gender,
    string PicturePath,
    bool? MVP,
    bool? MCT,
    string Description,
    string Facebook,
    string Instagram,
    string LinkedIn,
    string TwitterX,
    Guid UserId
) : IRequest<SpeakerGetDTO>;