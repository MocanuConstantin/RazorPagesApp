using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class PassingDependenciesModel : PageModel
    {
        public string? Message { get; private set; }

        public PassingDependenciesModel(ITimeService serviciuTimp)
        {
            Message = $"Timp: {serviciuTimp.Time}";
        }
    }
}
