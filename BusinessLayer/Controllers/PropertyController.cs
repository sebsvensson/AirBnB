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
    public class PropertyController : IPropertyController
    {
        private readonly IUnitOfWork? unitOfWork;

        public PropertyController(IUnitOfWork unitfwork)
        {
            this.unitOfWork = unitfwork;
        }

       

        public Property? GetProperty(int propertyId)
        {
            return unitOfWork.Properties.GetByPropId(propertyId);
        }

        public IEnumerable<Property> GetProperties()
        {
            return unitOfWork.Properties.GetAll();
        }

        public void RemoveProperty(Property property)
        {
            unitOfWork.Properties.Remove(property);
        }

        public void AddProperty(string city, string adress, int pricePerNight, string facilities, string description)
        {
            Property property = new Property();
            {
                property.City = city;
                property.Adress = adress;
                property.Facilities = facilities;
                property.PricePerNight = pricePerNight;
                property.Description = description;
            }
            unitOfWork?.Properties.Add(property);
            

            unitOfWork?.Complete();
        }
        public Property? GetByPropId(int propId)
        {
            return unitOfWork.Properties.GetByPropId(propId);
        }

        public IEnumerable<Property> GetUserProperties(User user)
        {
            return unitOfWork.Properties.GetUserProperties(user);
        }
        public Property GetByAdress(string adress)
        {
            return unitOfWork.Properties.GetByAdress(adress);
        }
        public void AttachUser(string adress, User user)
        {
            Property p = unitOfWork.Properties.GetByAdress(adress);
            p.Owner = user;
            unitOfWork?.Complete();
        }

       

        public IEnumerable<Property> GetByPropertyCity(string city)
        {
            return unitOfWork.Properties.GetByPropertyCity(city);
        }

        public IEnumerable<Property> GetByPropertyAdress(string adress)
        {
            return unitOfWork.Properties.GetByPropertyAdress(adress);
        }

        public IEnumerable<Property> GetByPropertyFacilities(string facilities)
        {
            return unitOfWork.Properties.GetByPropertyFacilities(facilities);
        }

        public IEnumerable<Property> GetByPropertyRating(float rating)
        {
            return unitOfWork.Properties.GetByPropertyRating(rating);
        }


        public IEnumerable<Property> GetAvailableProperties()
        {
            return unitOfWork.Properties.GetAvailableProperties();
        }

        public IEnumerable<Property> GetPropertiesFiltered(string city, string facilities, int pricePerNight, float rating)
        {
            return unitOfWork.Properties.GetPropertiesWithFiltering(city, pricePerNight, facilities, rating);
        }


        public void AttachReview(Review review, string adress)
        {
            Property property = unitOfWork.Properties.GetByAdress(adress);
            property.Reviews.Add(review);
            unitOfWork.Complete();
        }

        public void AttachBooking(Booking booking, string adress)
        {
            Property property = unitOfWork.Properties.GetByAdress(adress);
            property.Bookings.Add(booking);
            unitOfWork.Complete();
        }
    }
}

