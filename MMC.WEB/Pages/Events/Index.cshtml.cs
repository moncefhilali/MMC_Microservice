using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Events;

public class IndexModel : PageModel
{
    private readonly EventService _service;
    public IndexModel(EventService service) => _service = service;




    public IEnumerable<Event> Events { get; set; }
    public IEnumerable<City> Cities { get; private set; }
    public IEnumerable<Theme> Themes { get; private set; }




    public async Task OnGet()
    {
        Events = await _service.FindAll();
        Cities = await _service.FindAllCities();
        Themes = await _service.FindAllThemes();
    }
}
