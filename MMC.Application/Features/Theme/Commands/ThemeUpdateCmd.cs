using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Commands;

public record ThemeUpdateCmd(int Id, string Name) : IRequest<ThemeGetDTO>;