using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Queries;

public record PartnerFindAllQuery : IRequest<IEnumerable<PartnerGetDTO>>;