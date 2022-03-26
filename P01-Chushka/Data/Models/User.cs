using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace P01_Chushka.Data.Models
{
    public class User: IdentityUser
    {
        [Required]
        [MaxLength(100)]
        [Display(Name ="Full name")]
        public string FullName { get; set; }
    }
}
