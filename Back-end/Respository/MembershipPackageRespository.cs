using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public interface IMembershipPackageRespository
    {
        Task AddAsync(MembershipPackageModel model);
        Task DeleteAsync(string idString);
        Task<ICollection<MembershipPackage>> GetAllAsync();
        Task<MembershipPackage> GetAsync(string idString);
        void JoinTotheMemberShip(MembershipPackage membershipPackage, User subcriber);
        ICollection<MembershipPackage> PaginateAsync(ICollection<MembershipPackage> source, int pageNo, int pageSize);
        ICollection<MembershipPackage> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string id, MembershipPackageModel updateModel);
    }

    public class MembershipPackageRespository : IMembershipPackageRespository
    {

        private readonly ParkingDbContext _dbContext;
        private readonly ILogger<MembershipPackageRespository> _logger;
        private readonly IMapper _mapper;

        public MembershipPackageRespository(ParkingDbContext dbContext, ILogger<MembershipPackageRespository> logger, IMapper mapper)
        {
            _dbContext = dbContext;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task AddAsync(MembershipPackageModel model)
        {

            await _dbContext.MembershipPackages.AddAsync(_mapper.Map<MembershipPackage>(model));
            await _dbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(string idString)
        {
            var deleted = await GetAsync(idString);
            _dbContext.MembershipPackages.Remove(deleted);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<MembershipPackage>> GetAllAsync()
        {
            return await _dbContext.MembershipPackages.Include(m=>m.SubcribeBy).ToListAsync();
        }

        public async Task<MembershipPackage> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.MembershipPackages.Include(m => m.SubcribeBy).FirstOrDefaultAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public ICollection<MembershipPackage> PaginateAsync(ICollection<MembershipPackage> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<MembershipPackage> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(string idString, MembershipPackageModel updateModel)
        {
            var updated = await GetAsync(idString);

            updated.Price = updateModel.Price;
            updated.LastModifyAt = DateTime.Now;
            updated.Discription = updateModel.Discription;
            updated.Name = updateModel.Name;
            updated.Months = updateModel.Months;


            _dbContext.MembershipPackages.Update(updated);
            await _dbContext.SaveChangesAsync();
        }


        public void JoinTotheMemberShip(MembershipPackage membership, User subcriber)
        {
           
            membership.SubcribeBy.Add(subcriber);

            _dbContext.MembershipPackages.Update(membership);
            _dbContext.SaveChanges();
        }
    }
}
