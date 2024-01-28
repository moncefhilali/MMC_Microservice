using MediatR;

namespace MMC.Application.Features.Mode.Commands;

public record ModeDeleteCmd(int Id) : IRequest<bool>;