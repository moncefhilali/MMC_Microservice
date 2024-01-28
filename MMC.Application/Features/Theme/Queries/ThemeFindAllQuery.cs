using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Queries;

public record ThemeFindAllQuery : IRequest<IEnumerable<ThemeGetDTO>>;