using MediatR;

namespace MMC.Application.Features.Session.Commands;

public record SessionDeleteCmd(Guid Id) : IRequest<bool>;