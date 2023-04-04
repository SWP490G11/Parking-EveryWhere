using Back_end.Common;
using System.ComponentModel.DataAnnotations;

namespace Back_end.Models.User
{
    public class UpdateModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Gender Gender { get; set; }

        [RegularExpression(@"^[0-9]{10,11}$")]
        public string PhoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime LastModifyAt { get; set; }

        public string ImageURL { get; set; }
    }
}
