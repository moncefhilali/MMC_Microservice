using MediatR;

namespace MMC.Application.Features.Event.Commands;

public record EventDeleteCmd(Guid Id) : IRequest<bool>;