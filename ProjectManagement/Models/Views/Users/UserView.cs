using ProjectManagement.Entities.Enums;

namespace ProjectManagement.Models.Views.Users;

public class UserView : BaseView
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }
    
    public Roles Role { get; set; }
}