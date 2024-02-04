using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MMC.WEB.Entities;
using MMC.WEB.Services;

namespace MMC.WEB.Pages.Themes;

public class IndexModel : PageModel
{
    private readonly ThemeService _service;
    public IndexModel(ThemeService service) => _service = service;




    [BindProperty]
    public Theme Theme { get; set; }
    public IEnumerable<Theme> Themes { get; private set; }




    public async Task OnGet()
        => Themes = await _service.FindAll();


    public async Task<IActionResult> OnPostCreate()
    {
        if (string.IsNullOrEmpty(Theme.Name))
        {
            ModelState.AddModelError("Theme.Name", "The field \"Name\" is required!");
            await OnGet();
            return Page();
        }

        await _service.Create(Theme);
        return RedirectToPage("/Themes/Index");
    }
}
