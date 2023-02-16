using Back_end.Common;
using Back_end.Entities;
using Back_end.Models;

namespace Back_end.Respository
{
    public class ImageRepository : ICRUDSRespository<Image, ImageModel>
    {
        public Task AddAsync(ImageModel model)
        {
            throw new NotImplementedException();
        }

      

        public Task DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Image>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        
        public Task<Image> GetAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public ICollection<Image> PaginateAsync(ICollection<Image> source, int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Image> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(string idString, ImageModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
