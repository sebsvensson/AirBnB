using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interface
{
    public interface IReviewRepository : IGenericRepository<Review>
    {
        IEnumerable<Review> GetPropertyReviews(Property property);
    }
}
