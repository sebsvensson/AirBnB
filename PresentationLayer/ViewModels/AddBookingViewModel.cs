using Model;
using PresentationLayer.ViewModels.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PresentationLayer.ViewModels
{
    public class AddBookingViewModel : BaseViewModel
    {
        public int PropID { get; set; }
        public Property Property { get; set; }
        public ObservableCollection<Property> Properties { get; set; } = new ObservableCollection<Property>();
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddDays(2);
        public int AmountOfPeople { get; set; }
        public ICommand AddBookingCommand { get; set; }

        public AddBookingViewModel(int propID)
        {
            PropID = propID;

            AddBookingCommand = new AddBookingCommand(this);
            UpdateProp();
        }

        internal void UpdateProp()
        {
            Properties.Clear();

            Property = App.Container.PropertyController.GetByPropId(PropID);

            Properties.Add(Property);
        }
    }
}