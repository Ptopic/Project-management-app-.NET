﻿using System.ComponentModel.DataAnnotations;

namespace ProjectManagement.Models.Requests.Team;

public class CreateTeamRequest : BaseRequest
{
    [Required]
    [Display(Name = "Name")]
    public string Name { get; set; }
}