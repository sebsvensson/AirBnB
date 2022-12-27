using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.Interface
{
    public interface IPropertyRepository : IGenericRepository<Property>
    {
        Property? GetByPropId(int propId);
        Property GetByAdress(string adress);
        IEnumerable<Property> OrderByFacilities();
        IEnumerable<Property> OrderByRating();
        IEnumerable<Property> OrderByCity();
        IEnumerable<Property> OrderByPrice();

        IEnumerable<Property> GetUserProperties(User user);

        IEnumerable<Property> GetByPropertyCity(string city);
        IEnumerable<Property> GetByPropertyAdress(string adress);
        IEnumerable<Property> GetByPropertyFacilities(string facilities);
        IEnumerable<Property> GetByPropertyRating(float rating);
        IEnumerable<Property> GetAvailableProperties();
        IEnumerable<Property> GetPropertiesWithFiltering(string city, int price, string facilities, float rating);

    }
}
