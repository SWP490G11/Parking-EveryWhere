using AutoMapper;
using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_end.Respository
{
    public class MembershipPackageRespository : ICRUDSRespository<MembershipPackage, MembershipPackageModel>
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
            try
            {
                await _dbContext.MembershipPackages.AddAsync(_mapper.Map<MembershipPackage>(model));
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, "Has error:");
            }
        }

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<MembershipPackage>> GetAllAsync()
        {
            return await _dbContext.MembershipPackages.ToListAsync();
        }

        public async Task<MembershipPackage> GetAsync(string idString)
        {
            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.MembershipPackages.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
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

        public Task UpdateAsync(string idString, MembershipPackageModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
