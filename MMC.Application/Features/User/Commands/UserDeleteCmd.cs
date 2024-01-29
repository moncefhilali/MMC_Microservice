using MediatR;

namespace MMC.Application.Features.User.Commands;

public record UserDeleteCmd(Guid Id) : IRequest<bool>;