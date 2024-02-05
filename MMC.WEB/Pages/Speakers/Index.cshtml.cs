using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Speakers;

public class IndexModel : PageModel
{
    private readonly SpeakerService _service;
    public IndexModel(SpeakerService service) => _service = service;




    public IEnumerable<Speaker> Speakers { get; set; }




    public async Task OnGet()
    {
        Speakers = await _service.FindAll();
    }
}
