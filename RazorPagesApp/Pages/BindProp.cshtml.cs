using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BindPropRazor.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true, Name = "id")]
        public string? FirstName { get; set; } = "default";
        [BindProperty(SupportsGet = true)]
        public Person? Maib { get; set; }

    }
    public record class Person(string Name, int Age);
}
