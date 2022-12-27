using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface IPropertyController
    { 
        void AddProperty(string city, string adress, int pricePerNight, string facilities, string description);

        IEnumerable<Property> GetProperties();

        Property? GetProperty(int propertyId);
        IEnumerable<Property> GetByPropertyCity(string city);
        IEnumerable<Property> GetByPropertyAdress(string adress);
        IEnumerable<Property> GetByPropertyFacilities(string facilities);
        IEnumerable<Property> GetByPropertyRating(float rating);
        IEnumerable<Property> GetPropertiesFiltered(string city, string facilities, int pricePerNight, float rating);
        IEnumerable<Property> GetAvailableProperties();
        void AttachUser(string adress, User user);

        Property GetByAdress(string adress);
        Property GetByPropId(int propId);
        void RemoveProperty(Property property);

        IEnumerable<Property> GetUserProperties(User user);

        void AttachReview(Review review, string adress);
        void AttachBooking(Booking booking, string adress);
    }
}
