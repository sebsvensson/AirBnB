using BusinessLayer.Interfaces;
using Model;
using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels
{
    public class EditPropertyViewModel : BaseViewModel
    {
        
        public int PropertyID { get; set; } 
        public string City { get; set; }
        public string Adress { get; set; }
        public int PricePerNight { get; set; }
        public string Facilities { get; set; }
        public string Description { get; set; }
        public ICommand EditPropertyCommand { get; set; }

        public EditPropertyViewModel(int propertyID)
        {
            PropertyID = propertyID;

            EditPropertyCommand = new EditPropertyCommand(this);Property property = App.Container.PropertyController.GetProperty(propertyID);

            City = property.City;
            Adress = property.Adress;
            PricePerNight = property.PricePerNight;
            Facilities = property.Facilities; 
            Description = property.Description;
            
        }
    }
}
