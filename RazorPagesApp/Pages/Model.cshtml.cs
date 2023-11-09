using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace exper.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "";

        public void OnGet()
        {
            string name = Request.Query["name"];
            string age = Request.Query["age"];
            Message = $"Name: {name}  Age: {age}";
        }
    }
}
