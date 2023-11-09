using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class StatusCodeModel : PageModel
    {
        public IActionResult OnGet(string? name)
        {
            // если параметр name передан и это не пустая строка, то посылаем статусный код 200
            if (!string.IsNullOrEmpty(name)) return new OkResult();
            return Page();
        }
      
        
        /*public IActionResult OnGet(string? name)
        {
            if (name != "admin") return StatusCode(403);
            return Page();
        }
        */
      
        
        /* public IActionResult OnGet(string? name)
        {
            // если строка name пуста или равна null
            if (string.IsNullOrEmpty(name)) return NotFound("Resource not found");
            return Page();
        }*/


    }
}
