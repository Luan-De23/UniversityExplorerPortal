using System.ComponentModel.DataAnnotations;

namespace University_Explorer_Portal.Models;

public class StudentApplication
{
    
    public int Id { get; set; }
    [Required(ErrorMessage = "You must enter a name for the student")]
    public string StudentName { get; set; }
    [EmailAddress(ErrorMessage = "You must enter a valid email address")]
    [Required(ErrorMessage = "You must enter a valid email address")]
    public string Email { get; set; }
    [Required(ErrorMessage = "You must enter your country")]
    public string Country { get; set; }
    [Required(ErrorMessage = "You must enter The University name")]
    public string University { get; set; }
    [Required(ErrorMessage = "You must enter the Course name")]
    public string Course { get; set; }
    public string PersonalStatement { get; set; }
    [Required(ErrorMessage = "Not Valid Date")]
    public DateTime? ApplicationDate { get; set; }
    
}