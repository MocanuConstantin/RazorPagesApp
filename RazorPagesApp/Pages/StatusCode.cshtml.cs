using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class StatusCodeModel : PageModel
    {
        public IActionResult OnGet(string? name)
        {
            // ���� �������� name ������� � ��� �� ������ ������, �� �������� ��������� ��� 200
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
            // ���� ������ name ����� ��� ����� null
            if (string.IsNullOrEmpty(name)) return NotFound("Resource not found");
            return Page();
        }*/


    }
}
