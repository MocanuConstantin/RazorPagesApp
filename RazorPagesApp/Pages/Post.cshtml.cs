using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace PostRazor.Pages
{
    [IgnoreAntiforgeryToken]
    public class IndexModel : PageModel
    {
        public string[] People { get; private set; } = Array.Empty<string>();

        public void OnPost(string[] oameni)
        {
            People = oameni;
        }

       /* public string Message { get; private set; } = "";

        public void OnGet()
        {
            Message = "Introduceti datele dvs.";
        }
        public void OnPost(Person sasha)
        {
            Message = $"Numele dvs. este {sasha.Name} si aveti {sasha.Age} ani";
        }
       */



        /*
        public void OnGet()
        {
            Message = "Introduceti numele dvs.";
        }
        public void OnPost(string username)
        {
            Message = $"Numele dvs. este {username}";
        }*/
    }
    public record class Person(string Name, int Age);


}
