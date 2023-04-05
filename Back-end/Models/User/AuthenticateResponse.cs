using Back_end.Common;
using Back_end.Entities;

namespace Back_end.Models.User
{
    public class AuthenticateResponse
    {

        public Guid Id { get; set; }
        public string? Username { get; set; }
        public Role Role { get; set; }
        public string Token { get; set; }

        public string? ImageURL { get; set; }

        public AuthenticateResponse(Entities.User user, string token)
        {
          
            Id = user.ID;
            Username = user.UserName;
            Role = user.Role;
            ImageURL = user.Image == null ? "" : user.Image.URL;
            Token = token;
        }
    }
}
