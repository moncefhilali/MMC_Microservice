using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Cities;

public class IndexModel : PageModel
{
    private readonly CityService _service;
    public IndexModel(CityService service) => _service = service;




    [BindProperty]
    public City City { get; set; }
    public IEnumerable<City> Cities { get; private set; }




    public async Task OnGet()
        => Cities = await _service.FindAll();


    public async Task<IActionResult> OnPostCreate()
    {
        if (string.IsNullOrEmpty(City.Name))
        {
            ModelState.AddModelError("City.Name", "The field \"Name\" is required!");
            await OnGet();
            return Page();
        }

        await _service.Create(City);
        return RedirectToPage("/Cities/Index");
    }
}
