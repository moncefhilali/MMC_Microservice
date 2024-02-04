using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Cities;

public class DetailsModel : PageModel
{
    private readonly CityService _service;
    public DetailsModel(CityService service) => _service = service;




    [BindProperty]
    public City City { get; set; }




    public async Task OnGet(int id)
        => City = await _service.Find(id);


    public async Task<IActionResult> OnPostUpdate()
    {
        if (string.IsNullOrEmpty(City.Name) || !ModelState.IsValid)
        {
            ModelState.AddModelError("City.Name", "The field \"Name\" is required!");
            return Page();
        }

        await _service.Update(City.Id, City);
        return RedirectToPage("/Cities/Index");
    }


    public async Task<IActionResult> OnPostDelete()
    {
        await _service.Delete(City.Id);
        return RedirectToPage("/Cities/Index");
    }
}
