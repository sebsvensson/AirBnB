using BusinessLayer.Interfaces;
using DataLayer.Repositories.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Controllers
{
    public class ReviewController : IReviewController
    {
        private readonly IUnitOfWork unitOfWork;
   

        public ReviewController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddReview(int rating, string comment, User reviewer, Property property)
        {
            Review review = new Review()
            {

                Rating = rating,
                Comment = comment,
                Reviewer = reviewer,
                Property = property
            };

            unitOfWork.Reviews.Add(review);
            unitOfWork.Complete();

        }
        public IEnumerable<Review> GetPropertyReviews(Property property)
        {
            return unitOfWork.Reviews.GetPropertyReviews(property);
        }

        public void RemoveReviews(Review review)
        {
            unitOfWork.Reviews.Remove(review);
        }

        public IEnumerable<Review> GetReviews()
        {
            return unitOfWork.Reviews.GetAll();
        }
    }
}
