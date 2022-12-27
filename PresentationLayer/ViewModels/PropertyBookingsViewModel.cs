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
    public class PropertyBookingsViewModel : BaseViewModel
    {
        private Booking selectedbooking;
        public Booking SelectedBooking { get => selectedbooking; set { selectedbooking = value; OnPropertyChanged(); } }

        public ObservableCollection<Booking> MyPropertyBookings { get; set; } = new ObservableCollection<Booking>();
        public ICommand RemovePropertyBookingCommand { get; set; }

        public PropertyBookingsViewModel()
        {
            RemovePropertyBookingCommand = new RemovePropertyBookingCommand(this);
            RefreshPropertyBookings();
        }

        internal void RefreshPropertyBookings()
        {
            MyPropertyBookings.Clear();

            IEnumerable<Booking> bookings = App.Container.BookingController.GetMyPropertyBookings(App.Container.LoggedIn);
            foreach (Booking booking in bookings)
            {
                MyPropertyBookings.Add(booking);
            }

        }
    }
}
