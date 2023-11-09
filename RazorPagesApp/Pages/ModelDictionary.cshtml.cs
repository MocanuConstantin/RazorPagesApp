using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class ModelDictionaryModel : PageModel
    {
        public string Message { get; private set; } = "";
        public void OnGet(Dictionary<string, string> items)
        {
            string result = "";
            foreach (var item in items)
            {
                result = $"{result} {item.Key} are capitala {item.Value}; ";
            }
            Message = result;
        }
    }
}
