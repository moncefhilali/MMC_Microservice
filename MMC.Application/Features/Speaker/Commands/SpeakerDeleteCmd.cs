using MediatR;

namespace MMC.Application.Features.Speaker.Commands;

public record SpeakerDeleteCmd(Guid Id) : IRequest<bool>;