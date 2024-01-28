using MediatR;

namespace MMC.Application.Features.Theme.Commands;

public record ThemeDeleteCmd(int Id) : IRequest<bool>;