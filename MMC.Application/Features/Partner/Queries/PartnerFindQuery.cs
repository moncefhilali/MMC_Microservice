using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Queries;

public record PartnerFindQuery(Guid Id) : IRequest<PartnerGetDTO>;