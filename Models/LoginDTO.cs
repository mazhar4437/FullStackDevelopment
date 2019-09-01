using System.ComponentModel.DataAnnotations;

namespace Mazhar___Course_Project.Models
{
    public class LoginDTO
    {
       [Required]
        public string email { get; set; }
       [Required]
        public string password { get; set; }
    }
}