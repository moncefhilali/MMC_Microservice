using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Theme.Commands;

public record ThemeCreateCmd(string Name) : IRequest<ThemeGetDTO>;