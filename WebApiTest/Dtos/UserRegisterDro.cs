using System.ComponentModel.DataAnnotations;

namespace WebApiTest.Dtos
{
    public class UserRegisterDro
    {
        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "User name should have at least 1 and not more than 30 chars")]
        public string UserName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Password should have at least 4 and not more than 30 chars")]
        public string Password { get; set; }
    }
}
