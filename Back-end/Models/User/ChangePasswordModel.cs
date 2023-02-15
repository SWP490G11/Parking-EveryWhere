using System.ComponentModel.DataAnnotations;

namespace Back_end.Models.User
{
    public class ChangePasswordModel
    {
        
        public string OldPassword { get; set; }

        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Compare("NewPassword",ErrorMessage = "Not match with NewPassword")]
        public string ConfirmNewPassword { get; set; }
    }
}
