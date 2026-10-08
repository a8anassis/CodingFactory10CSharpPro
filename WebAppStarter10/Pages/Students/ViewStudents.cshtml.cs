using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppStarter10.DTO;

namespace WebAppStarter10.Pages.Students
{
    public class ViewStudentsModel : PageModel
    {
        public List<StudentReadOnlyDTO> StudentReadOnlyDTOs { get; set; } = [];
        public void OnGet()
        {
            string? lastname = Request.Query["lastname"];

            StudentReadOnlyDTOs = string.IsNullOrEmpty(lastname)
                ? GetAllStudents()
                : [.. GetAllStudents().Where(s => s.Lastname == lastname)];
        }


        private List<StudentReadOnlyDTO> GetAllStudents()
        {
            return [
                new StudentReadOnlyDTO(1, "Γεώργιος", "Αλεξανδρής"),
                new StudentReadOnlyDTO(2, "Γεωργία", "Αλεξανδρή"),
                new StudentReadOnlyDTO(3, "Αθηνά", "Γεωργίου")
            ];
        }
    }
}
