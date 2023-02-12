using Back_end.Authorization;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    using BCryptNet = BCrypt.Net.BCrypt;

    public interface IUserRespository
    {
        public Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        public Task<ICollection<User>> GetUsers();
        public Task<User> GetUser(string guidString);

    }
    public class UserRespository : IUserRespository
    {
        private readonly ParkingDbContext _dbContext;
        private readonly IJwtUtils _jwtUtils;
       

        public UserRespository(ParkingDbContext dbContext, IJwtUtils jwtUtils)
        {
            _dbContext = dbContext;
            _jwtUtils = jwtUtils;
           
        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            if (model.UserName == null) throw new AppException("Username is required");

            var user = await _dbContext.Users.FirstOrDefaultAsync(u=>u.UserName.Trim().Equals(model.UserName.Trim()));
            if (user == null || !BCryptNet.Verify(model.Password,user.HashPasword))
                throw new AppException("Username or password is incorrect");
            string token = _jwtUtils.GenerateToken(user);


            return new AuthenticateResponse(user,token);

        }


        public async Task<User> GetUser(string guidString)
        {
            return await _dbContext.Users.FirstAsync(u=>u.ID.ToString().ToUpper().Trim().
                Equals(guidString.ToUpper().Trim()            
                ));
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return await _dbContext.Users.ToListAsync();
        }
    }


}
