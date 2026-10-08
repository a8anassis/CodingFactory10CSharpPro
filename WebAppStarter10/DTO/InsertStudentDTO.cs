using System.ComponentModel.DataAnnotations;

namespace WebAppStarter10.DTO;

public record InsertStudentDTO
(
    [property: Required(ErrorMessage = "Firstname id required.")]
    [property: MinLength(1, ErrorMessage = "Firstname must be not empty.")]
    string? Firstname,

    [property: Required(ErrorMessage = "Lastname id required.")]
    [property: MinLength(1, ErrorMessage = "Lastname must be not empty.")]
    string? Lastname,

    int SelectedCityId
)
{
    public InsertStudentDTO() : this(default, default, default) 
    { 
    }
}
