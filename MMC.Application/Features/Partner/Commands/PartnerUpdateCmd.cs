using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Partner.Commands;

public record PartnerUpdateCmd
(
    Guid Id,
    string Name,
    string? Description,
    string? LogoPath
) : IRequest<PartnerGetDTO>;