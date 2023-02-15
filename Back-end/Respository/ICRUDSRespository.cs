using Back_end.Common;

namespace Back_end.Respository
{
    public interface ICRUDSRespository<T,M>
    {
        public Task<ICollection<T>> GetAllAsync();

        public Task AddAsync(M model);
        public Task<T> GetAsync();
        public Task DeleteAsync();

        public Task UpdateAsync(string idString,M updateModel);

        public ICollection<T> PaginateAsync(ICollection<T> source,int pageNo,int pageSize);

        public ICollection<T> SortAsync(DirectionOfSort direction,string factor);
    }
}
