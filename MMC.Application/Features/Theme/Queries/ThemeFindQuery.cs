using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Queries;

public record ThemeFindQuery(int Id) : IRequest<ThemeGetDTO>;