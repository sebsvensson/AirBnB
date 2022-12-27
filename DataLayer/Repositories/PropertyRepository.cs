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
    public class PropertyRepository : GenericRepository<Property>, IPropertyRepository
    {
        public PropertyRepository(AirBnbContext context)
            : base(context)
        {

        }
        public override void Remove(Property entity)
        {
            Context.Properties.Where(x => x.PropertyId == entity.PropertyId).First();
            base.Remove(entity);
        }

        public Property? GetByPropId(int propId)
        {
            return Context.Set<Property>()
                .Where(x => x.PropertyId == propId)
                .FirstOrDefault();
        }
        
        public IEnumerable<Property> OrderByPrice()
        {
            return Context.Properties.OrderBy(x => x.PricePerNight).ToList();
            
        }

        public IEnumerable<Property> OrderByCity()
        {
            return Context.Properties.OrderBy(x => x.City).ToList();
            
        }

        public IEnumerable<Property> OrderByRating()
        {
            return Context.Properties.OrderBy(x => x.Rating).ToList();
            
        }

        public IEnumerable<Property> OrderByFacilities()
        {
            return Context.Properties.OrderBy(x => x.Facilities).ToList();
           
        }

        public IEnumerable<Property> GetAvailableProperties()
        {
            return Context.Set<Property>()
                .Where(p => p.Available == true);
        }

        public IEnumerable<Property> GetByPropertyCity(string city)
        {
           return Context.Set<Property>()
                .Include(p => p.City)
                .Include(p => p.Rating)
                .Include(p => p.Facilities)
                .Include(p => p.Rating)
                .Where(p => p.City == city).ToList();

        }

        public IEnumerable<Property> GetByPropertyAdress(string adress)
        {
            return Context.Set<Property>()
                .Include(p => p.City)
                .Include(p => p.Rating)
                .Include(p => p.Facilities)
                .Include(p => p.Rating)
                .Where(p => p.Adress == adress).ToList();
        }

        public IEnumerable<Property> GetByPropertyFacilities(string facilities)
        {
            return Context.Set<Property>()
                .Include(p => p.City)
                .Include(p => p.Rating)
                .Include(p => p.Facilities)
                .Include(p => p.Rating)
                .Where(p => p.Facilities == facilities).ToList();
        }

        public IEnumerable<Property> GetByPropertyRating(float rating)
        {
            return Context.Set<Property>()
                .Include(p => p.City)
                .Include(p => p.Rating)
                .Include(p => p.Facilities)
                .Include(p => p.Rating)
                .Where(p => p.Rating == rating).ToList();
        }

        public Property? GetByAdress(string adress)
        {
            return Context.Set<Property>()
                .Include(p => p.Adress)
                .Include(p => p.City)
                .Include(p => p.Facilities)
                .Include(p => p.Reviews)
                .Include(p => p.Bookings)
                .Include(p => p.Owner)
                .Where(p => p.Adress == adress).FirstOrDefault();
        }

        public IEnumerable<Property> GetPropertiesWithFiltering(string city, int price, string facilities, float rating)
        {
            return Context.Set<Property>()
                .Include(p => p.City)
                .Include(p => p.Adress)
                .Include(p => p.Facilities)
                .Include(p => p.Reviews)
                .Include(p => p.Owner)
                .AsEnumerable()
                .Where(prop => prop.City == city && prop.Facilities == facilities && prop.PricePerNight <= price && prop.Rating >= rating)
                .OrderByDescending(p => p.Rating);
        }

        public IEnumerable<Property> GetUserProperties(User user)
        {
            return Context.Set<Property>()
                .Include(p => p.Reviews)
                .Include(p => p.Facilities)
                .Include(p => p.Owner)
                .Where(p => p.Owner.Id == user.Id).ToList();
        }
    }
}
