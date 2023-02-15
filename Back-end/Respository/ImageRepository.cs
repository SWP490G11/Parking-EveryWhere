using Back_end.Common;

namespace Back_end.Respository
{
    public class ImageRepository : ICRUDSRespository<ImageRepository>
    {
        public Task AddAsync()
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ImageRepository>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ImageRepository> GetAsync()
        {
            throw new NotImplementedException();
        }

        public ICollection<ImageRepository> PaginateAsync(ICollection<ImageRepository> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<ImageRepository> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync()
        {
            throw new NotImplementedException();
        }
    }
}
