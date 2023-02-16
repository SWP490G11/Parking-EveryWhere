using Back_end.Common;
using Back_end.Models;

namespace Back_end.Respository
{
    public class MembershipPackage : ICRUDSRespository<MembershipPackage, MembershipPackageModel>
    {
        public Task AddAsync(MembershipPackageModel model)
        {
            throw new NotImplementedException();
        }

       

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<MembershipPackage>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        
        public Task<MembershipPackage> GetAsync(string idString)
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

        public Task UpdateAsync(string idString, MembershipPackageModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
