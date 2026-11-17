using System.ComponentModel.DataAnnotations;

namespace University_Explorer_Portal.Models;

public class StudentApplication
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public string Country { get; set; }
    public string University { get; set; }
    public string Course { get; set; }
    public string PersonalStatement { get; set; }
    
}