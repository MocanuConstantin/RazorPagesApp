using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesApp.Pages
{
    public class ModelObjectArraysModel : PageModel
    {
        public string Message { get; private set; } = "";
        public void OnGet(Person[] people)
        {
            string result = "";
            foreach (Person person in people)
            {
                result = $"{result} {person.Name} {person.Age}; ";
            }
            Message = result;
        }
    }
    public record class Person(string Name, int Age);
}
