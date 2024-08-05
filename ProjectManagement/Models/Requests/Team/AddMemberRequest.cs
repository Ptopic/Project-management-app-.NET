using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Models.Requests.Team;

public class AddMemberRequest
{
    [DataType(DataType.Text)]
    [Display(Name = "Instructor")]
    public string? UserId { get; set; }
}