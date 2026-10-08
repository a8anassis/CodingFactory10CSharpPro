using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppStarter10.DTO;
using WebAppStarter10.Model;

namespace WebAppStarter10.Pages.Students;

public class InsertModel : PageModel
{
    [BindProperty]
    public InsertStudentDTO InsertStudentDTO { get; set; } = new();
    public StudentReadOnlyDTO? StudentReadOnlyDTO { get; set; }
    public SelectList? Cities { get; set; }
   
    public void OnGet()
    {
        LoadCities();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            LoadCities();
            return Page();
        }

        // Service call
        StudentReadOnlyDTO = new StudentReadOnlyDTO(1, InsertStudentDTO.Firstname, InsertStudentDTO.Lastname);

        TempData["StudentName"] = $"{InsertStudentDTO.Firstname}, {InsertStudentDTO.Lastname}";

        // Post-Redirect-Get pattern
        return RedirectToPage("/Students/Success");
    }

    private void LoadCities()
    {
        Cities = new SelectList(new List<City>()
        {
            new City() { Id = 1, Name = "Αθήνα"},
            new City() { Id = 2, Name = "Πάτρα"},
            new City() { Id = 3, Name = "Ηράκλειο"},
            new City() { Id = 4, Name = "Δράμα"},
            new City() { Id = 5, Name = "Χανιά"}
        }.OrderBy(c => c.Name), nameof(City.Id), nameof(City.Name));
    }
}
