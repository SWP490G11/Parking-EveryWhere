using Back_end.Authorization;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Microsoft.EntityFrameworkCore;


namespace Back_end.Respository
{
    using AutoMapper;
    using Back_end.Common;
    using Microsoft.EntityFrameworkCore.Storage;
    using System.Linq.Expressions;
    using BCryptNet = BCrypt.Net.BCrypt;
    
    public interface IUserRespository
    {
        public Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        public Task<ICollection<User>> GetUsers();
        public Task<User> GetUser(string guidString);

        public Task<ICollection<User>> Paginate(int pageNo=1,int pageSize=5) ;

        public Task<bool> UsernameExisted(string username);

        public Task SortUser(DirectionOfSort typeOfSort,string factor);

        public Task Register(UserModel userModel);

        public Task Update(string id, UserModel userModel);



        public Task ChangePassword(ChangePasswordModel model);

        

    }
    public class UserRespository : IUserRespository
    {
        private readonly ParkingDbContext _dbContext;
        private readonly IJwtUtils _jwtUtils;
        private readonly ILogger<UserRespository> _logger;





        public UserRespository(ParkingDbContext dbContext,
            IJwtUtils jwtUtils,ILogger<UserRespository> logger
            )
        {
            _dbContext = dbContext;
            _dbContext.Database.EnsureCreated();
            _dbContext.Database.AutoSavepointsEnabled = true; 
            _jwtUtils = jwtUtils;
            
            _logger = logger;
            
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

        public Task ChangePassword(ChangePasswordModel model)
        {
            throw new NotImplementedException();
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

        public Task<ICollection<User>> Paginate(int pageNo = 1, int pageSize = 5)
        {
            throw new NotImplementedException();
        }

        public async Task Register(UserModel userModel)
        {
            try
            {
                var user = new User()
                {
                    UserName = userModel.UserName,
                    HashPasword = BCryptNet.HashPassword(userModel.Password),
                    Gender = userModel.Gender,
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    LastModifyAt = DateTime.Now,
                    PhoneNumber = userModel.PhoneNumber,
                    DateOfBirth = userModel.DateOfBirth,
                    Email = userModel.Email,
                    Role = userModel.Role,


                };

                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
              
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "An error occurred");
            }

              

                
           
            

               
            }

        public Task SortUser(DirectionOfSort typeOfSort,string factor)
        {
            throw new NotImplementedException();
        }

        public async Task Update(string id,UserModel userModel)
        {
            var updateUser = await GetUser(id);

            updateUser.UserName = userModel.UserName;
            updateUser.HashPasword = BCryptNet.HashPassword(userModel.Password);
            updateUser.Gender = userModel.Gender;
            updateUser.FirstName = userModel.FirstName;
            updateUser.LastName = userModel.LastName;
            updateUser.LastModifyAt = DateTime.Now;
            updateUser.PhoneNumber = userModel.PhoneNumber;
            updateUser.DateOfBirth = userModel.DateOfBirth;
            updateUser.Email = userModel.Email;
            updateUser.Role = userModel.Role;


          

             _dbContext.Users.Update(updateUser);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> UsernameExisted(string username)
        {
            if (await _dbContext.Users.AnyAsync(u=>u.UserName.Trim().Equals(username.Trim())))
            {
                return true;
            }

            return false;
        }
    }
    


}
