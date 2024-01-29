using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Sponsor.Queries;

public record SponsorFindAllQuery : IRequest<IEnumerable<SponsorGetDTO>>;