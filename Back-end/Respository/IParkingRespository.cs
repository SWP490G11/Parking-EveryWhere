using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public interface IParkingRespository
    {
        Task AddAsync(ParkingModel model, User owner);
        Task DeleteAsync(string idString);
        Task<ICollection<Parking>> GetAllAsync();
        Task<Parking> GetAsync(string idString);
        ICollection<Parking> PaginateAsync(ICollection<Parking> source, int pageNo, int pageSize);
        ICollection<Parking> SortAsync(DirectionOfSort direction, string factor);
        Task UpdateAsync(string idString, ParkingModel updateModel);
    }
}