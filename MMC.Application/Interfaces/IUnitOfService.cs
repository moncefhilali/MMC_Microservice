namespace MMC.Application.Interfaces;

public interface IUnitOfService
{
    ICityService CityService { get; }
    IEventService EventService { get; }
    IThemeService ThemeService { get; }
}