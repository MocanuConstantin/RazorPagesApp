using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class ReturnRazorModel : PageModel
    {
        public IActionResult OnGet()
        {
            return Content("Salut dev");
        }
    }
}
