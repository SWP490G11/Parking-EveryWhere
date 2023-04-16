using Back_end.Authorization;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models.User;
using Microsoft.EntityFrameworkCore;


namespace Back_end.Respository
{

    using Back_end.Common;
    using System;
    using System.Text.RegularExpressions;
    using BCryptNet = BCrypt.Net.BCrypt;

    public interface IUserRespository
    {

        public Task<AuthenticateResponse> Authenticate(AuthenticateRequest model);
        public Task<ICollection<User>> GetUsers();
        public Task<User> GetUser(string guidString);

        public Task<ICollection<User>> Paginate(int pageNo = 1, int pageSize = 5);

        public bool UsernameExisted(string username);

        public Task SortUser(DirectionOfSort typeOfSort, string factor);

        public void Register(UserModel userModel);

        public Task Update(string id, UpdateModel userModel);

        public Task DisableOrActiveUser(string id);

        public Task<ICollection<User>> GetUserByUserNames(string username);

        public Task ChangePassword(string id, ChangePasswordModel model);


        public Task<ICollection<User>> GetParkingManagers();


        public Task<User> RegisterForParkingManager(PMModel userModel);



    }
    public class UserRespository : IUserRespository
    {
        private readonly ParkingDbContext _dbContext;
        private readonly IJwtUtils _jwtUtils;
        private readonly IImageRepository _imageRepository;



        public UserRespository(ParkingDbContext dbContext,
            IJwtUtils jwtUtils, IImageRepository imageRepository
            )
        {
            _dbContext = dbContext;
            _dbContext.Database.AutoSavepointsEnabled = true;
            _jwtUtils = jwtUtils;
            _imageRepository = imageRepository;


        }

        public async Task<AuthenticateResponse> Authenticate(AuthenticateRequest model)
        {
            if (model.UserName == null) throw new AppException("Username is required");
            if (model.UserName == null) throw new AppException("Password is required");


            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.UserName.Trim().Equals(model.UserName.Trim()));
            if (user == null || !BCryptNet.Verify(model.Password, user.HashPassword))
                throw new AppException("Username or password is incorrect");
            if (user.IsDisable) throw new AppException("User have been disabled");

            string token = _jwtUtils.GenerateToken(user);


            return new AuthenticateResponse(user, token);

        }

        public async Task ChangePassword(string userid, ChangePasswordModel model)
        {

            if (string.IsNullOrEmpty(userid) || String.IsNullOrEmpty(model.NewPassword) ||
            string.IsNullOrEmpty(model.OldPassword)) throw new ArgumentNullException("Null some field");

            var currentUser = await GetUser(userid);
            if (currentUser == null) throw new ArgumentNullException(nameof(currentUser));
            if (!BCryptNet.Verify(model.OldPassword, currentUser.HashPassword)) throw new AppException("Your password is incorrect");
            if (!model.NewPassword.Trim().Equals(model.ConfirmNewPassword.Trim())) throw new AppException("Comfirmpassword not match");

            if (!CheckChangePwd(model.NewPassword))
            {
                throw new AppException("Password should be at least 8 characters and contain at least one number and have a mixture of uppercase and lowercase letters");

            }
            else
            {


                currentUser.HashPassword = BCryptNet.HashPassword(model.NewPassword);
                currentUser.LastModifyAt = DateTime.Now;
                _dbContext.Users.Update(currentUser);
                await _dbContext.SaveChangesAsync();
            }


        }


