using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NhlWebbApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Define an auto-inplemented property for username
        [BindProperty]
        public string Username { get; set; }
        // Define an auto-implemented property for feedback messages
        public string? InfoMessage { get; private set; }
        public void OnPost()
        {
            // Generate a lucky number between 1 and 0 (inclusive)
            // and send a feedback message with fomrat:
            // "Hello {username}. Your lucky number is {luckyNumber}"
            var rand = new Random();
            var randomNumber = rand.Next(1, 51);
            InfoMessage = $"Helllo {Username}. Your lucky number is {randomNumber}";

        }
        public void OnGet()
        {

        }
    }
}