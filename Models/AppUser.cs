using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NewAppMvc.Models
{
    public class AppUser : IdentityUser
    {
        [MaxLength(100)]
        public string? FullName { set; get; } = "hi";

        [MaxLength(255)]
        public string? Address { set; get; } = "hi";

        [DataType(DataType.Date)]
        public DateTime? Birthday { set; get; }
    }
}