        private bool CheckChangePwd(string newpwd)
        {
            Regex rgx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
            if (rgx.IsMatch(newpwd))
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public async Task DisableOrActiveUser(string id)
        {


            var currentUser = await GetUser(id);
            currentUser.IsDisable = !currentUser.IsDisable;

            _dbContext.Users.Update(currentUser);
            await _dbContext.SaveChangesAsync();





        }

        public Task<ICollection<User>> GetParkingManagers()
        {
            throw new NotImplementedException();
        }


        public async Task<User> GetUser(string guidString)
        {
            return await _dbContext.Users
                .Include(u => u.Parkings)
                .Include(u => u.Parkings).ThenInclude(p => p.Requests)
                .Include(u => u.Parkings).ThenInclude(p => p.ParkingManagers)
                .Include(u => u.Parkings).ThenInclude(p => p.Images)
                .Include(u => u.Parkings).ThenInclude(p => p.Feedbacks)
                .Include(u => u.Parkings).ThenInclude(p => p.Slots)
                .Include(u => u.Parkings).ThenInclude(p => p.Slots)
                  .Include(u => u.Parkings).ThenInclude(p => p.Slots)
                   .Include(u => u.Parkings).ThenInclude(p => p.Slots).ThenInclude(s=>s.ParkingDetail)
                 .Include(u => u.Parking)
                .Include(u => u.Parking).ThenInclude(p => p.Requests)
                .Include(u => u.Parking).ThenInclude(p => p.ParkingManagers)
                .Include(u => u.Parking).ThenInclude(p => p.Images)
                .Include(u => u.Parking).ThenInclude(p => p.Feedbacks)
                .Include(u => u.Parking).ThenInclude(p => p.Slots)
                .Include(u => u.Image).ThenInclude(i => i.User)
                .Include(u => u.Image).ThenInclude(i => i.Parking)
                .Include(u => u.Image).ThenInclude(i => i.Feedback)
                 .Include(u => u.Cars).ThenInclude(c => c.CarModel)
                 .Include(u => u.Cars).ThenInclude(c=>c.ParkingDetails)
                 .Include(u => u.MembershipPackage).ThenInclude(m => m.SubcribeBy)
                 .Include(u => u.Transaction)
                 .Include(u=>u.Requests)
                 .Include(u=>u.Requests).ThenInclude(r=>r.Parking)
                 .Include(u => u.Feedbacks).ThenInclude(f=>f.Images)
                  .Include(u => u.Feedbacks).ThenInclude(f => f.Parking)
                  .Include(u=>u.Parking).ThenInclude(p=>p.Slots)
                .FirstOrDefaultAsync(u => u.ID.ToString().ToUpper().Trim().
                Equals(guidString.ToUpper().Trim()
                ));

        }

        public async Task<ICollection<User>> GetUserByUserNames(string username)
        {
            return await _dbContext.Users.Include(u => u.Parkings)
                .ThenInclude(p => p.Slots).Include(u => u.Parkings)
                .Include(p => p.Parking)
                .ThenInclude(p => p.ParkingManagers)
                 .Include(u => u.Parking).ThenInclude(p => p.Feedbacks)
                .Include(u => u.MembershipPackage)
                .Include(u => u.Cars).ThenInclude(c => c.CarModel)
                .Include(u => u.Requests).
                Include(u => u.Feedbacks)
                .Include(u => u.Image).
                Include(u => u.Parkings).ThenInclude(p => p.Requests)
                .Include(u => u.Parkings).ThenInclude(p => p.Images)
                .Where(u => u.UserName.ToLower()
                .Contains(username.ToLower().Trim())).ToListAsync();
        }

        public async Task<ICollection<User>> GetUsers()
        {
            var users = await _dbContext.Users.Include(u => u.Parkings).ThenInclude(p => p.Slots)
                .Include(u => u.MembershipPackage)
                .Include(u => u.Parking).ToListAsync();

            return users;

        }

        public async Task<ICollection<User>> Paginate(int pageNo = 1, int pageSize = 5)
        {

            return await _dbContext.Users.Skip((pageNo - 1) * pageSize).Take(pageSize).ToListAsync();
        }

        public void Register(UserModel userModel)
        {


            var user = new User()
            {
                UserName = userModel.UserName,
                HashPassword = BCryptNet.HashPassword(userModel.Password),
                Gender = userModel.Gender,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                LastModifyAt = DateTime.Now,
                PhoneNumber = userModel.PhoneNumber,
                DateOfBirth = userModel.DateOfBirth,
                Email = userModel.Email,
                Role = userModel.Role,
                Parkings = new List<Parking>(),
                IsDisable = false,


            };

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();


            var image = new Image()
            {
                URL = userModel.imageURL,
                User = user,
                UserID = user.ID
            };

            user.Image = image;


            _imageRepository.AddAsync(image);







        }

        public Task SortUser(DirectionOfSort typeOfSort, string factor)
        {
            throw new NotImplementedException();
        }

        public async Task Update(string id, UpdateModel userModel)
        {

            var updateUser = await GetUser(id);
            updateUser.Gender = userModel.Gender;
            updateUser.FirstName = userModel.FirstName;
            updateUser.LastName = userModel.LastName;
            updateUser.LastModifyAt = DateTime.Now;
            updateUser.PhoneNumber = userModel.PhoneNumber;
            updateUser.DateOfBirth = userModel.DateOfBirth;
            updateUser.Email = userModel.Email;

            var image = updateUser.Image;
            if (image == null)
            {
                image = new Image()
                {
                    URL = userModel.ImageURL,
                    User = updateUser
                };
                updateUser.Image = image;
                _imageRepository.AddAsync(image);
            }
            else
            {
                image.URL = userModel.ImageURL;
                _imageRepository.UpdateAsync(image);

            }
            _dbContext.Users.Update(updateUser);
            _dbContext.SaveChanges(true);
        }

        public bool UsernameExisted(string username)
        {
            if (_dbContext.Users.Any(u => u.UserName.Trim().Equals(username.Trim())))
            {
                return true;
            }

            return false;
        }

        public async Task<User> RegisterForParkingManager(PMModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.ParkingID)) throw new ArgumentNullException();
            var parking = await _dbContext.Parkings.Include(p => p.ParkingManagers).FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(userModel.ParkingID.ToUpper().Trim()
                ));
            if (parking.ParkingManagers == null) parking.ParkingManagers = new List<User>();

            var username = GenerateUsername(userModel.FirstName, userModel.LastName);

            var user = new User()
            {
                UserName = username,
                HashPassword = BCryptNet.HashPassword(GeneratePassword(username, userModel.DateOfBirth)),
                Gender = userModel.Gender,
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                LastModifyAt = DateTime.Now,
                PhoneNumber = userModel.PhoneNumber,
                DateOfBirth = userModel.DateOfBirth,
                Email = userModel.Email,
                Role = Role.ParkingManager,
                Parking = parking,
                IsDisable = false,



            };




            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();

            var image = new Image()
            {
                URL = userModel.imageURL,
                User = user,
                UserID = user.ID
            };

            user.Image = image;


            parking.ParkingManagers.Add(user);
            _imageRepository.AddAsync(image);

            return user;
        }

        private string GenerateUsername(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName)) throw new AppException("Name of user can not empty any fields");
            var prefix = string.Empty;
            var postfix = string.Empty;
            var firstnames = firstName.Trim().Split(' ');
            var lastnames = lastName.Trim().Split(' ');

            foreach (var fn in firstnames)
            {
                prefix += fn.Trim();
            }

            foreach (var ln in lastnames)
            {
                if (ln != "") postfix += ln.Trim().Substring(0, 1);
            }

            var rawusername = (prefix + postfix).ToLower();

            //generate code
            var check = UsernameExisted(rawusername);
            if (check)
            {
                var postNumber = 0;
                var flag = true;
                var username = "";
                do
                {
                    postNumber++;
                    username = rawusername + postNumber.ToString();
                    flag = UsernameExisted(username);
                } while (flag);
                return username;
            }
            else
            {
                return rawusername;
            }
        }


        private string GeneratePassword(string username, DateTime dob)
        {
            return username + "@" + dob.ToString("ddMMyyyy");
        }

    }



}
