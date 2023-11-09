using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RouteParametersRazor.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Age { get; set; }

        public void OnGet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
