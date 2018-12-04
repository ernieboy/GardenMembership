using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GardenMembership.UI.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet()
        {
            return new RedirectToPageResult("Baskets/Index");
        }
    }
}
