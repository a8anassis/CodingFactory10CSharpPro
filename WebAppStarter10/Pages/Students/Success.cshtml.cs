using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppStarter10.Pages.Students
{
    public class SuccessModel : PageModel
    {
        public string? StudentName { get; set; }
        public void OnGet()
        {
            StudentName = TempData["StudentName"] as string ?? "";  // null-safe
        }
    }
}
