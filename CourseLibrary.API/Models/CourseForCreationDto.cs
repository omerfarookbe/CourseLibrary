using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models;

public class CourseForCreationDto
{
    [Required(ErrorMessage = "Title should not be blank")]
    [MaxLength(100, ErrorMessage = "Title should be less than 100 chars")]
    public string Title { get; set; } = string.Empty;
    [MaxLength(1500, ErrorMessage = "Description should be less than 1500 chars")]
    public string Description { get; set; } = string.Empty;
}

