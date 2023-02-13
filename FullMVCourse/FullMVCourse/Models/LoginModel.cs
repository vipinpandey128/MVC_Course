using System.ComponentModel.DataAnnotations;

namespace FullMVCourse
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(50)]
        public string? Username { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [MaxLength(15)]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
