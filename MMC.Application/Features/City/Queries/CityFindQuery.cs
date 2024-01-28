using MediatR;
using MMC.Domain.DTOs;

namespace MMC.Application.Features.City.Queries;

public record CityFindQuery(int Id) : IRequest<CityGetDTO>;