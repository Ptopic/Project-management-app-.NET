using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Models.Requests.Project;

public class CreateProjectRequest: BaseRequest
{
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }
    
    [Required]
    [Display(Name = "Key")]
    public string Key { get; set; }
    
    [Display(Name = "Description")]
    public string? Description { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "Start Date")]
    public DateTime StartDate { get; set; }
    
    [Required]
    [DataType(DataType.Date)]
    [Display(Name = "End Date")]
    public DateTime EndDate { get; set; }
    
    [Required]
    [DataType(DataType.Text)]
    [Display(Name = "Owner")]
    public string ManagerId { get; set; }
    
    [Required]
    [DataType(DataType.Text)]
    [Display(Name = "Team")]
    public string TeamId { get; set; }
}