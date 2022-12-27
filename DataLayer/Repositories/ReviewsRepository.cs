using DataLayer.Repositories.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class ReviewsRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewsRepository(AirBnbContext _context)
            : base(_context)
        {

        }
        public IEnumerable<Review> GetPropertyReviews(Property property)
        {
            return Context.Set<Review>()
                .Include(p => p.Property)
                .Where(p => p.Property.PropertyId == property.PropertyId).AsEnumerable()
                .OrderBy(p => p.Property.Rating);
        }

        public override void Remove(Review review)
        {
            
            Context.Reviews.Where(x => x.ReviewId == review.ReviewId).First();
            base.Remove(review);

        }
    }
}
