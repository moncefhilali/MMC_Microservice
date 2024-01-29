using MediatR;

namespace MMC.Application.Features.Sponsor.Commands;

public record SponsorDeleteCmd(Guid Id) : IRequest<bool>;