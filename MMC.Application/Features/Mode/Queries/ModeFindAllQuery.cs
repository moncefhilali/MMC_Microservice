using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Mode.Queries;

public record ModeFindAllQuery : IRequest<IEnumerable<ModeGetDTO>>;