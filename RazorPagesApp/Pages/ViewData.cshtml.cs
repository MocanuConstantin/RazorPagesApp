using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class ViewDataModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Lista utilizatorilor";
            ViewData["People"] = new List<string> { "Tom", "Sam", "Bob" };
        }
    }
}
