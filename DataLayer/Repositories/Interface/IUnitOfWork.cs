using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interface
{
    public interface IUnitOfWork
    {
        public IPropertyRepository Properties { get; }
        public IBookingRepository Bookings { get; }
        public IReviewRepository Reviews { get; }
        public IUserRepository Users { get; }

        public void Seed(AirBnbContext airBnbContext);

        public void Complete();
    }

}
