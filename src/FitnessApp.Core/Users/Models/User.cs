using Microsoft.AspNetCore.Identity;

namespace FitnessApp.Core.Users.Models;

public class User : IdentityUser
{
    public int? Age { get; set; }
    public string? Surname { get; set; }
}