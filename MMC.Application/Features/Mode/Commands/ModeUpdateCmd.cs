using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Commands;

public record ModeUpdateCmd(int Id, string Name) : IRequest<ModeGetDTO>;