using HelloWorld.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloWorld.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public int firstNumber { get; set; }
        public int secondNumber { get; set; }
        public int Total { get; set; }
        private readonly Calculator calculator;

        public IndexModel(Calculator injectedCalculator)
        {
            calculator = injectedCalculator;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            calculator.FirstNumber = firstNumber;
            calculator.SecondNumber = secondNumber;
            calculator.Add();
            Total = calculator.Total;
        }
    }
}
