using Back_end.Entities;
using Back_end.Helper;
using Back_end.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Back_end.Respository
{
    public interface IFeedBackReposiotory
    {
        Task CreateFeedBack(FeedbackModel feedbackModel);
        Task Delete(string ID);
        Task<ICollection<Feedback>> GetAllFeedbacksAsync();
        Task<Feedback> GetFeedbacksAsync(string idString);
        Task UpdateFeedBack(string id, UpdateFeedbackModel feedbackModel);
    }

    public class FeedBackReposiotory : IFeedBackReposiotory
    {
        private readonly ParkingDbContext _dbContext;

        public FeedBackReposiotory(ParkingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ICollection<Feedback>> GetAllFeedbacksAsync()
        {

            return await _dbContext.Feedbacks.Include(f => f.Images).ToListAsync();
        }

        public async Task<Feedback> GetFeedbacksAsync(string idString)
        {

            if (string.IsNullOrEmpty(idString)) throw new ArgumentNullException();
            return await _dbContext.Feedbacks.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(idString.ToUpper().Trim()
                ));
        }

        public async Task CreateFeedBack(FeedbackModel feedbackModel)
        {

            var images = new List<Image>();

            foreach (var url in feedbackModel.ImageURLs)
            {
                var image = new Image()
                {
                    URL = url.Trim(),

                };
                images.Add(image);
            }

            var fedback = new Feedback()
            {
                Content = feedbackModel.Content,
                Rating = feedbackModel.Rating,
                LastModifyAt = DateTime.Now,
                Parking = await _dbContext.Parkings.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(feedbackModel.ParkingID.ToUpper().Trim()
                )),

            };
            await _dbContext.Feedbacks.AddAsync(fedback);
            _dbContext.SaveChanges();

            foreach (var image in images)
            {
                image.Feedback = await GetFeedbacksAsync(fedback.ID.ToString());
            }

            fedback.Images = images;

            await _dbContext.Images.AddRangeAsync(images);
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateFeedBack(string id, UpdateFeedbackModel feedbackModel)
        {
            var updated = await _dbContext.Feedbacks.FirstAsync(c => c.ID.ToString().ToUpper().Trim().
                Equals(id.ToUpper().Trim()));
            updated.Content = feedbackModel.Content;
            updated.Rating = feedbackModel.Rating;
            updated.LastModifyAt = DateTime.Now;


            _dbContext.SaveChanges();
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
