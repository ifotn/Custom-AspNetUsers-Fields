using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    // inherits from IdentityUser so we can add our own custom properties
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

    }
}
