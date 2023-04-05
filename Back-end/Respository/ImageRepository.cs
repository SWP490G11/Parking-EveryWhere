using Back_end.Common;
using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;

namespace Back_end.Respository
{
    public interface IImageRepository
    {
        void AddAsync(Image? model);
        void AddRageAsync(ICollection<Image> models);
        void DeleteAsync(string idString);
        Image Get(string idString);
        ICollection<Image> GetAllAsync();
        ICollection<Image> PaginateAsync(int pageNo, int pageSize);
        ICollection<Image> SortAsync(DirectionOfSort direction, string factor);
        void UpdateAsync(Image updateImage);

        public void UpdateRange(List<Image> newimages);

        void DeleteRange(ICollection<Image> images);
    }

    public class ImageRepository : IImageRepository
    {

        private readonly ParkingDbContext _dbContext;

        public ImageRepository(ParkingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddAsync(Image? addModel)
        {

            _dbContext.Images.Add(addModel);
            _dbContext.SaveChanges();
        }


        public void AddRageAsync(ICollection<Image> images)

        {
           
            _dbContext.Images.AddRange(images);
            _dbContext.SaveChanges();
        }



        public void DeleteAsync(string idString)
        {
            throw new NotImplementedException();
        }

        public ICollection<Image> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public Image Get(string idString)
        {

            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();

            return _dbContext.Images.FirstOrDefault(c => c.ID.ToString().ToUpper().Trim().
                 Equals(idString.ToUpper().Trim()
                 )); ;

        }

        public ICollection<Image> PaginateAsync(int pageNo, int pageSize)
        {
            throw new NotImplementedException();
        }

        public ICollection<Image> SortAsync(DirectionOfSort direction, string factor)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(Image updatedImage)
        {
            
            _dbContext.Images.Update(updatedImage);
            _dbContext.SaveChanges();

        }

        public void UpdateRange(List<Image> newimages)
        {
           
            _dbContext.UpdateRange(newimages);
            _dbContext.SaveChanges(true);
         }

        public void DeleteRange(ICollection<Image> images)
        {
            _dbContext.Images.RemoveRange(images);
            _dbContext.SaveChanges();
        }
    }
}
