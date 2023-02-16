using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public interface ICarModelRespository
    {
        Task AddAsync(CarModelx2 model);
        Task DeleteAsync();
        Task<ICollection<CarModel>> GetAllAsync();
        Task<CarModel> GetAsync();
        ICollection<CarModel> PaginateAsync(ICollection<CarModel> source, int pageNo, int pageSize);
        ICollection<CarModel> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string id, CarModelx2 model);
    }
}