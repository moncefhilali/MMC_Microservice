using MediatR;

namespace MMC.Application.Features.Partner.Commands;

public record PartnerDeleteCmd(Guid Id) : IRequest<bool>;