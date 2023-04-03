using Back_end.Common;
using Back_end.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Back_end.Models.User
{
    public class UserModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
       
        public Gender Gender { get; set; }

      
        public Role Role { get; set; }

        [RegularExpression(@"^[0-9]{10,11}$")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime LastModifyAt { get; set; }

        public string imageURL { get; set; } 

    }
}
