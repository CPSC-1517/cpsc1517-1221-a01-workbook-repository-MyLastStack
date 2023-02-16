using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDemo.Models;

namespace RazorPagesDemo.Pages
{
    public class SimpleCalculatorModel : PageModel
    {
        [BindProperty]
        public Calculator CurrentCalculator { get; set; }

        public string? InfoMessage { get; private set; }
        public string? ErrorMessage { get; private set; }

        public void OnPostAdd()
        {
            InfoMessage = $"{CurrentCalculator.Num1} + {CurrentCalculator.Num2} = {CurrentCalculator.Add()}";
        }
        public void OnPostSubtract()
        {
            InfoMessage = $"{CurrentCalculator.Num1} + {CurrentCalculator} = {CurrentCalculator.Subtract()}";
        }
        public void OnPostMutiply()
        {
            InfoMessage = $"{CurrentCalculator.Num1} * {CurrentCalculator} = {CurrentCalculator.Multiply()}";
        }
        public void OnPostDivide()
        {
            InfoMessage = $"{CurrentCalculator.Num1} / {CurrentCalculator} = {CurrentCalculator.Divide()}";
        }
        public void OnGet()
        {
        }
    }
}
