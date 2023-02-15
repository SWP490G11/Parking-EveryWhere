using Back_end.Common;

namespace Back_end.Respository
{
    public class MembershipPackage : ICRUDSRespository<MembershipPackage>
    {
        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<MembershipPackage>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<MembershipPackage> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<MembershipPackage> PaginateAsync(ICollection<MembershipPackage> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<MembershipPackage> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
