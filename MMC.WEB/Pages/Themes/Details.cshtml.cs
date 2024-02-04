using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Themes;

public class DetailsModel : PageModel
{
    private readonly ThemeService _service;
    public DetailsModel(ThemeService service) => _service = service;




    [BindProperty]
    public Theme Theme { get; set; }




    public async Task OnGet(int id)
        => Theme = await _service.Find(id);


    public async Task<IActionResult> OnPostUpdate()
    {
        if (string.IsNullOrEmpty(Theme.Name) || !ModelState.IsValid)
        {
            ModelState.AddModelError("Theme.Name", "The field \"Name\" is required!");
            return Page();
        }

        await _service.Update(Theme.Id, Theme);
        return RedirectToPage("/Themes/Index");
    }


    public async Task<IActionResult> OnPostDelete()
    {
        await _service.Delete(Theme.Id);
        return RedirectToPage("/Themes/Index");
    }
}
