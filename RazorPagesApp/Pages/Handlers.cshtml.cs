using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace RazorPagesApp.Pages
{
    public record class Persoana(string Name, int Age);

    public class HandlersModel : PageModel
    {
        List<Persoana> oameni = new()
        {
            new Persoana("Lionel Messi", 36),
            new Persoana("Cristiano Ronaldo",38),
            new Persoana("Zinedine Zidane",45),
            new Persoana("Neymar",31)
        };
        public List<Persoana> PersoaneAfisate { get; private set; } = new();

        public void OnGet()
        {
            PersoaneAfisate = oameni;
        }
            public void OnGetByName(string name)
        {
            PersoaneAfisate=oameni.Where(p => p.Name.Contains(name)).ToList();
        }
        public void OnGetByAge(int age)
        {
            PersoaneAfisate=oameni.Where(p =>p.Age==age).ToList();
        }
    }
}
