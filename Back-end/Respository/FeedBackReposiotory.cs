using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Back_end.Models.User;
using Microsoft.EntityFrameworkCore;
using System;

namespace Back_end.Respository
{
    public interface IFeedBackReposiotory
    {
        void CreateFeedBack(FeedbackModel feedbackModel, User feedbackby);
        Task Delete(string ID);
        Task<ICollection<Feedback>> GetAllFeedbacksAsync();
        Task<Feedback> GetFeedbacksAsync(string idString);
        void UpdateFeedBack(string id, UpdateFeedbackModel feedbackModel);

       
    }

    public class FeedBackReposiotory : IFeedBackReposiotory
    {
        private readonly ParkingDbContext _dbContext;
        private readonly IImageRepository _imageRepository;

        public FeedBackReposiotory(ParkingDbContext dbContext, IImageRepository imageRepository)
        {
            _dbContext = dbContext;
            _imageRepository = imageRepository;
        }

        public async Task<ICollection<Feedback>> GetAllFeedbacksAsync()
        {

            return await _dbContext.Feedbacks.Include(f => f.Images).Include(f=>f.Parking).Include(f=>f.FeedbackBy).
                ThenInclude(f => f.Image).ToListAsync();
        }

        public async Task<Feedback> GetFeedbacksAsync(string idString)
        {

            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Feedbacks.Include(f => f.Images).Include(f => f.Parking).
                Include(f => f.FeedbackBy).ThenInclude(f=>f.Image).FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public void CreateFeedBack(FeedbackModel feedbackModel,User feedbackby)
        {

            var images = new List<Image>();

           

            var fedback = new Feedback()
            {
                Content = feedbackModel.Content,
                Rating = feedbackModel.Rating,
                LastModifyAt = DateTime.Now,
                Parking =  _dbContext.Parkings.FirstOrDefault(c => c.ID.ToString().ToUpper().Trim().
                Equals(feedbackModel.ParkingID.ToUpper().Trim()
                )),
                FeedbackBy= feedbackby,
            };
            foreach (var url in feedbackModel.ImageURLs)
            {
                var image = new Image()
                {
                    URL = url.Trim(),
                    Feedback = fedback

                };
                images.Add(image);
            }

     
             _dbContext.Feedbacks.Add(fedback);
            feedbackby.Feedbacks.Add(fedback);

            _imageRepository.AddRageAsync(images);
        }


        public void UpdateFeedBack(string id, UpdateFeedbackModel feedbackModel)
        {
            var updated =  _dbContext.Feedbacks.FirstOrDefault(c => c.ID.ToString().ToUpper().Trim().
                Equals(id.ToUpper().Trim()));
            updated.Content = feedbackModel.Content;
            updated.Rating = feedbackModel.Rating;
            updated.LastModifyAt = DateTime.Now;

            var deletedimages = updated.Images == null ? new List<Image>() : updated.Images;
            _imageRepository.DeleteRange(deletedimages);
            var images = new List<Image>();
            foreach (var url in feedbackModel.ImageURLs)
            {
                var image = new Image()
                {
                    URL = url,
                    Feedback = updated,
                };
                images.Add(image);
            }

            updated.Images = images;

            _dbContext.Update(updated);
            _imageRepository.AddRageAsync(images);
        }


        public async Task Delete(string ID)
        {
            var deleted = await GetFeedbacksAsync(ID);
            _dbContext.Remove(deleted);
            _dbContext.SaveChanges();
        }

    }

    public class UpdateFeedbackModel
    {
       
        public string Content { get; set; }

        public float Rating { get; set; }

        public List<string> ImageURLs { get; set; }
    }
}
