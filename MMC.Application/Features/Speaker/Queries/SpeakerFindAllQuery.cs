using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Queries;

public record SpeakerFindAllQuery : IRequest<IEnumerable<SpeakerGetDTO>>;