using MediatR;

namespace MMC.Application.Features.City.Commands;

public record CityDeleteCmd(int Id) : IRequest<bool>;