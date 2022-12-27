using Model;
using PresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PresentationLayer.ViewModels.Commands;

namespace PresentationLayer.ViewModels
{
    public class AddPropertyViewModel : BaseViewModel
    {

        public string City { get; set; }
        public string Adress { get; set; }
        public int PricePerNight { get; set; }
        public string Facilities { get; set; }
        public string Description { get; set; }

        //public ICollection<Review> Reviews { get; set; }
        public ICommand AddPropertyCommand { get; set; }
        public AddPropertyViewModel()
        {
            AddPropertyCommand = new AddPropertyCommand(this);
        }
    }
}
