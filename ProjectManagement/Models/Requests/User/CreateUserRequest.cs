using System.ComponentModel.DataAnnotations;
using ProjectManagement.Entities.Enums;

namespace ProjectManagement.Models.Requests.User;

public class CreateUserRequest : BaseRequest
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }
    
    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
    
    [Required]
    [Display(Name = "Email")]
    public string Email { get; set; }
    
    [Required]
    [Display(Name = "Role")]
    public string Role { get; set; }
}