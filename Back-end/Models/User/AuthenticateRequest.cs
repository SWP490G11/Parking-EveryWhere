using System.ComponentModel.DataAnnotations;

namespace Back_end.Models.User
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
