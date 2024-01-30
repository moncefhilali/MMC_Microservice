using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Speaker.Queries;

public record SpeakerFindQuery(Guid Id) : IRequest<SpeakerGetDTO>;