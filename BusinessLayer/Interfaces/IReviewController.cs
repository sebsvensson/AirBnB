using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IReviewController
    {
        void AddReview(int rating, string comment, User reviewer, Property property);
        IEnumerable<Review> GetReviews();

        IEnumerable<Review> GetPropertyReviews(Property property);
    }
}
