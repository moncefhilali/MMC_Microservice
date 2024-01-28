using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Commands;

public record ModeCreateCmd(string name) : IRequest<ModeGetDTO>;