using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.Sponsor.Commands;

public record SponsorCreateCmd
(
    string Name,
    string? Description,
    string? LogoPath
) : IRequest<SponsorGetDTO>;