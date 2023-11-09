using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class ModelArraysModel : PageModel
    {
        public string Message { get; private set; } = "";
        public void OnGet(string[] people0)
        {
            string rezultat = "";

            foreach (var celik in people0)
            {
                rezultat = $"{rezultat}{celik};";
            }
            Message = rezultat;
        }
    }
}
