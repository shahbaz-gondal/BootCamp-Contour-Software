using System.ComponentModel.DataAnnotations;

namespace LoginForm_with_mvc.Models
{
    public class Login_RegisterModel
    {
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        public string Password { get; set; }
    }
}
