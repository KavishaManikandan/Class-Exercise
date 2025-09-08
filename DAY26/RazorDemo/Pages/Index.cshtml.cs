using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorDemo.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; }  // Property binding

        public string GreetingMessage { get; set; }

        public void OnGet()
        {
            // Called on initial page load
        }

        public void OnPost()
        {
            // Called when form is submitted
            if (!string.IsNullOrEmpty(UserName))
            {
                GreetingMessage = $"Hello, {UserName}! Welcome to Razor Pages.";
            }
            else
            {
                GreetingMessage = "Please enter your name.";
            }
        }
    }
}
