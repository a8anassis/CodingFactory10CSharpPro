using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace WebAppStarter10.Pages;

public class IndexModel : PageModel
{
    public string CurrentDay { get; set; }
    public void OnGet()     // IActionResult
    {
        CurrentDay = DateTime.Now.ToString("dddd", CultureInfo.InvariantCulture);
        //return Page();
    }
}
